//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application_kyropatkina
{
    using System;
    using System.Collections.Generic;
    
    public partial class LevelRating
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LevelRating()
        {
            this.Games = new HashSet<Games>();
        }
    
        public int idLevel { get; set; }
        public Nullable<int> NameLavel { get; set; }
        public string Description { get; set; }
        public byte[] imagelevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Games> Games { get; set; }
    }
}
