using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MidTermProject.Views.Level1
{
    public class BeerModel : PageModel
    {
        [ViewData]
        public int CapacityOfSmallOne { get; set; }
        [ViewData]
        public int CapacityOfBigOne { get; set; }
        public void OnGet()
        {
            CapacityOfBigOne = 0;
            CapacityOfSmallOne = 0;
        }

       
    }
}
