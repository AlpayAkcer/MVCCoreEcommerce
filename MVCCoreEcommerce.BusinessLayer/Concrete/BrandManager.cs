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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void TAdd(Brand t)
        {
            _brandDal.Insert(t);
        }

        public void TDelete(Brand t)
        {
            _brandDal.Delete(t);
        }

        public Brand TGetByID(int id)
        {
            return _brandDal.GetById(id);
        }

        public List<Brand> TGetList()
        {
            return _brandDal.GetAll();
        }

        public void TUpdate(Brand t)
        {
            _brandDal.Update(t);
        }
    }
}
