//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sport.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Polizovateli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Polizovateli()
        {
            this.DanniePersonal = new HashSet<DanniePersonal>();
        }
    
        public int KodPolizovatieli { get; set; }
        public string LoginPolizovateli { get; set; }
        public string ParoliPolizovateli { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanniePersonal> DanniePersonal { get; set; }
    }
}
