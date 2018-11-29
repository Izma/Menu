using System.Configuration;

namespace Menu.Util
{
    public static class Connection
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }
        }

    }
}
