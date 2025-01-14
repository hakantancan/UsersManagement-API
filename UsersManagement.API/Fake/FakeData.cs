﻿using Bogus;
using System.Collections.Generic;
using UsersManagement.API.Models;

namespace UsersManagement.API.Fake
{
    public static class FakeData
    {
        private static List<User> _user;
        public static List<User> GetUsers(int number)
        {
            if (_user==null)
            {
                  _user = new Faker<User>()
                .RuleFor(u => u.Id, f => f.IndexFaker+1)
                 .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                 .RuleFor(u => u.LastName, f => f.Name.LastName())
                  .RuleFor(u => u.Address, f => f.Address.FullAddress())
                  .Generate(number);
            

            }
            return _user;
        }

    }
}
