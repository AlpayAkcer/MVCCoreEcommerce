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
    public class SocialManager : ISocialService
    {
        private readonly ISocialDal _socialDal;

        public SocialManager(ISocialDal socialDal)
        {
            _socialDal = socialDal;
        }

        public void TAdd(Social t)
        {
            _socialDal.Insert(t);
        }

        public void TDelete(Social t)
        {
            _socialDal.Delete(t);
        }

        public Social TGetByID(int id)
        {
            return _socialDal.GetById(id);
        }

        public List<Social> TGetList()
        {
            return _socialDal.GetAll();
        }

        public void TUpdate(Social t)
        {
            _socialDal.Update(t);
        }
    }
}
