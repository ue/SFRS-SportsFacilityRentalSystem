//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJSAuthentication.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tesisler
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tesisler()
        {
            this.TesisKiralama = new HashSet<TesisKiralama>();
        }
    
        public int Id { get; set; }
        public string tesisAdi { get; set; }
        public string sahaAdi { get; set; }
        public string sporTuru { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }
        public string telNo { get; set; }
        public Nullable<bool> servis { get; set; }
        public string resim { get; set; }
        public Nullable<int> saatDilimi { get; set; }
        public Nullable<System.TimeSpan> acilisSaati { get; set; }
        public Nullable<System.TimeSpan> kapanisSaati { get; set; }
        public Nullable<int> ucret { get; set; }
    
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TesisKiralama> TesisKiralama { get; set; }
    }
}
