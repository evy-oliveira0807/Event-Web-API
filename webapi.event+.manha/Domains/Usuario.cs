﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do usuario é obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do usuario é obrigatorio!")]

        public string? Email { get; set;}

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "Senha obrigatorio!")]
        [StringLength(60,MinimumLength =6, ErrorMessage ="Senha deve conter de 6 a 60 caracteres")]
        public string? Senha { get; set; }

        //ref.tabela TiposUsurio = FK
        [Required(ErrorMessage ="Informe o tipo do usuario!")]
        public Guid IdTipoUsuario { get; set; }

        

        [ForeignKey(nameof(IdTipoUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
