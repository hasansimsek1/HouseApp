using HouseApp.Business.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Business.Common.Entities
{
    public class FoodCategory : EntityBase
    {
        public string Name { get; set; }
        public MesurementCategory MesurementCategory { get; set; }

    }
}
