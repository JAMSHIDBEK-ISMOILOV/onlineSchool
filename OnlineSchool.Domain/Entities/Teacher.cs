﻿using System;
using System.Collections.Generic;

namespace OnlineSchool.Domain.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Sciences = new HashSet<Science>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<Science> Sciences { get; set; }
    }
}
