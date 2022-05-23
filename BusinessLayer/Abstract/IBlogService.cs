using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {//Bloğa özel operasyonlar generic service yerine burda tanımlanabilir. Generic service daha genel tanımlamalar için örn: ekleme.
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);

    }
}
