using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; /*namespace 3lshan a8er asm el Column f el database*/

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(30, ErrorMessage = "The Last name is wrong ")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name ="Last Name")] //اغير الاسم الي هيظهر في الview
        public string LastName { get; set; }


        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(30, ErrorMessage ="The First name is wrong ")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "First Name")]   //اغير الاسم الي هيظهر في الview
        [Column("FirstName")] // 3lshan a8er asm el Column f el database*/
        public string FirstMidName { get; set; }


        [DataType(DataType.Date)]  //3lshan ekon datetie boreder mawgod w mktbsh baedy
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]  //3lshan shkl el date ekon kda bs hwa msh het8er shkloi 8er f el view bs 
        [Display(Name = " Enrollment Date")] //اغير الاسم الي هيظهر في الview
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName   //method tget el fullname
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        //NAVIGATION PROP
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}