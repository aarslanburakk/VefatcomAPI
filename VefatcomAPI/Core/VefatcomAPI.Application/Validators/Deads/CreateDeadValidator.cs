using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Application.ViewModels.Deads;

namespace VefatcomAPI.Application.Validators.Deads
{
    public class CreateDeadValidator : AbstractValidator<VM_Create_Dead>
   
    {
        public CreateDeadValidator()
        {
            RuleFor(p => p.DeadName).NotEmpty().NotNull().WithMessage("Lütfen vefat adını boş geçmeyiniz..").MaximumLength(20).MinimumLength(2).WithMessage("Lütfen vefat adını 2 ile 20 karakter arası giriniz..");
            RuleFor(p => p.DeadUsername).NotEmpty().NotNull().WithMessage("Lütfen vefat soyadını boş geçmeyiniz.").MaximumLength(20).MinimumLength(2).WithMessage("Lütfen vefat soyadını 2 ile 20 karakter arası giriniz.");
            RuleFor(p => p.DeadAge).NotEmpty().NotEmpty().WithMessage("Lütfen vefat yaşını boş geçmeyiniz.").Must(s => s >= 0).WithMessage("Vefat yaşı negatif olamaz.").Must(s => s < 130).WithMessage("Vefat yaşı 10 dan büyük olamaz.");
            RuleFor(p => p.DeadDate).NotEmpty().NotNull().WithMessage("Lütfen vefat tarihini boş geçmeyiniz.");

        }
    }
}
