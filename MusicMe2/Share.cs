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
    
    public partial class Share
    {
        public int ShareId { get; set; }
        public int ProfileProfileId { get; set; }
        public Nullable<int> MusicMusicId { get; set; }
        public Nullable<int> PlaylistPlaylistId { get; set; }
        public Nullable<int> PostPostId { get; set; }
    
        public virtual Music MusicSet { get; set; }
        public virtual Playlist PlaylistSet { get; set; }
        public virtual Post PostSet { get; set; }
        public virtual Profile ProfileSet { get; set; }
    }
}
