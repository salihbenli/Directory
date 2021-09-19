using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        void ContactAdd(Contact contact);
        void ContactDelete(Contact contact);
        void ContactUpdate(Contact contact);
        List<Contact> GetList();
        List<Contact> GetListByID(int id);
        Contact GetByID(int ID);
    }
}
