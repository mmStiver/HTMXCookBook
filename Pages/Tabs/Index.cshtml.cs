using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HtmxCookbook.Pages.Tabs
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
        public PartialViewResult OnGetTab1()
        {
            return Partial("_tab1");
        }
        public PartialViewResult OnGetTab2()
        {
            return Partial("_tab2");
        }
        public PartialViewResult OnGetTab3()
        {
            return Partial("_tab3");
        }
    }
}
