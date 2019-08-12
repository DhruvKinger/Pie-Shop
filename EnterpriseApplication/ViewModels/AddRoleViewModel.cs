using System;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseApplication.ViewModels
{
    public class AddRoleViewModel
    {
        [Required]
        [Display(Name = "Role name")]
        public string RoleName { get; set; }
    }
}