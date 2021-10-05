using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learn_razor_pages.Models;
using learn_razor_pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn_razor_pages.Pages
{
    public class ItemModel : PageModel
    {
        public string Message { get; set; }
        public MenuItem Item { get; private set; }

        public void OnGet(string slug)
        {
            var menuService = new MenuService();
            Item = menuService.GetMenuItems().FirstOrDefault(x => x.Slug == slug); 
        }
    }
}
