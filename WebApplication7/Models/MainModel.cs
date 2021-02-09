using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Providers;
using System.Linq;
using System.Web;
using WebApplication7.LoacalResource;

namespace WebApplication7.Models
{
    public class MainModel
    {
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [MaxLength(30)]
        [Required]
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        public string NickName { get; set; }
        [EmailAddress(ErrorMessage = "Zły format email")]
        [Required]
        [Display(Name = "Email", ResourceType = typeof(Resource))]
        public string Email { get; set; }
    }
}