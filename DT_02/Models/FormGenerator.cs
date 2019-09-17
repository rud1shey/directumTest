using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace DT_02.Models
{
    public class FormGenerator
    {
        string result;
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        public string GetJsonFile(string path)
        {
            string textForm = null;
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                textForm = System.Text.Encoding.Default.GetString(array);
            }
            return File.ReadAllText(path);
        }

        public string ParseJsonFile(string text)
        {
            
            FormModel fModel = serializer.Deserialize<FormModel>(text);
            return GenerateForm(fModel);
        }

        public string GenerateForm(FormModel fModel)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in fModel.form.items)
            {
                string ss = item.type.ToString();
                switch (item.type)
                {
                    case "text":
                        sb.Append(Generator.GenerateTextForm(item));
                        break;
                    case "filler":
                        sb.Append(Generator.GenerateFillerForm(item));
                        break;
                    case "textarea":
                        sb.Append(Generator.GenerateTextAreaForm(item));
                        break;
                    case "checkbox":
                        sb.Append(Generator.GenerateCheckBoxForm(item));
                        break;
                    case "button":
                        sb.Append(Generator.GenerateButtonForm(item));
                        break;
                    case "select":
                        sb.Append(Generator.GenerateSelectForm(item));
                        break;
                    case "radio":
                        sb.Append(Generator.GenerateRadioForm(item));
                        break;
                    default:
                        break;
                }
            }

            return sb.ToString();
        }

        

        public string GetNewForm()
        {
            return result;
        }
    }
}