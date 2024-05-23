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

        public static void AddShirt(Shirt shirt)
        {
            shirtList.Add(shirt);
        }
    }
}
