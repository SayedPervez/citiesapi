using citiesapi.Data;
using citiesapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace citiesapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        //[HttpPost("User")]
        //public ActionResult<User> CreateUser(User userdata)
        //{
        //    if (userdata == null)
        //    {
        //        return BadRequest("No User data");
        //    }

        //    if (string.IsNullOrWhiteSpace(userdata.UserName))
        //    {
        //        return BadRequest("User Name cannot be empty");
        //    }

        //    var userId = DataSource.usersData.Any() ? DataSource.usersData.Max(e => e.UserId) + 1 : 1;
        //    userdata.UserId = userId;

        //    var checkNameExist = DataSource.usersData.Any(e => e.UserName == userdata.UserName);

        //    if (checkNameExist)
        //    {
        //        return Conflict("User already exist");
        //    }

        //    DataSource.usersData.Add(userdata);

        //    return CreatedAtAction(
        //            nameof(CreateUser), new { id = userdata.UserId }, userdata);
        //}

        //[HttpPut("users/{userId}")]
        //public IActionResult UpdateUser([FromBody]User user, [FromRoute] int userId)
        //{
        //    if (user == null)
        //    {
        //        return BadRequest("No User data");
        //    }

        //    if (string.IsNullOrWhiteSpace(user.UserName))
        //    {
        //        return BadRequest("User Name cannot be empty");
        //    }

        //    if (user.UserId != 0 && user.UserId != userId)
        //        return BadRequest("User ID mismatch");

        //    var userRecord = DataSource.usersData.FirstOrDefault(e => e.UserId == userId);
        //    if (userRecord == null)
        //        return NotFound("User not found");

        //    userRecord.UserName = user.UserName;
        //    userRecord.Email = user.Email;
        //    userRecord.IsActive = user.IsActive;

        //    return NoContent();
        //}

        //[HttpPatch("Users/{userId}")]
        //public IActionResult UpdateUserInfo([FromRoute] int userId,[FromBody] User user)
        //{
        //    if (user == null)
        //    {
        //        return BadRequest("No User data");
        //    }

        //    if (user.UserId != 0 && user.UserId != userId)
        //        return BadRequest("User ID mismatch");

        //    var userRecord = DataSource.usersData.FirstOrDefault(e => e.UserId == userId);

        //    if (userRecord == null)
        //        return NotFound("User not found");

        //    if(user.IsActive)
        //        userRecord.IsActive = user.IsActive;
        //    return NoContent();
        //}

        //[HttpDelete("users/{userId}")]
        //public IActionResult DeleteUser([FromRoute] int userId)
        //{
        //    var userRecord = DataSource.usersData.FirstOrDefault(e => e.UserId == userId);

        //    if (userRecord == null)
        //        return NotFound("User not found");

        //    DataSource.usersData.Remove(userRecord);

        //    return NoContent();
        //}

        [HttpPost("[action]")]
        public IActionResult CreateUser(OrderRequest request)
        {
            return Ok();
        }
    }
}
