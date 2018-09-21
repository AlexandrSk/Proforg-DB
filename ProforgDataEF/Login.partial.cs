using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProforgDataEF
{
    [MetadataType(typeof(LoginMD))]
    partial class Login
    {
        public class LoginMD
        {
            [HiddenInput(DisplayValue = false)]
            public int LG_ID { get; set; }

            [HiddenInput(DisplayValue = false)]
            public bool LG_ISADMIN { get; set; }

            [Required]
            [Display(Name = "Пароль")]
            public string LG_PASSWORD { get; set; }

            [Display(Name = "Логін")]
            public string LG_LOGIN { get; set; }

        }
    }
}
