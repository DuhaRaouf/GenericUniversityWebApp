using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]  //attribute 3lshan a5ly el InstructorID hws el Pk
        [ForeignKey("Instructor")] //attribute 3lshan a5ly el InstructorID hws el FK (kda hwa rbt b el Instructor )
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}