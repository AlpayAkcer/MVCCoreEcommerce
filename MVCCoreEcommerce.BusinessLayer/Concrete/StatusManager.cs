using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.DataAccessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.BusinessLayer.Concrete
{
    public class StatusManager : IStatusService
    {
        private readonly IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public void TAdd(Status t)
        {
            _statusDal.Insert(t);
        }

        public void TDelete(Status t)
        {
            _statusDal.Delete(t);
        }

        public Status TGetByID(int id)
        {
            return _statusDal.GetById(id);
        }

        public List<Status> TGetList()
        {
            return _statusDal.GetAll();
        }

        public void TUpdate(Status t)
        {
            _statusDal.Update(t);
        }
    }
}
