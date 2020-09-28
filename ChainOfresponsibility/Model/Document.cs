using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChainOfresponsibility.Model
{
    enum DocumentType
    {
        Programe,
        Money,
        Interview
    }
    class Document
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DocumentType Type { get; set; }
        [Required]
        public string Description { get; set; }
        
    }
}
