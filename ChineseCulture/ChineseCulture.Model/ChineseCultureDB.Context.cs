﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChineseCulture.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChineseCultureDBEntities : DbContext
    {
        public ChineseCultureDBEntities()
            : base("name=ChineseCultureDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FriendLink> FriendLink { get; set; }
        public virtual DbSet<Function> Function { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberLoginLog> MemberLoginLog { get; set; }
        public virtual DbSet<ArticleType> ArticleType { get; set; }
        public virtual DbSet<ArticleTicks> ArticleTicks { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<SiteMenu> SiteMenu { get; set; }
        public virtual DbSet<BaomingXuanShou> BaomingXuanShou { get; set; }
        public virtual DbSet<SMSLog> SMSLog { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLog { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<ArticleCategory> ArticleCategory { get; set; }
    }
}
