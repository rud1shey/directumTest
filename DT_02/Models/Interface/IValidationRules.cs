using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_02.Models.Interface
{
    interface IValidationRules
    {
        Type type { get; set; }
    }

    interface IType
    {
        string text { get; set; }
        string tel { get; set; }
        string email { get; set; }
        bool select { get; set; }
        bool radio { get; set; }
        bool checkbox { get; set; }
    }
}
