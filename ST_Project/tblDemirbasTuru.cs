//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ST_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDemirbasTuru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDemirbasTuru()
        {
            this.tblDemirbas = new HashSet<tblDemirbas>();
        }
    
        public int DemirbasTuruID { get; set; }
        public string DemirbasTuruAdi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDemirbas> tblDemirbas { get; set; }
    }
}