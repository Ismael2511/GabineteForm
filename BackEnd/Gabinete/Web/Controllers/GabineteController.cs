using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using RepositoryModel.response;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GabineteController : ControllerBase
    {
        private readonly IGabineteService _persona;
        public GabineteController(IGabineteService persona)
        {
            _persona = persona;
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetByIdPersona([FromRoute] int id)
        {
            var model = _persona.GetById(id);
            return Ok(model);
        }

        [HttpPost("[action]")]
        public IActionResult savePersona([FromBody] GabineteViewModel model)
        {
            DataResult data = new DataResult();

            if (ModelState.IsValid)
            {
                data = _persona.Insert(model);
            }
            return Ok(data);

        }
    }
}
