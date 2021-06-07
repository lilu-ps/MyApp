using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.DataModels
{
    public class Statement
    {
        [Key]
        public long statementId { get; set; }
        public byte[] statementImage { get; set; }
        public string statementName { get; set; }
        public string statementDescription { get; set; }
        public string phoneNumber { get; set; }
    }
}
