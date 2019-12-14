using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE2.Web.TagHelpers
{
    public class BoxHeaderDecorator: BoxBase
    {
        private readonly BoxBase box;
        private readonly string title;

        public BoxHeaderDecorator(BoxBase box, string title)
        {
            this.box = box;
            this.title = title;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           
            var  header = new TagBuilder("div");
            header.AddCssClass("box-header");

            var titleTag = new TagBuilder("h3");
            titleTag.InnerHtml.Append(title);

            header.InnerHtml.AppendHtml(titleTag);

           // BoxTag.InnerHtml.AppendHtml(header);
            output.Content.SetHtmlContent(header);
            box.Process(context, output);
        }
    }
}
