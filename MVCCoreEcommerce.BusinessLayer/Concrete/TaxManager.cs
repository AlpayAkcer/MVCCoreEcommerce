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
    public class TaxManager : ITaxService
    {
        ITaxDal _taxdal;

        public TaxManager(ITaxDal taxdal)
        {
            _taxdal = taxdal;
        }

        public void TAdd(Tax t)
        {
            _taxdal.Insert(t);
        }

        public void TDelete(Tax t)
        {
            _taxdal.Delete(t);
        }

        public Tax TGetByID(int id)
        {
            return _taxdal.GetById(id);
        }

        public List<Tax> TGetList()
        {
            return _taxdal.GetAll();
        }

        public void TUpdate(Tax t)
        {
            _taxdal.Update(t);
        }
    }
}
