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
    public class PictureManager : IPictureService
    {
        private readonly IPictureDal _pictureDal;

        public PictureManager(IPictureDal pictureDal)
        {
            _pictureDal = pictureDal;
        }

        public void TAdd(Picture t)
        {
            _pictureDal.Insert(t);
        }

        public void TDelete(Picture t)
        {
            _pictureDal.Delete(t);
        }

        public Picture TGetByID(int id)
        {
            return _pictureDal.GetById(id);
        }

        public List<Picture> TGetList()
        {
            return _pictureDal.GetAll();
        }

        public void TUpdate(Picture t)
        {
            _pictureDal.Update(t);
        }
    }
}
