using System;
using System.ComponentModel;
using System.Web.Mvc;

namespace BootstrapSwitchModel.Controls
{
    public static class OptionsControl
    {
        public static MvcHtmlString BootstrapSwitch(this HtmlHelper helper, string controlName, Models.BootstrapSwitchModel model, bool defineScript = true)
        {
            string code = "<input type='checkbox' id='{0}' name='{0}'  {1} /> ";

            code = string.Format( code, controlName, GetBootstrapSwitchModelProperties(model));

            if (defineScript)
            {
                string script = "<script>$(document).ready(function () {{$('#{0}').bootstrapSwitch();}});</script>";
                script = string.Format(script, controlName);
                code = script + code;
            }

            return MvcHtmlString.Create(code);
        }

        private static string GetBootstrapSwitchModelProperties(Models.BootstrapSwitchModel model)
        {
            string stringProperties = "";

            var properties = model.GetType().GetProperties();

            foreach (var property in properties)
            {
                foreach (var attribute in property.GetCustomAttributes(true))
                {
                    var displayAttribute = attribute as DisplayNameAttribute;

                    if (displayAttribute != null)
                    {
                        string name = displayAttribute.DisplayName;
                        string oneproperty = " " + name + "='{0}' ";
                        string value = "";
                        object objvalue = property.GetValue(model);
                        if (CheckCondition(objvalue))
                        {
                            value = objvalue.ToString().ToLower();
                        stringProperties += String.Format(oneproperty, value);
                        }
                    break;
                    } 
                }
            }

            return stringProperties;
        }

        private static bool CheckCondition(object objvalue)
        {
            if (objvalue == null) return false;

            object boolobj = false;
            if (objvalue.Equals(boolobj)) return false;

            if (string.IsNullOrWhiteSpace(objvalue.ToString())) return false;
            if (objvalue.ToString().ToLower() == "default") return false;

            return true;
        }
    }
}
