using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Filters;
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
        [Shirt_ValidateShirtIdFilter]
        [Route("/shirt/{id}/")]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
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
