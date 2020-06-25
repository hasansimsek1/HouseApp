using HouseApp.Business.Common.Interfaces;

namespace HouseApp.Business.Common.Entities
{
    public class Nutrient : EntityBase
    {
        public string Name { get; set; }
        public IFoodAmount DailyNeedOfHuman { get; set; }
    }
}
