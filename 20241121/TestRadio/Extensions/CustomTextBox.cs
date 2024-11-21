using System.Web.Mvc;
using System.Web.Routing;

namespace TestRadio.Extensions
{
    public static class CustomTextBox
    {
        public static MvcHtmlString MyTextBox(this HtmlHelper helper, string name, string text, object htmlAttributes)
        {
            TagBuilder textBox = new TagBuilder("input");
            textBox.Attributes.Add("type", text);
            textBox.Attributes.Add("name", name);
            textBox.Attributes.Add("id", name);

            if (!string.IsNullOrEmpty(text))
            {
                textBox.Attributes.Add("value", text);
            }

            textBox.Attributes.Add("onblur", "javascript:if(this.value==''){this.style.backgroundColor = 'yellow';this.focus();};");
            textBox.Attributes.Add("onkeyup", "javascript:if(this.value!=''){this.style.backgroundColor = 'white';}else{this.style.backgroundColor = 'yellow';};");

            textBox.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return MvcHtmlString.Create(textBox.ToString(TagRenderMode.Normal));
        }

        public static MvcHtmlString MyTextBox(this HtmlHelper helper, string prm, int id, string text)
        {
            return MyTextBox(helper, ("txt" + prm + id.ToString()), text, null);
        }
        public static MvcHtmlString MyTextBox(this HtmlHelper htmlHelper, string name)
        {
            return MyTextBox(htmlHelper, name, null, null);
        }
    }
}