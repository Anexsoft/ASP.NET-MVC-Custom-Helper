using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelper.Helpers
{
    public static class HtmlExtensions
    {
        #region Bootstrap
        public static MvcHtmlString BootstrapTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            var metada = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

            var htmlInput = "<input id=\"{0}\" type=\"text\" class=\"form-control\" name=\"{0}\" value=\"{1}\" />";
            htmlInput = string.Format(htmlInput, metada.PropertyName, metada.SimpleDisplayText);

            return MvcHtmlString.Create(htmlInput);
        }

        public static MvcHtmlString BootstrapTextBox<TModel>(this HtmlHelper<TModel> htmlHelper, string name, string value)
        {
            var htmlInput = "<input id=\"{0}\" type=\"text\" class=\"form-control\" name=\"{0}\" value=\"{1}\" />";
            htmlInput = string.Format(htmlInput, name, value);

            return MvcHtmlString.Create(htmlInput);
        }

        public static MvcHtmlString Chosen<TModel>(this HtmlHelper<TModel> htmlHelper, string name, Dictionary<string, string> data, string placeholder = null, string selectedValue = null)
        {
            var htmlInput = "<select id=\"{0}\" class=\"form-control\" name=\"{0}\" placeholder=\"{1}\">[options]</select>";
            htmlInput = string.Format(htmlInput, name, placeholder);

            var options = new StringBuilder();

            foreach (var d in data)
            {
                var selected = "";
                if (d.Key == selectedValue)
                    selected = "selected";

                options.Append(string.Format("<option value=\"{0}\" {1}>{2}</option>", d.Key, selected, d.Value));
            }

            htmlInput = htmlInput.Replace("[options]", options.ToString());

            var scriptHtml = "<script>$(document).ready(function(){ $('#" + name + "').chosen(); })</script>";

            return MvcHtmlString.Create(htmlInput + scriptHtml);
        }
        #endregion


    }
}