using System.Web;
using System.Web.Mvc;

namespace BigSchool_2080600040_PhamHoangNam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
