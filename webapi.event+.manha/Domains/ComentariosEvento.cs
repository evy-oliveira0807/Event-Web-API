﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table(nameof(ComentariosEvento))]
    public class ComentariosEvento
    {
        [Key]
        public Guid iDComentariosEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage ="A descricao e obrigatoria!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A informacao de exibicao e obrigatoria!")]
        public bool Exibe { get; set; }

        //ref.tabela Usuario = FK
        [Required(ErrorMessage = "Usuario obrigatorio!")]

        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]

        public Usuario? Usuario { get; set; }

        //ref.tabela Evento = FK
        [Required(ErrorMessage = "Evento obrigatorio!")]

        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]

        public Evento? Evento { get; set; }

    }
}
