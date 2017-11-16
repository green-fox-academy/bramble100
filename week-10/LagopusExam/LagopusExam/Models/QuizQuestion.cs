using System.ComponentModel.DataAnnotations;

namespace LagopusExam.Models
{
    public class QuizQuestion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
    }
}