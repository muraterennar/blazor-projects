using LocalStorage.Shared;
using Microsoft.AspNetCore.Mvc;

namespace LocalStorage.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    List<User> users = new List<User>
    {
        new User { Id = 1, Ad = "birol", Soyad = "tıkıl" },
        new User { Id = 2, Ad = "ilkay", Soyad = "düzyol" },
        new User { Id = 3, Ad = "ufuk", Soyad = "naldöken" }
    };


    [HttpGet("{id}")]
    public ActionResult<int> Get(int id)
    {
        if(id < 0 || id >= users.Count)
        {
            return NotFound();
        }

        var response = users.FirstOrDefault(u => u.Id == id);

        return Ok(response);
    }

    [HttpGet("Login/{ad}")]
    public ActionResult<string> Get(string ad)
    {
        var response = users.FirstOrDefault(u => u.Ad == ad.ToLower());

        if(response == null)
        {
            return NotFound();
        }

        return Ok(response);
    }

}
