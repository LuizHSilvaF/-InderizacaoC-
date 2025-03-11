using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRenderizacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Renderizar()
        {
            Label lblQtd = new Label {
                Name = "lblQtd",
                Text = "Quantidade",
                Location = new Point(89, 164),
                Width = 65
            };

            this.Controls.Add(lblQtd);

            TextBox txtQtd = new TextBox {
                Name = "txtQtd",
                Location = new Point(89, 190),
                Width = 100,
            };
            this.Controls.Add(txtQtd);


            Label lblDescricao = new Label {
                Name = "lblDescricao",
                Text = "Descricao",
                Location = new Point(89, 220),
                Width = 65
            };  
            this.Controls.Add(lblDescricao);

            TextBox txtDescricao = new TextBox {
                Name = "txtDescricao",
                Location = new Point(89, 245),
                Width = 100
            };
            this.Controls.Add(txtDescricao);

            Button btnCadastrar = new Button
            {
                Name = "btnCadastrar",
                Text = "Cadastrar",
                Location = new Point(287, 200),
                Size = new Size(135, 80)
            };

            btnCadastrar.Click += (s, e) =>
            {
                String nome = txtNome.Text;
                double preco = Double.Parse(txtPreco.Text);
                int qtd = int.Parse(txtQtd.Text);
                String desc = txtDescricao.Text;

                Produto prod = new Produto(nome, preco, qtd, desc);
                double valorEstoque = prod.calcularEstoque();
                MessageBox.Show($"Produto {nome} cadastrado, valor em estoque: {valorEstoque}");
            };

            this.Controls.Add(btnCadastrar);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            this.Renderizar();
            
            
        }
    }
}
