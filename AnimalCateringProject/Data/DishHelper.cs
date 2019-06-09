using AnimalCateringProject.Models;

namespace AnimalCateringProject.Data
{
    public static class DishHelper
    {
        public static Dish CopyDish(Dish toCopy)
        {
            return new Dish() { Desc = toCopy.Desc, Id = toCopy.Id, Name = toCopy.Name, IsComplete = toCopy.IsComplete };
        }
    }
}
