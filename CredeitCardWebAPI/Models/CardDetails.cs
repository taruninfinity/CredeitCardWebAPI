using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Models
{
    public class CardDetails:BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardDetailId { get; set; }

        [ForeignKey("CardMasterTypes")]
        public int CardTypeId { get; set; }
        public string CardNumber { get; set; }
        public int AnnualCharge { get; set; }
        public int CreditLimit { get; set; }

        public CardMasterTypes CardMasterTypes { get; set; }
    }
}
