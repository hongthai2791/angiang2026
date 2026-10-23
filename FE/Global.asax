<%@ Application Inherits="DotNetNuke.Web.Common.Internal.DotNetNukeHttpApplication" Language="C#" %>
<script RunAt="server">
    void Application_Start(object sender, EventArgs e)
    {
    }
    void Application_End(object sender, EventArgs e)
    {
    }

    void Application_Error(object sender, EventArgs e)
    {
    }
    void Session_Start(object sender, EventArgs e)
    {
        Application.Lock();
        if (Application["gOnline"] == null)
            Application["gOnline"] = 1;
        else
            Application["gOnline"] = Convert.ToInt32(Application["gOnline"]) + 1;
        Application["gTotal"] = Convert.ToInt32(Application["gTotal"]) + 1;
        DotNetNuke.WORK.WorkController objctl = new DotNetNuke.WORK.WorkController();
        DotNetNuke.WORK.CMS_EventLogInfo eInfo = new DotNetNuke.WORK.CMS_EventLogInfo();
        eInfo.LogDay = DateTime.Now.Day;
        eInfo.LogMonth = DateTime.Now.Month;
        eInfo.LogView = 1;
        eInfo.LogYear = DateTime.Now.Year;
        eInfo.PortalID = 0;
        objctl.CMS_EventLog_Add("0", eInfo);
        Application.UnLock();
    }

    void Session_End(object sender, EventArgs e)
    {
        Application.Lock();
        int i = Convert.ToInt32(Application["gOnline"]);
        if (i > 1)
            Application["gOnline"] = Convert.ToInt32(Application["gOnline"]) - 1;
        Application.UnLock();
    }

</script>
