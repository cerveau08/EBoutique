using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBoutique.Models
{
    public class Categorie
    {
        [Key]
        [ScaffoldColumn(false)]
        public int IdCategorie { get; set; }

        [MaxLength(100, ErrorMessage = "La taille maximale est de 100")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Libelle catégorie")]
        public string NomCategorie { get; set; }

        [MaxLength(100, ErrorMessage = "La taille maximale est de 100")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Code catégorie")]
        public string CodeCategorie { get; set; }

    }
}