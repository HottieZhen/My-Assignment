﻿// <auto-generated />
using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace OrderingWebsite.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("OrderingWebsite.DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "荤菜"
                        },
                        new
                        {
                            Id = 2,
                            Name = "素菜"
                        });
                });

            modelBuilder.Entity("OrderingWebsite.DAL.Models.FoodMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("ImgUrl")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("StockCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoodMenus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 985, DateTimeKind.Local).AddTicks(8480),
                            Description = "好吃的油焖大虾，2斤一份",
                            ImgUrl = "/upload/youmendaxie.jpg",
                            Name = "油焖大虾",
                            Price = 128m,
                            StockCount = 100,
                            Type = "荤菜"
                        },
                        new
                        {
                            Id = 2,
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 985, DateTimeKind.Local).AddTicks(9610),
                            Description = "手撕包菜",
                            ImgUrl = "/upload/1.jpg",
                            Name = "手撕包菜",
                            Price = 12m,
                            StockCount = 100,
                            Type = "荤菜"
                        },
                        new
                        {
                            Id = 3,
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 985, DateTimeKind.Local).AddTicks(9650),
                            Description = "水煮肉片一份",
                            ImgUrl = "/upload/shuizutoupian.jpg",
                            Name = "水煮肉片",
                            Price = 38m,
                            StockCount = 100,
                            Type = "荤菜"
                        });
                });

            modelBuilder.Entity("OrderingWebsite.DAL.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdatedTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 986, DateTimeKind.Local).AddTicks(1630),
                            LastUpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 120m,
                            Status = "已付款",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 986, DateTimeKind.Local).AddTicks(2550),
                            LastUpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 120m,
                            Status = "已送货",
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 986, DateTimeKind.Local).AddTicks(2580),
                            LastUpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 120m,
                            Status = "已完成",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("OrderingWebsite.DAL.Models.Order_Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Order_Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 0,
                            FoodId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Count = 0,
                            FoodId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            Count = 0,
                            FoodId = 2,
                            OrderId = 2
                        });
                });

            modelBuilder.Entity("OrderingWebsite.DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("NickName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "慈溪市科院3#443",
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 976, DateTimeKind.Local).AddTicks(3430),
                            Name = "吴皇震",
                            NickName = "HZW",
                            Password = "202cb962ac59075b964b07152d234b70",
                            Phone = "13568955684",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 2,
                            Address = "慈溪市科院3#443",
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 981, DateTimeKind.Local).AddTicks(1310),
                            Name = "方浩亦",
                            NickName = "FHY",
                            Password = "202cb962ac59075b964b07152d234b70",
                            Phone = "13668955684",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "慈溪市科院3#443",
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 981, DateTimeKind.Local).AddTicks(1390),
                            Name = "张淼",
                            NickName = "SSSSSS",
                            Password = "202cb962ac59075b964b07152d234b70",
                            Phone = "13668234244",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 4,
                            Address = "慈溪市科院3#443",
                            CreateTime = new DateTime(2020, 6, 25, 11, 52, 46, 981, DateTimeKind.Local).AddTicks(1510),
                            Name = "Admin",
                            NickName = "HZW",
                            Password = "202cb962ac59075b964b07152d234b70",
                            Phone = "13568955684",
                            RoleId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
