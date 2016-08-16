using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc5FisrtSample.Models
{
    public class Child
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int SexId { get; set; }
        public virtual Sex Sex { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        [Required]
        public int ParentId { get; set; }
        [Required]
        public virtual Parent Parent { get; set; }
    }
}