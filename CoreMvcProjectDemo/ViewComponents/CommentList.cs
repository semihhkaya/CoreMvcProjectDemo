using CoreMvcProjectDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProjectDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName="Semih"
                },
                new UserComment
                {
                    Id=2,
                    UserName="Kaya"
                },
                new UserComment
                {
                    Id=3,
                    UserName="Deneme"
                }
            };
            return View(commentvalues);
        }
    }
}
