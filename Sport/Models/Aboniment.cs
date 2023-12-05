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
    
    public partial class Aboniment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aboniment()
        {
            this.Oplata = new HashSet<Oplata>();
        }
    
        public int KodAboniment { get; set; }
        public int Client { get; set; }
        public Nullable<System.DateTime> DataPokupki { get; set; }
        public Nullable<System.DateTime> DataOkonhanie { get; set; }
        public Nullable<int> TipAboniment { get; set; }
        public Nullable<int> Summa { get; set; }
        public Nullable<int> SposobOplati { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual SposobOplati SposobOplati1 { get; set; }
        public virtual TipAbonimenta TipAbonimenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oplata> Oplata { get; set; }
    }
}
