//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boli
    {
        public int Id_Boala { get; set; }
        public string Denumire { get; set; }
    
        public virtual ChestionarDonare ChestionarDonare { get; set; }
    }
}
