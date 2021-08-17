﻿namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Web.ViewModels;

    public class HomeController : BaseController
    {
        public IActionResult Index() => this.RedirectToAction("Trending", "Posts");

        public IActionResult NotFound404() => this.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
