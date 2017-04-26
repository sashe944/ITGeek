﻿

using System.ComponentModel.DataAnnotations;

namespace ITGeek.Gateway.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}