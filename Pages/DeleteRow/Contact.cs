using System.ComponentModel.DataAnnotations;

namespace HtmxCookbook.Pages.DeleteRow
{
        public record Contact(int Id, [Display(Name = "Name")] string Name, [EmailAddress]string Email, bool Status = true);
}
