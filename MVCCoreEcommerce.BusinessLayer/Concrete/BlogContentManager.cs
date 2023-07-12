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
    public class BlogContentManager : IBlogContentService
    {
        private readonly IBlogContentDal _blogContentDal;

        public BlogContentManager(IBlogContentDal blogContentDal)
        {
            _blogContentDal = blogContentDal;
        }

        public void TAdd(BlogContent t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(BlogContent t)
        {
            throw new NotImplementedException();
        }

        public BlogContent TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<BlogContent> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(BlogContent t)
        {
            throw new NotImplementedException();
        }
    }
}
