namespace SG.DSL
{
    using System.Configuration;

    public class TestCase
    {
        public static string Environment
        {
            get
            {
                return ConfigurationManager.AppSettings["Environment"];
            }
        }
        public static string UserName
        {
            get
            {
                return ConfigurationManager.AppSettings["UserName"];
            }
        }
        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["Password"];
            }
        }
    }
}