using homeLocation.Data;
using homeLocation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeLocation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        
        [HttpGet]
        [Route("GetLocations")]
        public async Task<List<Location>> GetLocation([FromServices] DataContext context)
        {
            return context.tblLocation.ToList();
        }

        [HttpPost]
        [Route("AddLocations")]
        public async Task<ActionResult<Location>> AddLocation([FromServices] DataContext context, [FromBody] Location model)
        {
            DateTime dataDevolution;

            if (ModelState.IsValid)
            {
                context.tblLocation.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("RemoveLocations/{id}")]
        public async Task RemoveLocation([FromServices] DataContext context, [FromRoute] int Id)
        {
            try
            {
                var location = context.tblLocation.FirstOrDefault(e => e.Id == Id);
                context.tblLocation.Remove(location);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }


        [HttpPut]
        [Route("UpdateLocations/{id}")]
        public async Task UpdateLocation([FromServices] DataContext context, [FromRoute] int Id, [FromBody] Location model)
        {
            try
            {
                var location = context.tblLocation.FirstOrDefault(e => e.Id == Id);
                location.IdUser = model.IdUser;
                location.IdHouse = model.IdHouse;
                location.DataLocation = model.DataLocation;

                context.tblLocation.Update(location);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }
    }
}

