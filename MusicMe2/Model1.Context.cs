﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Comment> CommentSet { get; set; }
        public virtual DbSet<Friend> FriendSet { get; set; }
        public virtual DbSet<Like> LikeSet { get; set; }
        public virtual DbSet<Music> MusicSet { get; set; }
        public virtual DbSet<Playlist> PlaylistSet { get; set; }
        public virtual DbSet<Post> PostSet { get; set; }
        public virtual DbSet<Profile> ProfileSet { get; set; }
        public virtual DbSet<Share> ShareSet { get; set; }
    }
}
