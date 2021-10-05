using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn_razor_pages.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGetContact()
        {
            Message = "Your email was sent to our team."; 
        }

        public void OnGetSubscribe()
        {
            Message = "you have been added to the mailing list."; 
        }
    }
}
