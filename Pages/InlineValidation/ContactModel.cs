﻿using System.ComponentModel.DataAnnotations;

namespace HtmxCookbook.Pages.InlineValidation
{
        public record Contact([Display(Name = "First Name")] string FirstName, [Display(Name = "Last Name")] string LastName, [EmailAddress]string Email);
}
