using Business.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InformationManager : IInformationService
    {
        EfInforamtionRepository _efInforamtionRepository;
        public InformationManager()
        {
            _efInforamtionRepository = new EfInforamtionRepository();
        }
        public Information GetByID(int ID)
        {
            return _efInforamtionRepository.Get(x => x.InfoID == ID);
        }

        public List<Information> GetList()
        {
            return _efInforamtionRepository.GetListAll();
        }

        public List<Information> GetListByID(int id)
        {
            return _efInforamtionRepository.List(x => x.UUID == id);
        }

        public void InformationAdd(Information information)
        {
            _efInforamtionRepository.Insert(information);
        }

        public void InformationDelete(Information information)
        {
            _efInforamtionRepository.Delete(information);
        }

        public void InformationUpdate(Information information)
        {
            _efInforamtionRepository.Update(information);
        }
    }
}
