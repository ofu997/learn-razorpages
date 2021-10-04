using learn_razor_pages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_razor_pages.Services
{

    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}
