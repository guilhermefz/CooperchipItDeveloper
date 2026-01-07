using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace CooperchipItDeveloper.Mvc.Extensions.TagHelpers
{
    [HtmlTargetElement("q-select")]
    public class QSelectTagHelper : TagHelper
    {
        private readonly IHtmlGenerator _htmlGenerator;

        public QSelectTagHelper(IHtmlGenerator htmlGenerator)
        {
            _htmlGenerator = htmlGenerator;
        }

        [HtmlAttributeName("for")]
        public ModelExpression For {  get; set; }

        [HtmlAttributeName("Items")]
        public IEnumerable<SelectListItem> Items { get; set; }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", "mb-3");

            var label = _htmlGenerator.GenerateLabel(
                ViewContext,
                For.ModelExplorer,
                For.Name,
                labelText: null,
                htmlAttributes: new { @class = "control-label" }
            );

            var defaultOptionText = $"-- Selecione {For.Metadata.DisplayName ?? For.Name} --";
            var modifiedItems = new List<SelectListItem>();

            modifiedItems.Add(new SelectListItem { Text = defaultOptionText, Value = "" });

            if (Items != null)
            {
                modifiedItems.AddRange(Items);
            }

            var select = _htmlGenerator.GenerateSelect(
                ViewContext,
                For.ModelExplorer,
                optionLabel: null,
                expression: For.Name,
                selectList: modifiedItems,
                currentValues: null,
                allowMultiple: false,
                htmlAttributes: new { @class = "form-select" }
            );

            var span = _htmlGenerator.GenerateValidationMessage(
                ViewContext,
                For.ModelExplorer,
                For.Name,
                message: null,
                tag: "span",
                htmlAttributes: new { @class = "text-danger" }
            );

            output.Content.AppendHtml(label);
            output.Content.AppendHtml(select);
            output.Content.AppendHtml(span);
        }
    }
}
