using Business.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        EfContactRepository _efContactRepository;
        public ContactManager()
        {
            _efContactRepository = new EfContactRepository();
        }
        public void ContactAdd(Contact contact)
        {
            _efContactRepository.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _efContactRepository.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _efContactRepository.Update(contact);
        }

        public Contact GetByID(int ID)
        {
            return _efContactRepository.Get(x => x.UUID == ID);
        }

        public List<Contact> GetList()
        {
            return _efContactRepository.GetListAll();
        }
    }
}
