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

    }
}
