using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusExam.Models
{
    public class QuizQuestions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public List<QuizQuestion> Questions { get; set; }
    }
}
