namespace WebApiDemo.Model.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirtList =
        [
            new() {ShirtId = 1, Brand = "Yeezy", Color = "Orange", Gender="male", Price=129.99, Size=10},
            new() {ShirtId = 2, Brand = "YSL", Color = "Black", Gender="male", Price=59.99, Size=8},
            new() {ShirtId = 3, Brand = "Gucci", Color = "Blue", Gender="female", Price=109.99, Size=4},
            new() {ShirtId = 4, Brand = "Fashinova", Color = "Yellow", Gender="female", Price=29.99, Size=4}
        ];

        public static bool ShirtExists(int id)
        {
            return shirtList.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirtList.FirstOrDefault(x => x.ShirtId == id);
        }

        public static List<Shirt> GetAllShirts() 
        { 
            return shirtList; 
        }

        public static void CreateShirt(Shirt shirt)
        {
            int maxId = shirtList.Max(x => x.ShirtId);
            shirt.ShirtId = maxId;

            shirtList.Add(shirt);
        }


        public static Shirt? GetShirtByProperties(string? brand, string? gender, string? color, int? size)
        {

            return shirtList.FirstOrDefault(x => !string.IsNullOrWhiteSpace(brand) && !string.IsNullOrWhiteSpace(x.Brand) && x.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(gender) && !string.IsNullOrWhiteSpace(x.Gender) && x.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(color) && !string.IsNullOrWhiteSpace(x.Color) && x.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && size.HasValue && x.Size.HasValue && size.Value == x.Size.Value
            );

        }

    }
}
