namespace SerilogWeb.v4
{
    using System;
    using System.Web;
    using System.Web.Routing;

    using SerilogWeb.v4.Logging;

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Logs.StartLogging();
        }
    }
}