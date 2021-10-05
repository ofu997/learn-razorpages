using learn_razor_pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_razor_pages
{
    public class PopularBrews : ViewComponent
    {
        private IMenuService menuService;

        public PopularBrews(IMenuService menuService)
        {
            this.menuService = menuService; 
        }

        // original version
        //public async Task<IViewComponentResult> InvokeAsync(int count)
        //{
        //    return View(menuService.GetPopularItems().Take(count));
        //}

        public IViewComponentResult Invoke(int count)
        {
            //var menu = new MenuService();
            return View(menuService.GetPopularItems().Take(count));
        }

    }
}
