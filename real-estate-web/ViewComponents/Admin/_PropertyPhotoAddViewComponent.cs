using Microsoft.AspNetCore.Mvc;

namespace real_estate_web.ViewComponents.Admin
{
    public class _PropertyPhotoAddViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(){
            return View();
        }
        
    }
    
}