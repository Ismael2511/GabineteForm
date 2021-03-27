using FluentValidation;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Validations
{
    public class RegisterValidation : AbstractValidator<RegisterViewModel>
    {
        private RegisterViewModel _registerViewModel;
        public RegisterValidation(RegisterViewModel registerViewModel)
        {
            _registerViewModel = registerViewModel;
        }
        public List<string> Message()
        {
            List<string> messages = new List<string>();
            if (string.IsNullOrEmpty(_registerViewModel.Nombre.Trim()))
            {
                messages.Add("El nombre del usuario es requerido");
            }
            if (string.IsNullOrEmpty(_registerViewModel.Apellidos.Trim()))
            {
                messages.Add("El apellido del usuario es requerido");
            }
            if (string.IsNullOrEmpty(_registerViewModel.Email.Trim()))
            {
                messages.Add("El email del usuario es requerido");
            }
            if (string.IsNullOrEmpty(_registerViewModel.Username.Trim()))
            {
                messages.Add("El username del usuario es requerido");
            }
            if (string.IsNullOrEmpty(_registerViewModel.Password.Trim()))
            {
                messages.Add("El password del usuario es requerido");
            }
            return messages;
        }

    }
}
