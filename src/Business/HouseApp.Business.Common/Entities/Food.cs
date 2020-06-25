using HouseApp.Business.Common.Interfaces;
using System.Collections.Generic;

namespace HouseApp.Business.Common.Entities
{
    public class Food : EntityBase
    {
        public string Name { get; set; }

        public FoodCategory Category { get; set; }

        public IFoodAmount Amount { get; set; }

        public IEnumerable<FoodNutrient> Nutrients { get; set; }
    }
}