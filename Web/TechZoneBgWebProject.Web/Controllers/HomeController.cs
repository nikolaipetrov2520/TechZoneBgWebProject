namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Web.ViewModels;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            if (this.User.IsInRole("TechzoneBgEmployee"))
            {
                return this.RedirectToAction("Create", "Posts");
            }
            else if (this.User.IsInRole("SwypeEmployee"))
            {

            }
            else if (this.User.IsInRole("Moderator"))
            {

            }
            else if (this.User.IsInRole("Administrator"))
            {

            }
            return this.RedirectToAction("Trending", "Posts");
        }

        public IActionResult NotFound404() => this.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
