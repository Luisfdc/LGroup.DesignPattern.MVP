using LGroup.DesignPattern.ModelViewPresent.Usuario.Prensenter;
using LGroup.DesignPattern.ModelViewPresent.Usuario.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LGroup.DesignPattern.ModelViewPresent.Usuario.ViewModel;

namespace WindowsForms
{
    public partial class Form1 : Form, IUsuarioView
    {
        private UsuarioPresenter _presenter;
    
        public Form1()
        {
            InitializeComponent();

            _presenter = new UsuarioPresenter(this);
            _presenter.CarregarUsuarios();
        }

        public void AddUsuario(UsuarioViewModel vm)
        {
            _presenter.AddUsuario(vm);
        }

        public void CarregarUsuario(List<UsuarioViewModel> vm)
        {
            dgvUsuarios.DataSource = vm;
            dgvUsuarios.Refresh();
        }

        public void RemoverUsuario(UsuarioViewModel vm)
        {
            throw new NotImplementedException();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
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
    }
}
