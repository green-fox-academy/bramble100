using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagopusExam.Models;

namespace LagopusExam.Entities
{
    public class LagopusExamContext : DbContext
    {
        private DbSet<QuestionWithAnswer> QuestionsWithAnswer { get; set; }
        private DbSet<Quiz> Quizes { get; set; }

        public int NumberOfQuestions
            => QuestionsWithAnswer.Count();

        public LagopusExamContext(DbContextOptions<LagopusExamContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public QuestionWithAnswer GetQuestionById(int id)
        {
            if (id <= 0 || id > QuestionsWithAnswer.Count())
            {
                throw new ArgumentOutOfRangeException();
            }
            return QuestionsWithAnswer.Find(id);
        }

        public IEnumerable<int> GetQuestionIDsByQuizId(int quizId) => (from quiz in Quizes
                                                                       where quiz.Id == quizId
                                                                       select quiz.QuestionId);

        public int SaveQuiz(int questionId)
        {
            var quiz = Quizes.Add(new Quiz() { QuestionId = questionId });
            SaveChanges();
            return quiz.Entity.Id;
        }

        public int GetQuestionIdByQuizId(int quizId) => (from quiz in Quizes
                                                         where quiz.Id == quizId
                                                         select quiz.QuestionId).First();

        public bool IsAnswerCorrectByQuestionId(int questionId, string answer) 
            => (from question in QuestionsWithAnswer
                where question.Id == questionId
                select question.Answer).First().Equals(answer);

        public void AddQuestion(QuestionWithAnswer question)
        {
            QuestionsWithAnswer.Add(question);
            SaveChanges();
        }
    }
}
