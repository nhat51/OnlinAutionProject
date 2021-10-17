﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineAutionAPI.Data;

namespace OnlineAutionAPI.Migrations
{
    [DbContext(typeof(AuctionOnlineDbContext))]
    partial class AuctionOnlineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bid_coin_pack", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bid_Coins_Value")
                        .HasColumnType("int");

                    b.Property<int>("Bonus_Coin")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Pack_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Bid_Coin_Packs");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bid_coin_trans_log", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bid_Coin_Pack_ID")
                        .HasColumnType("int");

                    b.Property<int>("Bid_Order_Log_ID")
                        .HasColumnType("int");

                    b.Property<int>("Bidder_ID")
                        .HasColumnType("int");

                    b.Property<int>("Coin_Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("Transaction_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Bid_Coin_Trans_Logs");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bid_order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Base_Price")
                        .HasColumnType("int");

                    b.Property<int>("Bid_Chair_Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("Bid_End_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Bid_Start_Time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BidderID")
                        .HasColumnType("int");

                    b.Property<int>("Cool_Down_Time_Per_Bid")
                        .HasColumnType("int");

                    b.Property<int>("Increment_Price_Per_Bid")
                        .HasColumnType("int");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BidderID");

                    b.ToTable("Bid_Orders");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bid_order_log", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bidder_Bid_Regist_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Bid_Order_Logs");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bidder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Current_bid_coins")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity_Card_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Locked_bid_coins")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Bidders");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bidder_bid_regist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bidder_ID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<DateTime>("Regist_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Bidder_Bid_Regists");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Prodcut_Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Prodcut_Images");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Actual_cost_in_curency")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Product_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Product_Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cat_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Product_Categories");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bid_order", b =>
                {
                    b.HasOne("OnlineAutionAPI.Entities.Bidder", "Bidder")
                        .WithMany("Bid_Orders")
                        .HasForeignKey("BidderID");

                    b.Navigation("Bidder");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Product", b =>
                {
                    b.HasOne("OnlineAutionAPI.Entities.Product_Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Bidder", b =>
                {
                    b.Navigation("Bid_Orders");
                });

            modelBuilder.Entity("OnlineAutionAPI.Entities.Product_Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
