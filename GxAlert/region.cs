//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GxAlert
{
    using System;
    using System.Collections.Generic;
    
    public partial class region
    {
        public region()
        {
            this.people = new HashSet<person>();
            this.notificationregions = new HashSet<notificationregion>();
            this.deployments = new HashSet<deployment>();
        }
    
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
    
        public virtual country country { get; set; }
        public virtual ICollection<person> people { get; set; }
        public virtual ICollection<notificationregion> notificationregions { get; set; }
        public virtual ICollection<deployment> deployments { get; set; }
    }
}
