﻿using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
