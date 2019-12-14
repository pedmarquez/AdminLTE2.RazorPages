using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLTE2.Web.TagHelpers
{
    public class BoxBodyTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            var containerTag = new TagBuilder("div");
            containerTag.AddCssClass("box-body");

            var childContent = output.Content.IsModified ? output.Content.GetContent() :
           (await output.GetChildContentAsync()).GetContent();

            containerTag.InnerHtml.AppendHtml(childContent);

            output.Content.SetHtmlContent(containerTag);
        }
    }
}
