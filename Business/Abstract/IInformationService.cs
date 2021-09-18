using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInformationService
    {
        void InformationAdd(Information information);
        void InformationDelete(Information information);
        void InformationUpdate(Information information);
        List<Information> GetList();
        List<Information> GetListByID(int id);
        Information GetByID(int ID);
    }
}
