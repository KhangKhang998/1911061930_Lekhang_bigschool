using System.Web;
using System.Web.Mvc;

namespace _1911061930_Lekhang_bigschool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
