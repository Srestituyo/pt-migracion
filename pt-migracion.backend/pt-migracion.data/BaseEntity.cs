using System;

namespace pt_migracion.data
{
    public class BaseEntity
    {
        public Guid Id {get; set;} = new Guid();

        public DateTime TimeStamp {get; set;}
    }
}