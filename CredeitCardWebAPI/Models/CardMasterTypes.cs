using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CredeitCardWebAPI.Models
{
    public class CardMasterTypes: BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardTypeId { get; set; }
        public string CardType { get; set; }

        public ICollection<CardDetails> CardDetails { get; set; }
    }
}
