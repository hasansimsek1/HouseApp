using HouseApp.Business.Common.Interfaces;

namespace HouseApp.Business.Common.Entities
{
    public class FoodNutrient : EntityBase
    {
        public string FoodId { get; set; }
        public string NutrientId { get; set; }
        public IFoodAmount Amount { get; set; }
    }
}
