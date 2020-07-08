using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace webapi.Domain.Models
{
    public class KeyObject
    {
        [Key]
        public int IdKey { get; set; }

        //[MaxLength(30, ErrorMessage = "Limite máximo atingido")]
        //[DisplayName("Nome do Livro")]
        public string KeyValue { get; set; }

        //[MaxLength(20, ErrorMessage = "Limite máximo atingido")]
        //[DisplayName("Autor")]
        public string KeyGroup { get; set; }

        public string KeyRelease { get; set; }

        public DateTime? KeyUsedTimestamp { get; set; }

        public DateTime? KeyClosedTimestamp { get; set; }
    }
}
