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
            if (shirt == null) return BadRequest();

            var existingshirt = ShirtRepository.GetShirtByProperties(shirt.Brand, shirt.Gender, shirt.Color, shirt.Size);

            if (existingshirt != null) return BadRequest(existingshirt);

            ShirtRepository.CreateShirt(shirt);
            return CreatedAtAction(nameof(GetShirtById), new { id = shirt.ShirtId}, shirt);
        }
    }
}


