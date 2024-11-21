using System.Web.Mvc;
using System.Web.Routing;

namespace TestRadio.Extensions
{
    public static class CustomRadioButton
    {
        public static MvcHtmlString MyRadioButton(this HtmlHelper helper, string name)
        {
            return MyRadioButton(helper, name, true, true, null);
        }
        public static MvcHtmlString MyRadioButton(this HtmlHelper helper, int id, bool value, bool isChecked)
        {
            return MyRadioButton(helper, ("rd" + id.ToString()), value, isChecked, null);
        }

        public static MvcHtmlString MyRadioButton(this HtmlHelper helper, string name, bool value, bool isChecked, object htmlAttributes)
        {
            TagBuilder radioButton = new TagBuilder("input");
            radioButton.Attributes.Add("type", "radio");
            radioButton.Attributes.Add("name", name);
            radioButton.Attributes.Add("id", name);
            if (isChecked)
            {
                radioButton.Attributes.Add("checked", "checked");
            }

            radioButton.Attributes.Add("value", value.ToString());
            radioButton.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return MvcHtmlString.Create(radioButton.ToString(TagRenderMode.Normal));
        }
    }

}