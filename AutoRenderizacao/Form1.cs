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

            DataGridView listaData = new DataGridView
            {
                Name = "dataGridView1",
                Location = new Point(100, 300),
                Size = new Size(300, 200),
                ColumnCount = 4
            };
            this.Controls.Add(listaData);

            btnCadastrar.Click += (s, e) =>
            {
                String nome = txtNome.Text;
                double preco = Double.Parse(txtPreco.Text);
                int qtd = int.Parse(txtQtd.Text);
                String desc = txtDescricao.Text;


                Produto produto = new Produto(nome, preco, qtd, desc);
                MessageBox.Show($"Produto {nome} cadastrado, valor em estoque: {produto.calcularEstoque()}");

                List<Produto> lista = new List<Produto>();
                lista.Add(produto);

                listaData.Columns[0].Name = "Nome";
                listaData.Columns[1].Name = "Preço";
                listaData.Columns[2].Name = "Quantidade";
                listaData.Columns[3].Name = "Descrição";

                foreach (Produto p in lista)
                {
                    listaData.Rows.Add(p.Nome, p.Preco, p.Quantidade, p.Descricao);
                }
            };

            this.Controls.Add(btnCadastrar);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            this.Renderizar();
            
            
        }
    }
}
