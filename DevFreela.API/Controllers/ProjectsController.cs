using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : Controller
    {

        [HttpGet]
        public IActionResult Get(string query)
        {
            //Buscar todos os filtrados
            return Ok();
        }

        // api/projects/2
        [HttpGet("{id}")]
        public IActionResult GetyById(int id)
        {
            //Buscar o projeto

            // return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            //return BadRequest();

            if (createProject.Title.Length > 50)
                return BadRequest();

            //Cadastrar o projeto
            return CreatedAtAction(nameof(GetyById), new { id = createProject.Id }, createProject);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
                return BadRequest();

            // Atualizo o objeto
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //buscar, se não existir, retorna NotFound

            //Remover
            return NoContent();
        }

        // api/projects/2/comments POST
        [HttpPost("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
