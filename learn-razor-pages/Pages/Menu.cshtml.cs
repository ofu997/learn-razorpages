using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learn_razor_pages.Models;
using learn_razor_pages.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace learn_razor_pages.Pages
{
    public class MenuModel : PageModel
    {
        private IMenuService menuService;
        private ILogger<MenuModel> logger;

        public List<MenuItem> Menu { get; set; }

        public MenuModel(IMenuService menuService, ILogger<MenuModel> logger)
        {
            this.menuService = menuService;
            this.logger = logger; 
        }
        public void OnGet()
        {
            // no longer needed
            //var menuService = new MenuService();
            Menu = menuService.GetMenuItems();
        }
    }
}
