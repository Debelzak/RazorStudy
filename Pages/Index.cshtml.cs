using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace Webpage.Pages
{
    public class Index : PageModel
    {  
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string MyInput { get; private set; }
        
        public void OnPost()
        {
            
        }
    }
}