using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProforgDataEF
{
    [MetadataType(typeof(StudentsMD))]
    partial class Students
    {
        public class StudentsMD
        {
            [HiddenInput(DisplayValue = false)]
            public int student_ID { get; set; }

            [Required]
            [Display(Name = "ПІБ")]
            public string student_name { get; set; }

            [Display(Name = "Група")]
            public int student_group_ID { get; set; }
        }
    }
}
