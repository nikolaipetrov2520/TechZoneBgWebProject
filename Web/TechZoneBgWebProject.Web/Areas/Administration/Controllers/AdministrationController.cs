namespace TechZoneBgWebProject.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Web.Controllers;

    [Authorize(Roles = GlobalConstants.Admin.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
