using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProforgDataEF
{
    [MetadataType(typeof(OrderMD))]
    partial class Order
    {
        public class OrderMD
        {
            [HiddenInput(DisplayValue = false)]
            public int order_ID { get; set; }

            [Required]
            [Display(Name = "ПІБ")]
            public int order_student_ID { get; set; }

            [Display(Name = "Квиток")]
            public int order_ticket_ID { get; set; }

            [Display(Name = "Кількість")]
            public int order_count { get; set; }


        }
    }
}
