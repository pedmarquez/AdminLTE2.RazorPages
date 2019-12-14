using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace AdminLTE2.Web.TagHelpers
{
    [HtmlTargetElement("box")]
    public class BoxTagHelper: TagHelper
    {
        public enum Variant
        {
            Default,
            Primary,
            Info,
            Success,
            Warning,
            Danger
        }
        public bool IsSolid { get; set; }

        public Variant? BoxVariant { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";

            var containerTag = new TagBuilder("div");
            containerTag.AddCssClass("box");

            if (IsSolid)
            {
                containerTag.AddCssClass("box-solid");
            }

            if (BoxVariant.HasValue)
            {
               
                containerTag.AddCssClass($"box-{BoxVariant.Value.ToString().ToLower()}");
            }

            if (output.Attributes.TryGetAttribute("class", out var @class))
                containerTag.AddCssClass(@class.Value.ToString());

           

            var childContent = output.Content.IsModified ? output.Content.GetContent() :
            (await output.GetChildContentAsync()).GetContent();

            
         

            containerTag.InnerHtml.AppendHtml(childContent);

            

            output.Content.SetHtmlContent(containerTag);
        }
    }
}
