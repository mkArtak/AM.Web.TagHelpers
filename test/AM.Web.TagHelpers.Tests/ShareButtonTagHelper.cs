using AM.Web.TagHelpers.Social;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AM.Web.TagHelpers.Tests
{
    public class ShareButtonTagHelperTests
    {
        [Fact]
        public void Test1()
        {
            var sut = new ShareButtonTagHelper();
            sut.Provider = ShareProvider.Facebook;

            var tagHelperContext = new TagHelperContext(
                            new TagHelperAttributeList(),
                            new Dictionary<object, object>(),
                            Guid.NewGuid().ToString("N"));
            var tagHelperOutput = new TagHelperOutput(
                "shareButton",
                new TagHelperAttributeList(),
                (result, encoder) =>
                {
                    var tagHelperContent = new DefaultTagHelperContent();
                    tagHelperContent.SetHtmlContent(string.Empty);
                    return Task.FromResult<TagHelperContent>(tagHelperContent);
                });
            sut.Process(tagHelperContext, tagHelperOutput);

            string output = tagHelperOutput.Content.GetContent();
            Assert.Equal("<a></p>", output);
        }
    }
}
