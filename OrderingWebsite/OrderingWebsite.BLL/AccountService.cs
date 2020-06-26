using System;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using OrderingWebsite.DAL.Models;

namespace OrderingWebsite.BLL
{
    public class AccountService
    {
        private readonly DataContext _dataContext;

        public AccountService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public User GetUser(string name, string password)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Name == name && x.Password == password);
            return user;
        }

        public async Task<bool> ResetPwd(int userId, string oldPassword, string password)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (user == null || user.Password != oldPassword)
                return false;
            user.Password = password;

            return await _dataContext.SaveChangesAsync() > 0;
        }

        public bool Register(string username, string password, string address, string phone)
        {
            var user = new User()
            {
                Name = username,
                RoleId = 2,
                Password = password,
                Address = address,
                Phone = phone,
                CreateTime = DateTime.Now
            };
            _dataContext.Users.Add(user);
            return _dataContext.SaveChanges() > 0;
        }
    }
}
