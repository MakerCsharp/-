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
    
    public partial class Games
    {
        public int idGame { get; set; }
        public string NameGame { get; set; }
        public string NameGenre { get; set; }
        public Nullable<int> idGenre { get; set; }
        public Nullable<int> idLevel { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> idDeveloper { get; set; }
        public byte[] imageGame { get; set; }
    
        public virtual Developers Developers { get; set; }
        public virtual LevelRating LevelRating { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
