using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Model;
using WebApiDemo.Model.Repositories;

namespace WebApiDemo.Controller
{
    

    [ApiController]
    public class ShirtsController: ControllerBase
    {

        [HttpGet]
        [Route("/shirts")]
        public IActionResult GetShirts()
        {
            return Ok(ShirtRepository.GetAllShirts());
        }

        [HttpGet]
        [Route("/shirt/{id}/")]
        public IActionResult GetShirtById(int id)
        {
            if(id <= 0)
            {
                return BadRequest(id.ToString());
            }

            try
            {
                var shirt = ShirtRepository.GetShirtById(id);
                if (shirt == null)
                {
                    return NotFound();
                }
                
                return Ok(shirt);
            } catch (InvalidOperationException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while processing your request.\n");
            }
             
        }

        [HttpPut]
        [Route("/update/{id}")]
        public string UpdateShirtById(int id)
        {
            return $"Updating shirt with ID: {id}";
        }

        [HttpDelete]
        [Route("/delete/{id}")]
        public void DeleteShirtById(int id)
        {
            Console.WriteLine($"Deleting shirt with ID: {id}");
        }

        [HttpPost]
        [Route("/shirt")]
        public IActionResult CreateShirt([FromBody]Shirt shirt)
        {
            ShirtRepository.AddShirt(shirt);
            return Ok("Shirt has been created.");
        }
    }
}
