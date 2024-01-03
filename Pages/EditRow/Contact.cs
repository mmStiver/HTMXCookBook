using System.ComponentModel.DataAnnotations;

namespace HtmxCookbook.Pages.EditRow
{
    public record Contact(int Id, [Display(Name = "Name")] string Name, [EmailAddress]string Email, bool Status = true);
}
