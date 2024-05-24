using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade010
{
    public partial class Form1 : Form
    {

        private static int lastId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            textBoxID.Clear();
            textBoxProduto.Clear();
            textBoxQuantidade.Clear();
            textBoxPreco.Clear();
            textBoxID.Focus();
        }

        private void obter()
        {

            textBoxID.Text = ListViewProdutos.SelectedItems[0].SubItems[0].Text;
            textBoxProduto.Text = ListViewProdutos.SelectedItems[0].SubItems[1].Text;
            textBoxQuantidade.Text = ListViewProdutos.SelectedItems[0].SubItems[2].Text;
            textBoxPreco.Text = ListViewProdutos.SelectedItems[0].SubItems[3].Text;
        }
            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewProdutos.SelectedItems.Count > 0)
            {
                obter();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBoxProduto.Text == "")
            {
                MessageBox.Show("Produto Não pode ser vazio, por favor preencha o Produto");
                textBoxProduto.Focus();
                return;
            }
            if (textBoxQuantidade.Text == "")
            {
                MessageBox.Show("Quantidade Não pode ser vazio, por favor preencha a Quantidade");
                textBoxQuantidade.Focus();
                return;
            }
            if (textBoxPreco.Text == "")
            {
                MessageBox.Show("Preco Não pode ser vazio, por favor preencha o Preco");
                textBoxPreco.Focus();
                return;
            }

            String[] produtos = new string[4];
            produtos[0] = GenerateId().ToString();
            produtos[1] = textBoxProduto.Text;
            produtos[2] = textBoxQuantidade.Text;
            produtos[3] = textBoxPreco.Text;

            ListViewItem L = new ListViewItem(produtos);
            ListViewProdutos.Items.Add(L);
            limpar();
        }

        private int GenerateId()
        {
            return ++lastId;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ListViewProdutos.Items.RemoveAt(ListViewProdutos.SelectedIndices[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //vamos obter o objeto selecionado e colocar no text.box
            textBoxID.Text = ListViewProdutos.SelectedItems[0].SubItems[0].Text;
            textBoxProduto.Text = ListViewProdutos.SelectedItems[0].SubItems[1].Text;
            textBoxQuantidade.Text = ListViewProdutos.SelectedItems[0].SubItems[2].Text;
            textBoxPreco.Text = ListViewProdutos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
