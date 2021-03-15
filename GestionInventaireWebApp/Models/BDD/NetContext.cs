using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class NetContext : DbContext
    {
        public NetContext(DbContextOptions<NetContext> options)
    : base(options)
        { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderArticle> OrderArticles { get; set; }
        public DbSet<Provider> Providers{ get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderArticle>()
                .HasKey(o => new { o.ArticleId, o.OrderId });

            modelBuilder.Entity<Admin>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<User>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Article>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<City>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Provider>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Stock>()
                .HasKey(a => a.Id);


            modelBuilder.Entity<User>(e => {
                e.HasKey(u => u.Id);
                e.HasOne(u => u.Admin)
                .WithMany(a => a.Users)
                .HasForeignKey(m => m.AdminID)
                .HasConstraintName("fk_users_admin");
            });

            modelBuilder.Entity<Provider>(p => {
                p.HasKey(pa => pa.Id);
                p.HasOne(pa => pa.Admin)
                .WithMany(a => a.Providers)
                .HasForeignKey(pm => pm.AdminID)
                .HasConstraintName("fk_providers_admin");
            });

            modelBuilder.Entity<Stock>(s => {
                s.HasKey(sa => sa.Id);
                s.HasOne(sa => sa.Admin)
                .WithMany(a => a.Stocks)
                .HasForeignKey(sm => sm.AdminID)
                .HasConstraintName("fk_stock_admin");
            });

            modelBuilder.Entity<Article>(aa => {
                aa.HasKey(aaa => aaa.Id);
                aa.HasOne(aaa => aaa.Admin)
                .WithMany(a => a.Articles)
                .HasForeignKey(aaaa => aaaa.AdminID)
                .HasConstraintName("fk_article_admin");
            });

            modelBuilder.Entity<Order>(o => {
                o.HasKey(oa => oa.Id);
                o.HasOne(oa => oa.Admin)
                .WithMany(a => a.Orders)
                .HasForeignKey(oi => oi.AdminID)
                .HasConstraintName("fk_order_admin");
            });
        }
    }
}
