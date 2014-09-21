namespace SG.DSL
{
    using FluentAutomation;

    using SG.DSL.Elements;

    public class SalesLoginPage : PageObject<SalesLoginPage>
    {
        public SalesLoginPage(FluentTest test)
            : base(test)
        {
            this.Url = string.Format("{0}/{1}", TestCase.Environment, "/sales/login");
            this.At = () => { };
            this.I.Expect.Exists(SalesLoginElements.UserNameInput);
            this.I.Expect.Exists(SalesLoginElements.PasswordInput);
        }

        public SalesHomePage Login(string userName, string password)
        {
            this.I.Enter(userName).In(SalesLoginElements.UserNameInput);
            this.I.Enter(password).In(SalesLoginElements.PasswordInput);
            this.I.Click(SalesLoginElements.LoginButton);
            return this.Switch<SalesHomePage>();
        }
    }
}