﻿using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controller
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

        // api/projects/query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            //Buscar todos ou filtrar
            return Ok();
        }
        // api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Buscar o projeto
            // return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if(createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            //Cadastrar o projeto

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
            //return BadRequest();
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            //Atualiza o Objeto

            return NoContent();
        }

        //Indetificador via URL
        // api/projects/3 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, retorna NotFound

            //Remover

            return NoContent();
        }
    }
}
