using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE2.Web.TagHelpers
{
    public class BoxComponent : TagHelper
    {
        public bool IsSolid { get; set; }
        public string Title { get; set; }
        public BoxComponent()
        {

        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            var box = new BoxBase();
            if (IsSolid)
            {
                box = new BoxSolidDecorator(box);
            }

            if (!string.IsNullOrWhiteSpace(Title))
            {
                box = new BoxHeaderDecorator(box, Title);
            }


            box.Process(context, output);
            // output.Content.SetHtmlContent(solid);
        }
    }
}
