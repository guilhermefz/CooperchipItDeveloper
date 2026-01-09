using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CooperchipItDeveloper.Mvc.Extensions.TagHelpers
{
    [HtmlTargetElement("q-field")]
    public class QFieldTagHelper : TagHelper
    {
        private readonly IHtmlGenerator _htmlGenerator;

        public QFieldTagHelper(IHtmlGenerator htmlGenerator)
        {
            _htmlGenerator = htmlGenerator;
        }

        [HtmlAttributeName("for")]
        public ModelExpression For {  get; set; }

        [HtmlAttributeName("col")]
        public int Col { get; set; } = 0;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            var classNames = "mb-3";

            if (Col > 0)
                classNames += $" col-md-{Col}";
            
            output.Attributes.Add("class", classNames);

            var label = _htmlGenerator.GenerateLabel(
                ViewContext,
                For.ModelExplorer,
                For.Name,
                labelText: null,
                htmlAttributes: new { @class = "control-label" }
            );

            var input = _htmlGenerator.GenerateTextBox(
                ViewContext,
                For.ModelExplorer,
                For.Name,
                value: For.Model,
                format: null,
                htmlAttributes: new
                {
                    @class = "form-control",
                    placeholder = $"Digite {For.Metadata.DisplayName ?? For.Name}"
                });

            var span = _htmlGenerator.GenerateValidationMessage(
                ViewContext,
                For.ModelExplorer,
                For.Name,
                message: null,
                tag: "span",
                htmlAttributes: new { @class = "text-danger" }
            );

            output.Content.AppendHtml(label);
            output.Content.AppendHtml(input);
            output.Content.AppendHtml(span);
        }
    }
}
