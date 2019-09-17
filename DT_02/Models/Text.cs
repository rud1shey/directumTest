using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DT_02.Models.Interface;

namespace DT_02.Models
{
    public class Text : IText
    {
        public string tytle { get; set; }
        public string name { get; set; }
        public string placeholder { get; set; }
        public string required { get; set; }
        public ValidationRules validationRules { get; set; }
        public string value { get; set; }
        public string label { get; set; }
        public string css { get; set; }
        public bool disabled { get; set; }
    }
}