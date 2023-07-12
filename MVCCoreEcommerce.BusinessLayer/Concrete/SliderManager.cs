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
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider t)
        {
            _sliderDal.Insert(t);
        }

        public void TDelete(Slider t)
        {
            _sliderDal.Delete(t);
        }

        public Slider TGetByID(int id)
        {
            return _sliderDal.GetById(id);
        }

        public List<Slider> TGetList()
        {
            return _sliderDal.GetAll();
        }

        public void TUpdate(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
