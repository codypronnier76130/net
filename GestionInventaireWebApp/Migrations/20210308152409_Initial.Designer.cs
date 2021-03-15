﻿// <auto-generated />
using System;
using GestionInventaireWebApp.Models.BDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionInventaireWebApp.Migrations
{
    [DbContext(typeof(NetContext))]
    [Migration("20210308152409_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("BuyPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("SellPrice")
                        .HasColumnType("int");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("StockId");

                    b.HasIndex("TypeId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Postcode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Citys");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("StockId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.OrderArticle", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderArticles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("CityId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Article", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Admin", "Admin")
                        .WithMany("Articles")
                        .HasForeignKey("AdminId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Provider", "Provider")
                        .WithMany("Articles")
                        .HasForeignKey("ProviderId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Stock", "Stock")
                        .WithMany("Articles")
                        .HasForeignKey("StockId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Type", "Type")
                        .WithMany("Articles")
                        .HasForeignKey("TypeId");

                    b.Navigation("Admin");

                    b.Navigation("Provider");

                    b.Navigation("Stock");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Order", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Admin", "Admin")
                        .WithMany("Orders")
                        .HasForeignKey("AdminId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Stock", "Stock")
                        .WithMany("Orders")
                        .HasForeignKey("StockId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("Admin");

                    b.Navigation("Stock");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.OrderArticle", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Article", "Article")
                        .WithMany("OrderArticles")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Order", "Order")
                        .WithMany("OrderArticles")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Provider", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Admin", "Admin")
                        .WithMany("Providers")
                        .HasForeignKey("AdminId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.City", "City")
                        .WithMany("Providers")
                        .HasForeignKey("CityId");

                    b.Navigation("Admin");

                    b.Navigation("City");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Stock", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Admin", "Admin")
                        .WithMany("Stocks")
                        .HasForeignKey("AdminId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Type", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Admin", "Admin")
                        .WithMany("Types")
                        .HasForeignKey("AdminId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.User", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Admin", "Admin")
                        .WithMany("Users")
                        .HasForeignKey("AdminId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId");

                    b.Navigation("Admin");

                    b.Navigation("City");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Admin", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Orders");

                    b.Navigation("Providers");

                    b.Navigation("Stocks");

                    b.Navigation("Types");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Article", b =>
                {
                    b.Navigation("OrderArticles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.City", b =>
                {
                    b.Navigation("Providers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Order", b =>
                {
                    b.Navigation("OrderArticles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Provider", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Stock", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Type", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
