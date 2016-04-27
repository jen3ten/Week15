using System.Web;
using System.Web.Mvc;

namespace Week15_GameScoreMigrations_04192016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
