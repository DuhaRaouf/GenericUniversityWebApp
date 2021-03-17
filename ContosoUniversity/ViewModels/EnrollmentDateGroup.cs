using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;  //namespace ll decoratoin 3lshan a3ml attribute  [DataType(DataType.Date)]

namespace ContosoUniversity.ViewModels
{
    public class EnrollmentDateGroup  //attribute 3lshan ezhr el date bs mn 8er el time  
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}