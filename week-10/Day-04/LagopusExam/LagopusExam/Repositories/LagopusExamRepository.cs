using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagopusExam.Entities;
using LagopusExam.Models;

namespace LagopusExam.Repositories
{
    public class LagopusExamRepository
    {
        private LagopusExamContext lagopusExamContext;

        public int NumberOfQuestions 
            => lagopusExamContext.NumberOfQuestions;

        public LagopusExamRepository(LagopusExamContext lagopusExamContext)
            => this.lagopusExamContext = lagopusExamContext;

        public QuestionWithAnswer GetQuestionById(int id)
            => lagopusExamContext.GetQuestionById(id);

        public int SaveQuiz(int questionId) 
            => lagopusExamContext.SaveQuiz(questionId);

        public Quiz GetQuizById(int quizId)
        {
            IEnumerable<int> IDs = lagopusExamContext.GetQuestionIDsByQuizId(quizId);
            return new Quiz()
            {
                Id = quizId,
                QuestionId = IDs.First()
            };
        }

        public void AddQuestion(QuestionWithAnswer question) 
            => lagopusExamContext.AddQuestion(question);

        public int GetQuestionIdByQuizId(int quizId) 
            => lagopusExamContext.GetQuestionIdByQuizId(quizId);

        public bool IsAnswerCorrectByQuestionId(int questionId, string answer)
            => lagopusExamContext.IsAnswerCorrectByQuestionId(questionId, answer);
    }
}
