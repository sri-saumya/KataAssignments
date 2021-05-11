using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Taazaa_Assignment2
{


    public class Category
    {
        [Required(ErrorMessage = "ID is required")]
        private static int ID = 1;
        public int Category_ID { get; set; }
        public static int IncreamentID()
        {
            return ID++;
        }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [StringLength(4)]
        public string ShortCode { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }


    }




    
}
