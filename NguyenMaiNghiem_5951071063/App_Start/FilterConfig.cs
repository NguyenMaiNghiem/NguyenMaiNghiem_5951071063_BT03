using System.Web;
using System.Web.Mvc;

namespace NguyenMaiNghiem_5951071063
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
