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
    public class HousesController : ControllerBase
    {
        [HttpGet]
        [Route("GetHouse")]

        public async Task<List<House>> GetHouse([FromServices] DataContext context)
        {
            return context.tblHouse.ToList();
        }

        [HttpPost]
        [Route("AddHouse")]
        public async Task<ActionResult<House>> AddHouse([FromServices] DataContext context, [FromBody] House model)
        {
            if (ModelState.IsValid)
            {
                context.tblHouse.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("RemoveHouse/{id}")]
        public async Task RemoveHouse([FromServices] DataContext context, [FromRoute] int Id)
        {
            try
            {
                var house = context.tblHouse.FirstOrDefault(e => e.Id == Id);
                context.tblHouse.Remove(house);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }

        [HttpPut]
        [Route("UpdateHouse/{id}")]
        public async Task UpdateHouse([FromServices] DataContext context, [FromRoute] int Id, [FromBody] House model)
        {
            try
            {
                var house = context.tblHouse.FirstOrDefault(e => e.Id == Id);
                house.Type = model.Type;

                context.tblHouse.Update(house);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }
    }
}
