namespace TechZoneBgWebProject.Web.Areas.Administration.Controllers
{
    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
