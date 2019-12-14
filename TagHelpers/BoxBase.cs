using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AdminLTE2.Web.TagHelpers
{
    public class BoxBase : TagHelper
    {
        public TagBuilder BoxTag = new TagBuilder("div");
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";


            BoxTag.AddCssClass("box");
            BoxTag.InnerHtml.AppendHtml(output);

            output.Content.SetHtmlContent(BoxTag);
        }
    }
}
