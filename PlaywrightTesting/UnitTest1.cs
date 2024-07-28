using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PlaywrightTesting.Pages;
using PlaywrightTesting.Pages;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExampleTest : PageTest

{
    private RegistrationPage registrationPage;
    [SetUp]
    public async Task Setup()
    {
        registrationPage = new RegistrationPage(page);


    }

    [Test]
    public async Task typeUsername()
    {
        var usernameInput = Page.GetByPlaceholder("Username");
        // Expect a title "to contain" a substring.
        await usernameInput.FillAsync("testing");
    }

}