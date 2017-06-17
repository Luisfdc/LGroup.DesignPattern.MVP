using LGroup.DesignPattern.ModelViewPresent.Usuario.View;
using LGroup.DesignPattern.ModelViewPresent.Usuario.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGroup.DesignPattern.ModelViewPresent.Usuario.Prensenter
{
    //Esta classe é um controlador
    //Respondavel por liga o model a view
    public class UsuarioPresenter
    {
        private IUsuarioView _view;

        //dados fake
        public static List<UsuarioViewModel> _usuarios;

        public UsuarioPresenter(IUsuarioView view )
        {
            _view = view;

            if (_usuarios == null)
                _usuarios = new List<UsuarioViewModel>();
        }

        public void CarregarUsuarios()
        {
            _view.CarregarUsuario(_usuarios);
        }

        public void RemoverUsuario(UsuarioViewModel user)
        {
            _usuarios.Remove(user);
            _view.CarregarUsuario(_usuarios);
        }

        public void AddUsuario(UsuarioViewModel user)
        {
            _usuarios.Add(user);
            _view.CarregarUsuario(_usuarios);
        }
    }
}
