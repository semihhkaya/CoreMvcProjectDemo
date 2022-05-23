using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen Başlığınız 150 Karakterden Daha Fazla Olmasın");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen Başlığınız 5 Karakterden Daha Az Olmasın");
        }
    }
}
