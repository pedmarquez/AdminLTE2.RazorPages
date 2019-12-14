using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLTE2.Web.TagHelpers
{
    public class BoxHeaderTagHelper : TagHelper
    {
        public bool WithBorder { get; set; }
        public string Title { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            var containerTag = new TagBuilder("div");
            containerTag.AddCssClass("box-header");
            if (WithBorder)
            {
                containerTag.AddCssClass("with-border");
            }

            if (!string.IsNullOrWhiteSpace(Title))
            {
                var title = new TagBuilder("h3");
                title.AddCssClass("box-title");
                title.InnerHtml.Append(Title);
                containerTag.InnerHtml.AppendHtml(title);
            }

            var childContent = output.Content.IsModified ? output.Content.GetContent() :
           (await output.GetChildContentAsync()).GetContent();

            containerTag.InnerHtml.AppendHtml(childContent);

            output.Content.SetHtmlContent(containerTag);
        }
    }
}
