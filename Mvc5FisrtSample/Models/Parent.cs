using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc5FisrtSample.Models
{
    public class Parent
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int SexId { get; set; }
        public virtual Sex Sex { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}