//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Server
    {
        public string ServerId { get; set; }
        public string Name { get; set; }
        public bool IsTaskServer { get; set; }
        public bool IsActiveTaskServer { get; set; }
        public bool IsActiveWebServer { get; set; }
        public Nullable<bool> IsWebServer { get; set; }
        public Nullable<System.DateTime> LastOnline { get; set; }
    }
}