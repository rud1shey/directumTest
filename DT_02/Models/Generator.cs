using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace DT_02.Models
{
    public static class Generator
    {
        public static JavaScriptSerializer serializer = new JavaScriptSerializer();
        public static string GenerateTextForm(Model model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<div class=\"{0}\" style=\"{1}\">", "", "");
            sb.Append(addInputMask(model));
            sb.Append("</div>");
            return sb.ToString();
        }

        public static string GenerateTextAreaForm(Model model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<div class=\"{0}\" style=\"{1}\">", "", "");
            sb.Append(addInputMask(model));
            sb.Append("</div>");
            return sb.ToString();
        }
        public static string GenerateCheckBoxForm(Model model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<div class=\"{0}\" style=\"{1}\">", "", "");
            sb.Append(addInputMask(model));
            sb.Append("</div>");
            return sb.ToString();
        }

        public static string GenerateButtonForm(Model model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<button text=\"{0}\">", model.text);
            sb.Append("</button>");
            return sb.ToString();
        }
        public static string GenerateSelectForm(Model model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<select value=\"{0}\" text=\"{1}\" selected=\"{2}\">", model.value, model.text, model.selected);
            sb.Append("</select>");
            return sb.ToString();
        }
        public static string GenerateRadioForm(Model model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<div", "", "");
            sb.Append(GenerateFillerForm(model));
            
            foreach (RadioItems rItems in model.items)
            {
                sb.AppendFormat("{0} name=\"{2}\" type=\"radio\" value=\"{1}\" {3}></input>", addInputMask(model), rItems.label, rItems.value, 
                    rItems.check ? "checked" : "");    
            }
            sb.Append("</div>");

            return sb.ToString();
        }

        public static string GenerateFillerForm(Model model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<div>");
            sb.Append(model.message);
            sb.Append("</div>");
            return sb.ToString();
        }
        private static string addInputMask(Model text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<input ");
            sb.AppendFormat("required=\"{0}\"", text.required);
            sb.AppendFormat("placeholder=\"{0}\"", text.placeholder);
            if(text.check)
                sb.AppendFormat("checked=\"{0}\"", text.check);
            if (text.value != null)
                sb.AppendFormat("value=\"{0}\"", text.value);
            if(text.label !=null)
                sb.AppendFormat("label=\"{0}\"", text.label);
            sb.AppendFormat("type=\"{0}\"", text.validationRules.type);
            sb.AppendFormat("disabled=\"{0}\"", text.disabled);
            return "";
        }
    }
}