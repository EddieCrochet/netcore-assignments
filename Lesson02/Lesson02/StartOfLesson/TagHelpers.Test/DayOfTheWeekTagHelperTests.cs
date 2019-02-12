using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using TagHelpers.Tests.Intrastructure;
using Xunit;

namespace TagHelpers.Test
{
    public class DayOfTheWeekTagHelperTests : BaseTagHelperTest 
    {
        [Fact]
        public void TagHelper_ShouldDisplayMMddyyyyForDates7DaysOrFurtherInTheFuture()
        {
            //Assemble
            var value = DateTime.Now.AddDays(8);
            var tagHelper = new DayOfTheWeekTagHelper();
            tagHelper.For = GetModelExpression(value);

            TagHelperAttributeList attributes = new TagHelperAttributeList
            {
                new TagHelperAttribute("asp-for", value),
                new TagHelperAttribute("day-of-week")
            };
            TagHelperContext content = null;
            TagHelperOutput output = new TagHelperOutput("span", attributes, BlankContent);

            //Act
            tagHelper.Process(content, output);

            //Assert
            Assert.Equal(value.ToString("MM/dd/yyy"), output.Content.GetContent());
        }
    }
}
