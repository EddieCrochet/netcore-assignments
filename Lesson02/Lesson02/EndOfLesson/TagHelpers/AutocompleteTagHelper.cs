using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace TagHelpers
{
    [HtmlTargetElement("input")]
    //the HTML elements I want this tag helper to apply to

    class AutocompleteTagHelper : TagHelper
    {
        [HtmlAttributeName("my-autocomplete")]
        public string MyAutoComplete { get; set; }

        /*[HtmlAttributeName("autocomplete")]
        //what attributes I read data out of

        public ModelExpression Auto{ get; set; }*/

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (MyAutoComplete == "false" || MyAutoComplete == "disabled")
                output.Attributes.SetAttribute("autocomplete", "off");
            else
            {
                output.Attributes.SetAttribute("autocomplete", "on");
            }
        }
    }
}
