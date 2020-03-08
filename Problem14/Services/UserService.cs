using System;
using System.Collections.Generic;
using System.Text;
using TutsShit.Repos;

namespace TutsShit.Services
{
    public class UserService
    {
        IUserRepo _repo;
        public UserService(IUserRepo userRepo)
        {
            _repo = userRepo;
        }

        public void CreateUser()
        {
            _repo.CreateUser();
        }

        public void GetAllUsers()
        {
            _repo.GetAllUsers();
        }
    }
}
