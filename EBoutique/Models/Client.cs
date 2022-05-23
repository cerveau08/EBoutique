using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBoutique.Models
{
    public class Client
    {
        [Key]
        [ScaffoldColumn(false)]
        public int IdClient { get; set; }

        [MaxLength(80, ErrorMessage = "La taille maximale est de 80")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Nom du client")]
        public string Nom { get; set; }

        [MaxLength(150, ErrorMessage = "La taille maximale est de 150")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Prénom du client")]
        public string Prenom { get; set; }

        [MaxLength(150, ErrorMessage = "La taille maximale est de 150")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Email du client")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(150, ErrorMessage = "La taille maximale est de 150")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Date de naissance")]
        public string Datennaissance { get; set; }

        [MaxLength(150, ErrorMessage = "La taille maximale est de 150")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Age du client")]
        [NotMapped]
        public string AgeClient { get;}

        [MaxLength(20, ErrorMessage = "La taille maximale est de 20")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Téléphone du client")]
        public string Telephone { get; set; }

        [MaxLength(120, ErrorMessage = "La taille maximale est de 120")]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Crédit du client")]
        public string Credit { get; set; }

    }
}