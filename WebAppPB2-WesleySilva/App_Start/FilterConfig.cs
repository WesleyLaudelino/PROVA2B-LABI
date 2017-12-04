using System.Web;
using System.Web.Mvc;

namespace WebAppPB2_WesleySilva
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
