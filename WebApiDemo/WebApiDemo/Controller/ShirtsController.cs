using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Model;

namespace WebApiDemo.Controller
{
    [ApiController]
    public class ShirtsController: ControllerBase
    {


        [HttpGet]
        [Route("/shirts")]
        public string GetShirts()
        {
            return "Get all the shirts";
        }

        [HttpGet]
        [Route("/shirt/{id}/")]
        public string GetShirtById(int id, [FromHeader(Name = "Color")] string color)
        {
            return $"Reading shirt with ID: {id}\nColor: {color}";
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
        public string CreateShirt([FromBody]Shirt shirt)
        {
            
            return "Shirt has been created.";
        }
    }
}
