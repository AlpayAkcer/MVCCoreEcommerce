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
    public class NewsManager : INewsService
    {
        private readonly INewsDal _newsDal;

        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public void TAdd(News t)
        {
            _newsDal.Insert(t);
        }

        public void TDelete(News t)
        {
            _newsDal.Delete(t);
        }

        public News TGetByID(int id)
        {
            return _newsDal.GetById(id);
        }

        public List<News> TGetList()
        {
            return _newsDal.GetAll();
        }

        public void TUpdate(News t)
        {
            _newsDal.Update(t);
        }
    }
}
