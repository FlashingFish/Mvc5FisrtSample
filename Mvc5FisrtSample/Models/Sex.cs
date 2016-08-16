using System.ComponentModel.DataAnnotations;

namespace Mvc5FisrtSample.Models
{
    public class Sex
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}