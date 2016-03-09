using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SitoDeiSiti.Models
{
    public class Sito
    {
        public string Nome { get; set; }
        public string Link { get; set; }
        public string PhotoLink { get; set; }
    }
}