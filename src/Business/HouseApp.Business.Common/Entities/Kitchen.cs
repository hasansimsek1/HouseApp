using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Business.Common.Entities
{
    public class Kitchen : EntityBase
    {
        public string Name { get; set; }
        public IEnumerable<Food> Foods { get; set; }

        public IEnumerable<Bevarage> Bevarages { get; set; }
    }
}
