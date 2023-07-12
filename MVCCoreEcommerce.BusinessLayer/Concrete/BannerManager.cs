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
    public class BannerManager : IBannerService
    {
        private readonly IBannerDal _bannerDal;

        public BannerManager(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public void TAdd(Banner t)
        {
            _bannerDal.Insert(t);
        }

        public void TDelete(Banner t)
        {
            _bannerDal.Delete(t);
        }

        public Banner TGetByID(int id)
        {
            return _bannerDal.GetById(id);
        }

        public List<Banner> TGetList()
        {
            return _bannerDal.GetAll();
        }

        public void TUpdate(Banner t)
        {
            _bannerDal.Update(t);
        }
    }
}
