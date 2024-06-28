using Applicaiton.Abstract;
using Microsoft.AspNetCore.Mvc;
using TestAppStateManagment.Shared;

namespace TestAppStateManagment.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("getall")]
    public IActionResult GetAll([FromRoute] int startPage = 0, int pageSize = 10)
    {
        var users = _userService.GetAll(startPage, pageSize);
        return Ok(users);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] User user)
    {
        var users = _userService.Add(user);
        return Ok(users);
    }

    [HttpPost("update")]
    public IActionResult Update([FromBody] User user)
    {
        var users = _userService.Update(user);
        return Ok(users);
    }
}
