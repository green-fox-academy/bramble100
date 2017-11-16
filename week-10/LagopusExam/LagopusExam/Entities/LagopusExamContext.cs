using LagopusExam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusExam.Entities
{
    public class LagopusExamContext : DbContext
    {
        public DbSet<QuizQuestion> QuizQuestions { get; private set; }
        public int QuizQuestionsCount
            => QuizQuestions.Count();

        public LagopusExamContext(DbContextOptions<LagopusExamContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public void AddQuizQuestion(QuizQuestion quizQuestion)
        {
            if (quizQuestion == null)
            {
                throw new ArgumentNullException();
            }

            Add(quizQuestion);
            SaveChanges();
        }

        public QuizQuestion ReadQuizQuestion(int id) 
            => Find<QuizQuestion>(id);
    }
}
