﻿using System;
using System.Collections.Generic;

namespace FontEndd.Models
{
    public partial class Account
    {
        public Account()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public int AccountId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Type { get; set; }
        public string? ActiveCode { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
