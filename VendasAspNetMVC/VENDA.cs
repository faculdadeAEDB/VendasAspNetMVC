//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VendasAspNetMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA()
        {
            this.ITEMVENDAs = new HashSet<ITEMVENDA>();
        }
    
        public int ID { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Funcionario { get; set; }
        public System.DateTime VenData { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEMVENDA> ITEMVENDAs { get; set; }
    }
}