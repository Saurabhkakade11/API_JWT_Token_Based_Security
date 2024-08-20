using System.Web;
using System.Web.Mvc;

namespace API_JWT_Token_Based_Security
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
