using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RepositoryModel.Validations
{
    public class gabineteValidation
    {
        private GabineteViewModel _model;
        public gabineteValidation(GabineteViewModel model)
        {
            _model = model;
        }
        public List<string> Message()
        {
            List<string> messages = new List<string>();
            /*Regex regexEmail = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            
            if (string.IsNullOrEmpty(_model.nombre.Trim()))
            {
                messages.Add("El nombre es requerido");
            }
            if (string.IsNullOrEmpty(_model.apellido.Trim()))
            {
                messages.Add("El apellido es requerido");
            }
            if (string.IsNullOrEmpty(_model.tipo_documento.Trim()))
            {
                messages.Add("El tipo de documento es requerido");
            }
            if (string.IsNullOrEmpty(_model.numero_documento.Trim()))
            {
                messages.Add("El numero de documento es requerido");
            }
            if (string.IsNullOrEmpty(_model.email.Trim()))
            {
                messages.Add("El Email es requerido");
            }

            Match validarEmail = regexEmail.Match(_model.email.Trim());
            if (!validarEmail.Success)
            {
                messages.Add("El Email es invalido");
            }
            if (string.IsNullOrEmpty(_model.direccion.Trim()))
            {
                messages.Add("La direccion es requerida");
            }
            if (string.IsNullOrEmpty(_model.celular.Trim()))
            {
                messages.Add("El celular es requerido");
            }
            if (string.IsNullOrEmpty(_model.lugar_residencia.Trim()))
            {
                messages.Add("El lugar de residencia es requerido");
            }
            if (string.IsNullOrEmpty(_model.fecha_nacimiento.Trim()))
            {
                messages.Add("La fecha de nacimento es requerida");
            }*/
            if (string.IsNullOrEmpty(_model.nombre_fallecido.Trim()))
            {
                messages.Add("Nombre del Familiar es Requerido");
            }
            if (string.IsNullOrEmpty(_model.num_doc_fallecido.Trim()))
            {
                messages.Add("Numero de Documento es Requerido");
            }
            if (string.IsNullOrEmpty(_model.fecha_fallecimiento.Trim()))
            {
                messages.Add("Fecha de Fallecimiento es Requerido");
            }
            if (string.IsNullOrEmpty(_model.detalles_fallecimiento.Trim()) || _model.detalles_fallecimiento.Length < 150)
            {
                messages.Add("Detalles del Caso es Requerido (Más de 150 Carácteres)");
            }


            return messages;
        }
    }
}
