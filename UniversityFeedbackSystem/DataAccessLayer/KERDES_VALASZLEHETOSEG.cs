//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class KERDES_VALASZLEHETOSEG
    {
        public KERDES_VALASZLEHETOSEG()
        {
            this.VALASZOKs = new HashSet<VALASZOK>();
        }
    
        public int ID_KERDES_VALASZLEHETOSEG { get; set; }
        public Nullable<int> ID_KERDES { get; set; }
        public string VALASZLEHETOSEG { get; set; }
        public Nullable<int> VALASZLEHETOSEG_ERTEK { get; set; }
    
        public virtual KERDESEK KERDESEK { get; set; }
        public virtual ICollection<VALASZOK> VALASZOKs { get; set; }
    }
}
