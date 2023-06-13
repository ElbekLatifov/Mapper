using M.Exstinsions;
using M.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public IActionResult GetUser()
    {
        var user  = new User()
        {
            FirstName = "elbek",
            LasttName = "latifov",
            Password  = "123asd",
            Email = "elbek@.com",
            Age  = 22,
            Phone = "981541544",
            UserName  = "elbek_127",
            PhotoUrl  = "cdscs_dcsdcds_sdsS_Dsdcs.jpg",
            IsAdmin = false
        };
        var dto = user.MapToDto();
        return Ok();
    }
}
