using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using learn_razor_pages.Models;
using learn_razor_pages.Services;

namespace learn_razor_pages.Pages
{
    public class ContactModel : PageModel
    {
        // maps incoming data 
        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                //Message = "Your email has been sent";
                return new RedirectToPageResult("Confirmation", "Contact");
            }
            return Page(); 
        }

        public IActionResult OnPostSubscribe(string address)
        {
            EmailService.SendEmail(address);
            //Message = "You have been addd to the mailing list."; 
            return new RedirectToPageResult("Confirmation", "Subscribe"); 
        }
    }
}
