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
    
    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            this.LikeSet = new HashSet<Like>();
        }
    
        public int CommentId { get; set; }
        public string Text { get; set; }
        public string Midia { get; set; }
        public int ProfileProfileId { get; set; }
        public Nullable<int> PostPostId { get; set; }
        public Nullable<int> MusicMusicId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like> LikeSet { get; set; }
        public virtual Post PostSet { get; set; }
        public virtual Profile ProfileSet { get; set; }
    }
}
