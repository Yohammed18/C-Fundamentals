using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Model;

namespace WebApiDemo.Controller
{
    

    [ApiController]
    public class ShirtsController: ControllerBase
    {
        private List<Shirt> shirtList = new List<Shirt>()
        {
            new Shirt{ShirtId = 1, Brand = "Yeezy", Color = "Orange", Gender="male", Price=129.99, Size=10},
            new Shirt{ShirtId = 2, Brand = "YSL", Color = "Black", Gender="male", Price=59.99, Size=8},
            new Shirt{ShirtId = 3, Brand = "Gucci", Color = "Blue", Gender="female", Price=109.99, Size=4},
            new Shirt{ShirtId = 4, Brand = "Fashinova", Color = "Yellow", Gender="female", Price=29.99, Size=4}
        };

        [HttpGet]
        [Route("/shirts")]
        public IActionResult GetShirts()
        {
            return Ok(shirtList);
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
                var shirt = shirtList.First(x => x.ShirtId == id);
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
            
            return Ok("Shirt has been created.");
        }
    }
}
