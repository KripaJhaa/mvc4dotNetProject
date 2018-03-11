using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace customVlidatorProject.Models
{
    public class DateValidationClass
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [StartDateValidator(ErrorMessage = "Join Date can not be greater than current date")]
        public DateTime StartDate { get; set; }



        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [EndDateValidator(ErrorMessage = "End Date should be less than today and joining Date")]
        public DateTime EndDate { get; set; }

        

        
    }
}