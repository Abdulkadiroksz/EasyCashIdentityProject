using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
    public  class AppUserRegisterDto
    {
        //[Required(ErrorMessage ="ad alanı zorunlu")]
        //[Display(Name ="isim:")]
        //[MaxLength(30,ErrorMessage ="en fazla 30 karakter girebilirisiniz")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfrimPassword { get; set; }




    }
}
