using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;
using System;

namespace CreateHtmlHelper.Helpers
{
    public static class ListHelper
    {
        public static HtmlString SimpleCreateList(this IHtmlHelper html, IEnumerable<string> items)
        {
            string result = "<ul>";

            foreach (string item in items)
            {
                result = $"{result}<li>{item}</li>";
            }

            return new HtmlString($"{result}</ul>");
        }

        public static HtmlString CreateListWithTagBuilder(this IHtmlHelper html, IEnumerable<string> items)
        {
            TagBuilder ul = new TagBuilder("ul");

            foreach (string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.InnerHtml.Append(item);
                ul.InnerHtml.AppendHtml(li);
            }

            ul.Attributes.Add("class", "itemsList");
            using var writer = new StringWriter();
            ul.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());
        }
    }
}
