using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_02.Models.Interface
{
    interface IFormModel
    {
        //List<string> form { get; set; }
        string name { get; set; }
        List<string> items { get; set; }
        string postmessage { get; set; }
    }
}
