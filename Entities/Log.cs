//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationGatekeeperAdmin.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int LogId { get; set; }
        public int RegistrationId { get; set; }
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public System.DateTime UpdateDateTime { get; set; }
        public int LogUpdateTypeId { get; set; }
    
        public virtual Registration Registration { get; set; }
        public virtual LogGatekeeper LogGatekeeper { get; set; }
        public virtual LogUserInformation LogUserInformation { get; set; }
        public virtual LogUpdateType LogUpdateType { get; set; }
    }
}
