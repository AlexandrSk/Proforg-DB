using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProforgDataEF
{
    [MetadataType(typeof(TicketsMD))]
    partial class Tickets
    {
        public class TicketsMD
        {
            [HiddenInput(DisplayValue = false)]
            public int ticket_ID { get; set; }

            [Display(Name = "Ціна")]
            public string ticket_prise { get; set; }

            [Display(Name = "Тип квитка")]
            public int ticket_type_ID { get; set; }

            [Display(Name = "Кількість")]
            public int ticket_count { get; set; }

        }
    }
}
