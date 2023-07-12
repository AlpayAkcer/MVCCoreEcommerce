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
    public class SettingManager : ISettingService
    {
        private readonly ISettingDal _settingDal;

        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }

        public void TAdd(Setting t)
        {
            _settingDal.Insert(t);
        }

        public void TDelete(Setting t)
        {
            _settingDal.Delete(t);
        }

        public Setting TGetByID(int id)
        {
            return _settingDal.GetById(id);
        }

        public List<Setting> TGetList()
        {
            return _settingDal.GetAll();
        }

        public void TUpdate(Setting t)
        {
            _settingDal.Update(t);
        }
    }
}
