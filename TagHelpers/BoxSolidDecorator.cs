using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE2.Web.TagHelpers
{
    public class BoxSolidDecorator : BoxBase
    {
        private readonly BoxBase box;

        public BoxSolidDecorator(BoxBase box)
        {
            this.box = box;

        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           
            //BoxTag.AddCssClass("box-solid");
            //output.Content.SetHtmlContent(header);
            box.Process(context, output);
        }

    }
}
