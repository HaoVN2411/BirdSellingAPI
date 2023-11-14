﻿// <auto-generated />
using System;
using BirdSellingAPI._3._Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    [DbContext(typeof(BirdFarmContext))]
    partial class BirdFarmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.BirdCategoryEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BirdCategory");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.CartEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("order_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(38,4)");

                    b.Property<string>("product_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("quantity")
                        .HasColumnType("decimal(38,4)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("order_id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("OrderEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("orderStatus")
                        .HasColumnType("int");

                    b.Property<decimal?>("orderTotal")
                        .HasColumnType("decimal(38,4)");

                    b.Property<DateTimeOffset>("order_date")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("paymentMenthod_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("paymentMenthod_id");

                    b.HasIndex("user_id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PhoiGiongEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("NgayChoPhoi")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("NgayCoTrung")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("NgayTrungNo")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("SoTrung")
                        .HasColumnType("int");

                    b.Property<int?>("SoTrungHong")
                        .HasColumnType("int");

                    b.Property<int?>("SoTrungNo")
                        .HasColumnType("int");

                    b.Property<string>("bird_father_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bird_mother_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("phoiGiongEntities");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.ProductEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("TypeProduct")
                        .HasColumnType("int");

                    b.Property<string>("bird_father_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bird_mother_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("day_of_birth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(38,4)");

                    b.Property<bool?>("sex")
                        .HasColumnType("bit");

                    b.Property<int>("statusProduct")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("category_id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.RoleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("role_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("VerifyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("createdAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("role_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("role_id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserPaymentMenthodEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserPaymentMenthod");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserRefreshToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("JwtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isUsed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("UserRefreshToken");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.userReviewEntiry", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("bird_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rating_value")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserReview");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.CartEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.OrderEntity", "Order")
                        .WithMany()
                        .HasForeignKey("order_id");

                    b.HasOne("BirdSellingAPI._3._Repository.Data.ProductEntity", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BirdSellingAPI._3._Repository.Data.UserEntity", "User")
                        .WithMany("Carts")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.OrderEntity", null)
                        .WithMany("orderEntities")
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("BirdSellingAPI._3._Repository.Data.UserPaymentMenthodEntity", "paymentMenthod")
                        .WithMany()
                        .HasForeignKey("paymentMenthod_id");

                    b.HasOne("BirdSellingAPI._3._Repository.Data.UserEntity", "User")
                        .WithMany("OrderEntities")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("paymentMenthod");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.ProductEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.BirdCategoryEntity", "BirdCategory")
                        .WithMany("Products")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BirdCategory");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.RoleEntity", "Role")
                        .WithMany("UserEntities")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserRefreshToken", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.UserEntity", "UserEntity")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.BirdCategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderEntity", b =>
                {
                    b.Navigation("orderEntities");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.ProductEntity", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.RoleEntity", b =>
                {
                    b.Navigation("UserEntities");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserEntity", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
