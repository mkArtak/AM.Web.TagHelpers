using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace AM.Web.TagHelpers.Social
{
    public class ShareButtonTagHelper : TagHelper
    {
        private ShareProviderLingGenerator linkGenerator = new ShareProviderLingGenerator();
        public ShareProvider Provider { get; set; }

        public string UrlToShare { get; set; }

        public string Content { get; set; } = "asdf";

        public ShareButtonTagHelper()
        {
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", string.Format(linkGenerator.GetUrlForShareProvider(this.Provider), this.UrlToShare));
            output.Attributes.SetAttribute("target", "_blank");
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent(this.Content);
        }
    }
}
