//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicMe2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Music
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Music()
        {
            this.LikeSet = new HashSet<Like>();
            this.ShareSet = new HashSet<Share>();
            this.PlaylistSet = new HashSet<Playlist>();
        }
    
        public int MusicId { get; set; }
        public string Name { get; set; }
        public string Band { get; set; }
        public string Album { get; set; }
        public string Midia { get; set; }
        public int ProfileProfileId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like> LikeSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Share> ShareSet { get; set; }
        public virtual Profile ProfileSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Playlist> PlaylistSet { get; set; }
        public virtual Post Post { get; set; }
    }
}
