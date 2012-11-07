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
    
    public partial class notification
    {
        public notification()
        {
            this.notificationcountries = new HashSet<notificationcountry>();
            this.notificationdeployments = new HashSet<notificationdeployment>();
            this.notificationlgas = new HashSet<notificationlga>();
            this.notificationpersons = new HashSet<notificationperson>();
            this.notificationregions = new HashSet<notificationregion>();
            this.notificationresults = new HashSet<notificationresult>();
            this.notificationstates = new HashSet<notificationstate>();
            this.notificationlogs = new HashSet<notificationlog>();
        }
    
        public int NotificationId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string SmsBody { get; set; }
        public System.DateTime InsertedOn { get; set; }
        public string InsertedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string PhoneBody { get; set; }
        public string NotificationName { get; set; }
    
        public virtual ICollection<notificationcountry> notificationcountries { get; set; }
        public virtual ICollection<notificationdeployment> notificationdeployments { get; set; }
        public virtual ICollection<notificationlga> notificationlgas { get; set; }
        public virtual ICollection<notificationperson> notificationpersons { get; set; }
        public virtual ICollection<notificationregion> notificationregions { get; set; }
        public virtual ICollection<notificationresult> notificationresults { get; set; }
        public virtual ICollection<notificationstate> notificationstates { get; set; }
        public virtual ICollection<notificationlog> notificationlogs { get; set; }
    }
}
