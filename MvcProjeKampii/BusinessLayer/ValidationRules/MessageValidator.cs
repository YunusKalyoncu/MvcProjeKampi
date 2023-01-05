﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Boş MEsaj atamazsın");
            RuleFor(X => X.ReceiverMail).NotEmpty().WithMessage("Atacağınız Maili Boş Geçemezsiniz");
            
        }
    }
}
