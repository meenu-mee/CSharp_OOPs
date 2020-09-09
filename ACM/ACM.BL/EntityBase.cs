using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {

        public bool IsNew { get; private set; } //if object represents new entity then true: new customer or old
        public bool HasChanges { get; set; } //if entity has been changed 
        public bool IsValid => Validate();//if entity's data is currently valid

        public EntityStateOption EntityState { get; set; } //defines if item is active or deleted

        public abstract bool Validate();
    }
}
