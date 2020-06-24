﻿using System;
namespace OrderingWebsite.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
