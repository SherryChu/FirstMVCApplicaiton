using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApplicaiton.Models
{
  
        [MetadataType(typeof(CategoryMetaData))]
        public partial class Category { }

        public class CategoryMetaData
        {
            [Required]
            [Display(Name = "Category Name")]
            public object CategoryName { get; set; }

            [Required]
            [StringLength(30, ErrorMessage = "The {0} must not exceed {2} characters.", MinimumLength = 30)]
            public object Description { get; set; }
        }

   

}