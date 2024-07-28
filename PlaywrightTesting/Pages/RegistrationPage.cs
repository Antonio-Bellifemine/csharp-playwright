using Microsoft.Playwright;

namespace PlaywrightTesting.Pages
{
    public class RegistrationPage
    {
        private IPage _page;
        public RegistrationPage(IPage page) => _page = page;
        private ILocator _userNameInput => _page.GetByPlaceholder("Username");
        private ILocator _emailInput => _page.GetByPlaceholder("Email");
        private ILocator _passwordInput => _page.GetByPlaceholder("Password");
        private ILocator _alreadyHaveAnAccountBtn => _page.GetByText("Have an account?");
        private ILocator _signUpBtn => _page.Locator("text=Sign up");

        public async Task GoToSignUpPage() => await _page.GotoAsync("https://demo.realworld.io/#/register");
        public async Task ClickSignUpBtn() => await _signUpBtn.ClickAsync();
        public async Task SignUpUser(string userName, string email, string password)
        {
            await _userNameInput.FillAsync(userName);
            await _emailInput.FillAsync(email);
            await _passwordInput.FillAsync(password);
            await ClickSignUpBtn();
        }
    }
}