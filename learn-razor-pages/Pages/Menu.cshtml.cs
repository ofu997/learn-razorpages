using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learn_razor_pages.Models;
using learn_razor_pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn_razor_pages.Pages
{
    public class MenuModel : PageModel
    {
       public List<MenuItem> Menu { get; set; }
        public void OnGet()
        {
            var menuService = new MenuService();
            Menu = menuService.GetMenuItems(); 
        }
    }
}
