using MVCCoreEcommerce.DataAccessLayer.Abstract;
using MVCCoreEcommerce.DataAccessLayer.Concrete;
using MVCCoreEcommerce.DataAccessLayer.Repository;
using MVCCoreEcommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DataAccessLayer.EntityFramework
{
    public class EfBlogCategoryDal : GenericRepository<BlogCategory>, IBlogCategoryDal
    {
        public EfBlogCategoryDal(Context context) : base(context)
        {
        }
    }
}
