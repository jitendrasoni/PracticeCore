using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeCore.Models;

namespace PracticeCore.Profile
{
    public class AutoMapping1 : AutoMapper.Profile
    {
        public AutoMapping1()
        {
            CreateMap< Models.Customer, Customer1>(); // means you want to map from User to UserDTO
        }
    }
}
