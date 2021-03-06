﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Garderie.ViewModels.EmployeViewModels
{
    public class EditEmployeViewModel
    {
        public int EmployeId { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Required]
        public string Sexe { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date de naissance")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/1930", "1/1/2000")]
        public DateTime? DateNaissance { get; set; }

        [Required]
        [Display(Name = "Numéro de sécurité sociale")]
        public string NumSecu { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Required]
        public string Poste { get; set; }

        [Required]
        public byte Externe { get; set; }
    }
}
