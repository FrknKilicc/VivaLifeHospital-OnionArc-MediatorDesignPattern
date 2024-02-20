using Microsoft.AspNetCore.Mvc;

namespace VivaLifeHospital.WebUI.ViewComponents.AppointentViewComponents
{
    public class _GetAppointmentInputsViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
