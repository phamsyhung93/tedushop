namespace TeduShop.Model.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TeduShopModel : DbContext
    {
        public TeduShopModel()
            : base("name=TeduShopModels")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Error> Errors { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<IdentityRole> IdentityRoles { get; set; }
        public virtual DbSet<IdentityUserClaim> IdentityUserClaims { get; set; }
        public virtual DbSet<IdentityUserLogin> IdentityUserLogins { get; set; }
        public virtual DbSet<IdentityUserRole> IdentityUserRoles { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PostCategory> PostCategories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SupportOnline> SupportOnlines { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.IdentityUserClaims)
                .WithOptional(e => e.ApplicationUser)
                .HasForeignKey(e => e.ApplicationUser_Id);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.IdentityUserLogins)
                .WithOptional(e => e.ApplicationUser)
                .HasForeignKey(e => e.ApplicationUser_Id);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.IdentityUserRoles)
                .WithOptional(e => e.ApplicationUser)
                .HasForeignKey(e => e.ApplicationUser_Id);

            modelBuilder.Entity<IdentityRole>()
                .HasMany(e => e.IdentityUserRoles)
                .WithOptional(e => e.IdentityRole)
                .HasForeignKey(e => e.IdentityRole_Id);

            modelBuilder.Entity<MenuGroup>()
                .HasMany(e => e.Menus)
                .WithRequired(e => e.MenuGroup)
                .HasForeignKey(e => e.GroupID);

            modelBuilder.Entity<Page>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .HasMany(e => e.Posts)
                .WithRequired(e => e.PostCategory)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Post>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Posts)
                .Map(m => m.ToTable("PostTags").MapLeftKey("PostID").MapRightKey("TagID"));

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductCategory)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("ProductTags").MapLeftKey("ProductID").MapRightKey("TagID"));

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.ID)
                .IsUnicode(false);
        }
    }
}
