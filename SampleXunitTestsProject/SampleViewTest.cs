using System.IO;
using System.Text.RegularExpressions;
using Xunit;

namespace SampleXunitTestsProject
{
    public class SampleViewTest
    {
        [Fact(DisplayName = "Create Index View @create-index-view")]
        public void CreateIndexViewTest()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "SampleASPNetCoreProject" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Sample" + Path.DirectorySeparatorChar + "Index.cshtml";
            string file;
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            var pattern = @"<\s?h1\s?>.*</\s?h1\s?>";
            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);

            Assert.True(rgx.IsMatch(file), "`Index.cshtml` did not contain a valid opening and closing `h1` tags.");
        }

        [Fact(DisplayName = "Create Details View @create-details-view")]
        public void CreateDetailsViewTest()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "SampleASPNetCoreProject" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Sample" + Path.DirectorySeparatorChar + "Details.cshtml";
            string file;
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            var pattern = @"@model\sstring((\n|.)*)<\s?[hH]1\s?>.*</\s?[hH]1\s?>\s?<\s?[pP]\s?>\s?@Model\s?</\s?[pP]\s?>";
            var rgx = new Regex(pattern);

            Assert.True(rgx.IsMatch(file), "`Details.cshtml` did not contain the expected model declaration, `h1` tag containing the value 'Details', and `p` tag with a value of `@Model`.");
        }

        // THIS TEST IS DESIGNED TO FAIL ON PURPOSE FOR ERROR OUTPUT, To pass set pass true into the Assert!
        [Fact(DisplayName = "Failing Test @failing-test")]
        public void FailingTest()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "SampleASPNetCoreProject" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Sample" + Path.DirectorySeparatorChar + "BreakStuff.cshtml";
            string file;
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(!file.Contains("BreakStuff"), @"`BreakStuff.cshtml` shouldn't say 'BreakStuff' in it, delete 'BreakStuff' from the `Views\Sample\BreakStuff.cshtml` file.");
        }
    }
}
