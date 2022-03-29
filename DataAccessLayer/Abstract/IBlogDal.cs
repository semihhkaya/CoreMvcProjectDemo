using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog> //Sadece ilgili entity'ee ait operasyonlar buraya yazılır
    {
        List<Blog> GetListWithCategory();
    }
}
