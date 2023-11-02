namespace SerilogWeb.v4
{
    using System;
    using System.Linq;

    using Serilog;

    public partial class LoggingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Log.Logger.Information("Constant");
            Log.Logger.Information("Short message {content}", Enumerable.Range(1, 20).ToArray());
            Log.Logger.Information("Long message {content}", Enumerable.Range(1, 1000).ToArray());
            ;
        }
    }
}