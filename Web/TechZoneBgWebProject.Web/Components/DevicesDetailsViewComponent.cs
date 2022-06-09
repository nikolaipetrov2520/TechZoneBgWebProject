namespace TechZoneBgWebProject.Web.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    [ViewComponent(Name = "DevicesDetails")]
    public class DevicesDetailsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return this.View();
        }
    }
}
