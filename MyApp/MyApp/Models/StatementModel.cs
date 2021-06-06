using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class StatementModel
    {
        [Key]
        public long statementId { get; set; }
        public byte[] statementImage { get; set; }
        public string statementName { get; set; }
        public string statementDescription { get; set; }
        public string phoneNumber { get; set; }
    }
}
