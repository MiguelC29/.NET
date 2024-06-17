using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ICBF.Pages.TipoDocumento
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }


        public class TipoDocInfo
        {
            public string idTipoDoc { get; set; }
            public string tipo { get; set; }
        }
    }
}
