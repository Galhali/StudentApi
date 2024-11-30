﻿namespace StudentApi.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string HashedPassword { get; private set; }

        public User(
            Guid id,
            string userName,
            string email,
            string hashedPassword)
        {
            Id = id;
            UserName = userName;
            Email = email;
            HashedPassword = hashedPassword;
        }

        public User() { }
    }
}
