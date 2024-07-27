using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExampleTest : PageTest
{
    [Test]
    public async Task typeUsername()
    {

        await Page.GotoAsync("https://demo.realworld.io/#/register");

        // Expect a title "to contain" a substring.
        await Page.GetByPlaceholder("Username").FillAsync("testing");
    }

}