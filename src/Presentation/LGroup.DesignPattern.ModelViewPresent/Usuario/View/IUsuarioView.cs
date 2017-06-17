using LGroup.DesignPattern.ModelViewPresent.Usuario.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGroup.DesignPattern.ModelViewPresent.Usuario.View
{
    public interface IUsuarioView
    {
        //Vou carregar o repiter das views com o vm do metodo a baixo
        void CarregarUsuario(List<UsuarioViewModel> vm);
        void RemoverUsuario(UsuarioViewModel vm);
        void AddUsuario(UsuarioViewModel vm);
    }
}
