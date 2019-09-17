using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DT_02.Models.Interface;

namespace DT_02.Models
{
    public class FormModel 
    {
        public Form form { get; set; }
        
    }
    public class Form
    {
        public string name { get; set; }
        public List<Model> items { get; set; }
        public string postmessage { get; set; }
    }
    public class Model {
        public String type { get; set; }
        public String message { get; set; }
        public String placeholder { get; set; }
        public Boolean required { get; set; }
        public String value { get; set; }
        public ValidationRules validationRules { get; set; }
        public List<RadioItems> items { get; set; }
        public String label { get; set; }
        public Boolean disabled { get; set; }
        public Boolean check { get; set; }
        public Boolean selected { get; set; }
        public String text { get; set; }
    }
    public class RadioItems
    {
        public String label { get; set; }
        public String value { get; set; }
        public Boolean check {get; set;}
    }
    public class FormBlock {
        public string div { get; set; }
    }
}