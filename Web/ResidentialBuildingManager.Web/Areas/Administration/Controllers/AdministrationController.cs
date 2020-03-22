namespace ResidentialBuildingManager.Web.Areas.Administration.Controllers
{
    using ResidentialBuildingManager.Common;
    using ResidentialBuildingManager.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
