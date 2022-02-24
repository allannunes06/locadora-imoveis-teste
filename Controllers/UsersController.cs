
using homeLocation.Data;
using homeLocation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeLocation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("GetUser")]

        public async Task<List<User>> GetUsers([FromServices] DataContext context)
        {
            return context.tblUser.ToList();
        }

        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult<User>> AddUsers([FromServices] DataContext context, [FromBody] User modelUsers)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.tblUser.Add(modelUsers);
                    await context.SaveChangesAsync();
                    return modelUsers;
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpDelete]
        [Route("RemoveUser/{Id}")]
        public async Task RemoveUsers([FromServices] DataContext context, [FromRoute] int Id)
        {
            try
            {
                var user = context.tblUser.FirstOrDefault(e => e.Id == Id);
                context.tblUser.Remove(user);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }
        [HttpPut]
        [Route("UpdateUser/{Id}")]
        public async Task UpdateUsers([FromServices] DataContext context, [FromRoute] int Id, [FromBody] User modelUsers)
        {
            try
            {
                var user = context.tblUser.FirstOrDefault(e => e.Id == Id);
                user.Name = modelUsers.Name;


                context.tblUser.Update(user);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }

        }
    }
}
