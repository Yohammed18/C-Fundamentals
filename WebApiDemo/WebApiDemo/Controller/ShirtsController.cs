using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controller
{
    [ApiController]
    public class ShirtsController: ControllerBase
    {
        [HttpGet]
        [Route("/shirts")]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        [HttpGet]
        [Route("/shirt/{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading shirt with ID: {id}";
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
        public string CreateShirt()
        {
            return "Creating a shirt.";
        }
    }
}
