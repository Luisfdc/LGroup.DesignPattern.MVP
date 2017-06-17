using LGroup.DesignPattern.ModelViewPresent.Usuario.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LGroup.DesignPattern.ModelViewPresent.Usuario.ViewModel;
using LGroup.DesignPattern.ModelViewPresent.Usuario.Prensenter;

namespace LGroup.DesignPattern.WebForms
{
    public partial class CadastroUsuario : System.Web.UI.Page, IUsuarioView
    {
        private UsuarioPresenter _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new UsuarioPresenter(this);
            _presenter.CarregarUsuarios();
        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            //Se eu colocar toda a minha regra aqui/
            //de adicionar usuario, terei problena se caso for reutilizar no windows forms
            var usuario = new UsuarioViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Nome = txtNome.Text,
                Email = txtEmail.Text
            };
            AddUsuario(usuario);
            _presenter.CarregarUsuarios();
        }


        public void CarregarUsuario(List<UsuarioViewModel> vm)
        {
            rptUsuarios.DataSource = vm;
            rptUsuarios.DataBind();
        }

        public void RemoverUsuario(UsuarioViewModel vm)
        {
            throw new NotImplementedException();
        }

        public void AddUsuario(UsuarioViewModel vm)
        {
            _presenter.AddUsuario(vm);
        }
    }
}