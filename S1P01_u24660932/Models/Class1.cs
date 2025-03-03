using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S1P01_u24660932.Models
{
	public class Class1
	{
		[Display(Name = "STUDENT NUMBER")]
		public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string EmailAddress { get; set; }
    }
}