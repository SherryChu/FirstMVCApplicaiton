using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApplicaiton.Models
{
    [MetadataType(typeof(RegionMetaData))]
    public partial class Region { }

    public class RegionMetaData
    {
        [Required]
        [Display(Name = "Region Description")]
       
      
        [StringLength(15, ErrorMessage = "The {0} must not exceed {2} characters.", MinimumLength = 0)]
        public object RegionDescription { get; set; }

        [Required]
        [Display(Name = "Region ID")]
        public int RegionID { get; set; }
    }

}