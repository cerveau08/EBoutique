using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBoutique.Models
{
    public class Produit
    {
        [Key]
        [ScaffoldColumn(false)]
        public int IdProduit { get; set; }

        [MaxLength(100, ErrorMessage = "La taille maximale est de 100")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Libelle")]
        public string NomProduit { get; set; }

        [MaxLength(100, ErrorMessage = "La taille maximale est de 100")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Image")]
        [DataType(DataType.ImageUrl)]
        public string NomImage { get; set; }

        [MaxLength(1000, ErrorMessage = "La taille maximale est de 1000")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Description")]
        public string DescriptionProduit { get; set; }
    }
}