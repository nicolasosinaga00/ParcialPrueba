namespace ApiWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Currency
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
    public class GeoRef
    {
        [Key]
        [Required]
        [Range(-90, 90)]
        public double Latitude { get; set; }
        [Required]
        [Range(-180, 180)]
        public double Longitude { get; set; }

    }
    public class Country
    {
        [Key]
        [Required(ErrorMessage = "You must enter the field{0}")]
        public string name { get; set; }

        [Required(ErrorMessage = "You must enter the field{0}")]
        public string capital { get; set; }

        [Required(ErrorMessage = "You must enter the field{0}")]
        public int population { get; set; }

        [Required(ErrorMessage = "You must enter the field{0}")]
        public List<GeoRef> lating { get; set; }

        [Required(ErrorMessage = "You must enter the field{0}")]
        public List<String>  timezones { get; set; }

        [Required(ErrorMessage = "You must enter the field{0}")]
        public List<Currency> currencies { get; set; }

        [Required(ErrorMessage = "You must enter the field{0}")]
        [Url]
        public string flag { get; set; }

    }
}