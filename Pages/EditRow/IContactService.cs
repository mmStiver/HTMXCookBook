﻿namespace HtmxCookbook.Pages.EditRow
{
    public interface IContactService
    {
        IEnumerable<Contact> Get();
        Contact Get(int Id);
        void Update(Contact updatedContact);
    }
}
