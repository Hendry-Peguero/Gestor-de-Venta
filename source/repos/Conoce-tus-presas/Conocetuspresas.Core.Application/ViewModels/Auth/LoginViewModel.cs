using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conocetuspresas.Core.Application.ViewModels.Auth
{
    public class LoginViewModel
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool HasError { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
