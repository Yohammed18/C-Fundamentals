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
        public string? Gender { get; set; }
        public double? Price { get; set; }
    }
}
