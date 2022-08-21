using Examen.Models.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Models.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            InputModel = new LoginInputModel();
        }

        public LoginInputModel InputModel { get; set; }

        public string SiteKey { get; set; }

        public string Recaptcha { get; set; }
    }
}
