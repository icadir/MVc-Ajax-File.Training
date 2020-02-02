using System.Web;
using System.Web.Mvc;

namespace MVc_Ajax_File.Training
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
