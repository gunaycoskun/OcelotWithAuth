using Microsoft.AspNetCore.Mvc;

namespace Ocelot.AuthProvider.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController: ControllerBase
{
   private readonly IConfiguration _configuration;
    public AuthController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    [HttpPost]
    public IActionResult Login(string userName, string password)
    {
        JwtHelper._configuration = _configuration;
        return Ok(userName == "gunay" && password == "12345" ? JwtHelper.CreateAccessToken() : new UnauthorizedResult());
       
    }
    
}