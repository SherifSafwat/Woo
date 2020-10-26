﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Woo.Data;

namespace Woo.Migrations
{
    [DbContext(typeof(WooContext))]
    [Migration("20200514135927_createinvoiceh2")]
    partial class createinvoiceh2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Woo.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerNum")
                        .HasColumnType("int");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SourceID")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Woo.Models.InvoiceT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ItemNum")
                        .HasColumnType("int");

                    b.Property<int>("LineDisc")
                        .HasColumnType("int");

                    b.Property<int>("LineNum")
                        .HasColumnType("int");

                    b.Property<int>("LineTax")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("PriceListId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalLine")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("InvoiceT");
                });

            modelBuilder.Entity("Woo.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("GlobalBarCode")
                        .HasColumnType("int");

                    b.Property<int>("GrantBy")
                        .HasColumnType("int");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemNum")
                        .HasColumnType("int");

                    b.Property<int>("LocalBarCode")
                        .HasColumnType("int");

                    b.Property<int>("SourceID")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Woo.Models.Price", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("GrantBy")
                        .HasColumnType("int");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ItemPrice")
                        .HasColumnType("int");

                    b.Property<int>("PriceNum")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ItemId");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("Woo.Models.Resp", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RespNum")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Resp");
                });

            modelBuilder.Entity("Woo.Models.Seller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("GrantBy")
                        .HasColumnType("int");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SellerNum")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("Woo.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("GrantBy")
                        .HasColumnType("int");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserNum")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Woo.Models.UserResp", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("GrantBy")
                        .HasColumnType("int");

                    b.Property<string>("GrantComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GrantFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GrantToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RespId")
                        .HasColumnType("int");

                    b.Property<string>("SysComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserRespNum")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("UserResp");
                });

            modelBuilder.Entity("Woo.Models.Price", b =>
                {
                    b.HasOne("Woo.Models.Item", null)
                        .WithMany("ItemPrices")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
