using System;
using Microsoft.EntityFrameworkCore;
using OrderingWebsite.DAL.Models;
using OrderingWebsite.DAL.Tools;

namespace Data.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
            
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FoodMenu> FoodMenus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Food> Order_Foods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Name).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(x => x.Phone).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(x => x.Address).HasMaxLength(500);
            modelBuilder.Entity<User>().Property(x => x.Avatar).HasMaxLength(500);
            modelBuilder.Entity<User>().Property(x => x.NickName).HasMaxLength(500);
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    RoleId = 2,
                    Name = "吴皇震",
                    NickName = "HZW",
                    Password = Encryp.MD5Encrypt("123"),
                    Phone = "13568955684",
                    Address = "慈溪市科院3#443",
                    CreateTime = DateTime.Now
                },
                new User()
                {
                    Id = 2,
                    RoleId = 2,
                    Name = "方浩亦",
                    Password = Encryp.MD5Encrypt("123"),
                    NickName = "FHY",
                    Phone = "13668955684",
                    Address = "慈溪市科院3#443",
                    CreateTime = DateTime.Now
                },
                new User()
                {
                    Id = 3,
                    RoleId = 2,
                    Name = "张淼",
                    NickName = "SSSSSS",
                    Password = Encryp.MD5Encrypt("123"),
                    Phone = "13668234244",
                    Address = "慈溪市科院3#443",
                    CreateTime = DateTime.Now
                },
                new User()
                {
                    Id = 4,
                    RoleId = 1,
                    Name = "Admin",
                    NickName = "HZW",
                    Password = Encryp.MD5Encrypt("123"),
                    Phone = "13568955684",
                    Address = "慈溪市科院3#443",
                    CreateTime = DateTime.Now
                });

            modelBuilder.Entity<FoodMenu>().HasKey(x => x.Id);
            modelBuilder.Entity<FoodMenu>().Property(x => x.Name).HasMaxLength(200);
            modelBuilder.Entity<FoodMenu>().Property(x => x.Description).HasMaxLength(500);
            modelBuilder.Entity<FoodMenu>().Property(x => x.ImgUrl).HasMaxLength(500);

            modelBuilder.Entity<Order>().HasKey(x => x.Id);

            modelBuilder.Entity<Order_Food>().HasKey(x => x.Id);

            modelBuilder.Entity<Category>().HasKey(x => x.Id);
            modelBuilder.Entity<Category>().Property(x => x.Name).HasMaxLength(500);

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "荤菜"
                },
                 new Category()
                 {
                     Id = 2,
                     Name = "素菜"
                 });

            modelBuilder.Entity<Order_Food>().HasData(
                 new Order_Food()
                 {
                     Id = 1,
                     OrderId = 1,
                     FoodId = 1,
                 },
                  new Order_Food()
                  {
                      Id = 2,
                      OrderId = 1,
                      FoodId = 2,
                  },
                  new Order_Food()
                  {
                      Id = 3,
                      OrderId = 2,
                      FoodId = 2
                  });

            modelBuilder.Entity<FoodMenu>().HasData(
               new FoodMenu()
               {
                   Id = 1,
                   Name = "油焖大虾",
                   Description = "好吃的油焖大虾，2斤一份",
                   Price = 128,
                   StockCount = 100,
                   ImgUrl = "/upload/youmendaxie.jpg",
                   CreateTime = DateTime.Now,
                   Type = "荤菜"
               },
                new FoodMenu()
                {
                    Id = 2,
                    Name = "手撕包菜",
                    Description = "手撕包菜",
                    Price = 12,
                    StockCount = 100,
                    ImgUrl = "/upload/1.jpg",
                    CreateTime = DateTime.Now,
                    Type = "荤菜"
                },
                new FoodMenu()
                {
                    Id = 3,
                    Name = "水煮肉片",
                    Description = "水煮肉片一份",
                    Price = 38,
                    StockCount = 100,
                    ImgUrl = "/upload/shuizutoupian.jpg",
                    CreateTime = DateTime.Now,
                    Type = "荤菜"
                });

            modelBuilder.Entity<Order>().HasData(
              new Order()
              {
                  Id = 1,
                  UserId = 1,
                  Price = 120,
                  CreateTime = DateTime.Now,
                  Status = "已付款"
              },
               new Order()
               {
                   Id = 2,
                   UserId = 3,
                   Price = 120,
                   CreateTime = DateTime.Now,
                   Status = "已送货"
               },
               new Order()
               {
                   Id = 3,
                   UserId = 3,
                   Price = 120,
                   CreateTime = DateTime.Now,
                   Status = "已完成"
               });
        }
    }
}
