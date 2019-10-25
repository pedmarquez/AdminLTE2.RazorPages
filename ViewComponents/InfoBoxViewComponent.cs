using AdminLTE2.Web.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdminLTE2.Web.ViewComponents
{
    public class InfoBoxViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string icon, string backgroundBox, string backgroundIcon, string text, string number, int? progressValue, string progressDescription)
        {
            return await Task.Run(() => View(new InfoBoxModel { Icon = icon, BackgroundBox = backgroundBox, BackgroundIcon = backgroundIcon, Text = text, Number = number, ProgressValue = progressValue, ProgressDescription = progressDescription }));
        }
    }
}
