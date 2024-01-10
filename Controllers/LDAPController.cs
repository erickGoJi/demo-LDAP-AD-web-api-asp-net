using System.Runtime.Versioning;
using demo_LDAP_AD_web_api_asp_net.Models;
using demo_LDAP_AD_web_api_asp_net.Services;
using Microsoft.AspNetCore.Mvc;

namespace demo_LDAP_AD_web_api_asp_net.Controllers;
[SupportedOSPlatform("windows")]
[ApiController]
[Route("[controller]")]
public class LDAPController : ControllerBase
{
    private readonly ILogger<LDAPController> _logger;
    private readonly LDAPService _service;

    public LDAPController(ILogger<LDAPController> logger, LDAPService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet("GetCurrentDomainPath")]
    public IActionResult GetCurrentDomainPath()
    {
        var result = _service.GetCurrentDomainPath();

        return Ok(result);
    }

    [HttpGet("GetAllUsers")]
    public IActionResult GetAllUsers()
    {
        var result = _service.GetAllUsers();

        return Ok(result);
    }

    [HttpGet("GetAdditionalUserInfo")]
    public IActionResult GetAdditionalUserInfo()
    {
        var result = _service.GetAdditionalUserInfo();

        return Ok(result);
    }

    [HttpGet("SearchForUsers")]
    public IActionResult SearchForUsers([FromQuery] string userName)
    {
        var result = _service.SearchForUsers(userName);

        return Ok(result);
    }

    [HttpGet("GetAUser")]
    public IActionResult GetAUser([FromQuery] string userName)
    {
        var result = _service.GetAUser(userName);

        return Ok(result);
    }

    [HttpPost("AuthenticateUser")]
    public IActionResult GetAUser([FromBody] LDAPAuthRequest userRequest)
    {
        try
        {
            var result = _service.AuthenticateUser(userRequest);

            return Ok(result);
        }
        catch
        {
            return Unauthorized(new { Message = "Usuario y/o contraseña invalidos." });
        }
    }
}