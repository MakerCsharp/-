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
    
    public partial class Developers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Developers()
        {
            this.Games = new HashSet<Games>();
        }
    
        public int idDeveloper { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string SecondName { get; set; }
        public Nullable<int> idCountry { get; set; }
        public byte[] imageLogo { get; set; }
    
        public virtual Countrys Countrys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Games> Games { get; set; }
    }
}