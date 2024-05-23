using System.ComponentModel.DataAnnotations;
using WebApiDemo.Model.Validation;

namespace WebApiDemo.Model
{
    public class Shirt
    {
        public int ShirtId {  get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? Color { get; set; }
        [Shirt_EnsureCorrectSizingAttribute]
        public int? Size { get; set; }
        [Shirt_EnsureGenderAttribute]
        [Required]
        public string? Gender { get; set; }
        public double? Price { get; set; }

        public Shirt() { }

        public Shirt(int shirtId, string? brand, string? color, int? size, string? gender, double? price)
        {
            this.ShirtId = shirtId;
            this.Brand = brand;
            this.Color = color;
            this.Size = size;
            this.Gender = gender;
            this.Price = price;
        }
    }
}
