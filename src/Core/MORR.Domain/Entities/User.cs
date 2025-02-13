﻿using FOF.Domain.Common;

namespace MORR.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public User()
        {
            CreatedUsers = new HashSet<User>();
            UpdatedUsers = new HashSet<User>();

            UserRoles = new HashSet<UserRole>();

            CreatedProduct = new HashSet<Product>();
            UpdatedProduct = new HashSet<Product>();

            CreatedOrder = new HashSet<Order>();
            UpdatedOrder = new HashSet<Order>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string? Email { get; set; }
        public string PasswordHash { get; set; }
        public int LoyaltyPoints { get; set; }

        public virtual ICollection<User> CreatedUsers { get; set; }
        public virtual ICollection<User> UpdatedUsers { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<Product> CreatedProduct { get; set; }
        public virtual ICollection<Product> UpdatedProduct { get; set; }

        public virtual ICollection<Order> CreatedOrder { get; set; }
        public virtual ICollection<Order> UpdatedOrder { get; set; }



    }
}
