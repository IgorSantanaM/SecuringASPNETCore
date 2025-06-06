﻿using System.ComponentModel.DataAnnotations;

namespace Marvin.IDP.Entities
{
    public class UserLogin
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [MaxLength(200)]
        [Required]
        public string Provider { get; set; }

        [MaxLength(200)]
        [Required]
        public string ProviderIdentityKey { get; set; }

        public User User { get; set; }

    }
}
