using HouseApp.Business.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Business.Common.Entities
{
    public class EntityBase : IEntity
    {
        public string Id { get; set; }
        public DateTime DateAdded    { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted  { get; set; }
        public bool IsDeleted { get; set; }
    }
}
