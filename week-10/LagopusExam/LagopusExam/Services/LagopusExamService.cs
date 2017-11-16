using LagopusExam.Models;
using LagopusExam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusExam.Services
{
    public class LagopusExamService
    {
        private LagopusExamRepository lagopusExamRepository;
        private Random random;

        public LagopusExamService(
            LagopusExamRepository lagopusExamRepository,
            Random random)
            => this.lagopusExamRepository = lagopusExamRepository;

        public void AddQuizQuestion(QuizQuestion quizQuestion)
            => lagopusExamRepository.AddQuizQuestion(quizQuestion);

        public HashSet<QuizQuestion> ListOfNRandomQuestions(int numberOfQuestions)
        {
            HashSet<QuizQuestion> result = new HashSet<QuizQuestion>();
            List<int> idCollection = (List<int>)Enumerable.Range(1, lagopusExamRepository.QuestionsCount);

            for (int i = 0; i < numberOfQuestions; i++)
            {
                var id = random.Next(idCollection.Count);
                result.Add(lagopusExamRepository.ReadQuizQuestion(idCollection[id]));
                idCollection.Remove(id);
            }

            return result;
        }

        public QuizQuestion ReadQuizQuestion(int id)
            => lagopusExamRepository.ReadQuizQuestion(id);
       
        public QuizQuestions ReadQuizQuestions(int id)
            => lagopusExamRepository.ReadQuizQuestions(id);

        public void SaveQuizQuestions(QuizQuestions quizQuestions)
            => lagopusExamRepository.SaveQuizQuestions(quizQuestions);
    }
}