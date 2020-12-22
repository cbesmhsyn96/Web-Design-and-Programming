using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modelkullanimi.Models
{
    public class AnaModel
    {
        public Altmodel1 altmodel1 { get; set; }
        public List<Altmodel2> altmodel2 { get; set; }
        public string anamodel_yazi { get; set; }
    }
}