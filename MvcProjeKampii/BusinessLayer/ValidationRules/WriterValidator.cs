using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Kullanıcı  Soy Adını Geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Başlık Alanını boş  Geçemezsiniz");
            RuleFor(x => x.WriterMail).MaximumLength(20).WithMessage("Lütfen en fazla 100 karakter girişi yapınız");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkınızda Alanını Boş Geçemezsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Alanını Boş Geçemezsiniz");
        }
    }
}
