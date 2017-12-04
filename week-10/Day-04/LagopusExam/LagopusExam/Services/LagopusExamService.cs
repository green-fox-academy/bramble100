using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LagopusExam.Models;
using LagopusExam.Repositories;

namespace LagopusExam.Services
{
    public class LagopusExamService
    {
        private LagopusExamRepository lagopusExamRepository;
        private Random random;

        public LagopusExamService(LagopusExamRepository lagopusExamRepository, Random random)
        {
            this.lagopusExamRepository = lagopusExamRepository;
            this.random = random;
        }

        public QuestionWithAnswer GetQuestionById(int id) 
            => lagopusExamRepository.GetQuestionById(id);

        public int GenerateNewQuiz()
        {
            int questionId = random.Next(lagopusExamRepository.NumberOfQuestions) + 1;

            return lagopusExamRepository.SaveQuiz(questionId);
        }

        public Quiz GetQuizById(int quizId) 
            => lagopusExamRepository.GetQuizById(quizId);

        public void AddQuestion(QuestionWithAnswer question)
            => lagopusExamRepository.AddQuestion(question);

        public bool CheckQuizWithAnswerUnChecked(QuizWithAnswerUnChecked quizWithAnswerUnChecked)
        {
            int questionId = lagopusExamRepository.GetQuestionIdByQuizId(quizWithAnswerUnChecked.Id);
            return lagopusExamRepository.IsAnswerCorrectByQuestionId(questionId, quizWithAnswerUnChecked.Answer);
        }
    }
}
