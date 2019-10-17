using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSchedule.Models
{
    public class Vehicel
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public decimal Price { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public decimal DepositAmount { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DeliverytDate { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public int FinanceTerm { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public decimal CompletionFee { get; set; }
    }
}
