using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_02.Models.Interface
{
    interface IText : IForm
    {
        string name { get; set; }
        string placeholder { get; set; }
        string required { get; set; }
        ValidationRules validationRules { get; set; }
        string value { get; set; }
        string label { get; set; }
        string css { get; set;}
        bool disabled { get; set; }
    }
}
