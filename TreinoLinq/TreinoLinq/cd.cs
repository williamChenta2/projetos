//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreinoLinq
{
    using System;
    using System.Collections.Generic;
    
    public partial class cd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cd()
        {
            this.cd1 = new HashSet<cd>();
            this.faixa = new HashSet<faixa>();
        }
    
        public int codigo_cd { get; set; }
        public Nullable<int> codigo_gravadora { get; set; }
        public string nome_cd { get; set; }
        public Nullable<decimal> preco_venda { get; set; }
        public Nullable<System.DateTime> data_lancamento { get; set; }
        public Nullable<int> cd_indicado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cd> cd1 { get; set; }
        public virtual cd cd2 { get; set; }
        public virtual gravadora gravadora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<faixa> faixa { get; set; }
    }
}