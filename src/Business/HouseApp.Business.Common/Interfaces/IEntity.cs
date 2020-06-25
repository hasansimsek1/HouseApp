using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Business.Common.Interfaces
{
    public interface IEntity
    {
        public string Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
