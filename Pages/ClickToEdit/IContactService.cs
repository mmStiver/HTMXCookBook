namespace HtmxCookbook.Pages.ClickToEdit
{
    public interface IContactService
    {
        Contact Get(int Id);
        void Update(int Id, Contact updatedContact);

    }

}
