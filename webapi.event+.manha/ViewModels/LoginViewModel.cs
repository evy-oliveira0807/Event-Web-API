﻿using System.ComponentModel.DataAnnotations;

namespace webapi.event_.manha.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email obrigatorio!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatorio!")]
        public string? Senha { get; set; }
    }
}
