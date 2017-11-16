using LagopusExam.Entities;
using LagopusExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusExam.Repositories
{
    public class LagopusExamRepository
    {
        private LagopusExamContext lagopusExamContext;

        public LagopusExamRepository(LagopusExamContext lagopusExamContext) 
            => this.lagopusExamContext = lagopusExamContext;

        public int QuestionsCount
            => lagopusExamContext.QuizQuestionsCount;

        public void AddQuizQuestion(QuizQuestion quizQuestion)
            => lagopusExamContext.AddQuizQuestion(quizQuestion);

        public QuizQuestion ReadQuizQuestion(int id)
            => lagopusExamContext.ReadQuizQuestion(id);

        public QuizQuestions ReadQuizQuestions(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveQuizQuestions(QuizQuestions quizQuestions)
        {
            foreach (var question in quizQuestions.Questions)
            {
                lagopusExamContext.Save()
            };
        }
    }
}
