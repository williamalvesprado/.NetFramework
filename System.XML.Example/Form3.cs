using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace System.XML.Example
{
    public partial class Form3 : Form
    {
        Contatos contatos = null;
        SContatos contato = new SContatos();
        public Form3()
        {
            InitializeComponent();

        }
        private void BindListBox()
        {

            contatos = contato.Read();
            listBox1.DataSource = contatos.Contato;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BindListBox();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;
            c.Telefone = new List<string>();
            c.Telefone.Add (txtCelular.Text);
            c.Telefone.Add(txtFoneComercial.Text);
            c.Telefone.Add(txtFoneResidencial.Text);
            c.Obs = txtObs.Text;

            contatos.Contato.Add(c);

            contato.Write(contatos);

            this.BindListBox();

        }

        private int NextId()
        {
            int next = 0;
            if (contatos.Contato.Count > 0)

            {
                next = contatos.Contato[contatos.Contato.Count -1 ].Id + 1;
            }
            return next;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex > -1)
            {
                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                contatos.Contato.Remove(c);
                contato.Write(contatos);
                this.BindListBox();
            }
            else
            {
                MessageBox.Show("Nenhum item foi selecionado");
            }


        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
            MessageBox.Show("Nome: " + c.Nome + "\n" + "Telefone: " + c.Telefone +"\n" +  "Obs: " + c.Obs);

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                pnlAlterar.Visible = true;
                pnlIncluir.Visible = false;

                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                txtNome.Text = c.Nome;

                txtCelular.Text = c.Telefone.ElementAt(0);
                txtFoneComercial.Text = c.Telefone.ElementAt(1);
                txtFoneResidencial.Text = c.Telefone.ElementAt(2);

                lblId.Text = c.Id.ToString();
                txtObs.Text = c.Obs;

            }
            else
            {
                MessageBox.Show("Nenhum item foi selecionado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(lblId.Text);
            Contato c = contatos.Contato.Find(p => p.Id == Id);

            c.Nome = txtNome.Text;           
            c.Telefone.Add(txtCelular.Text);
            c.Telefone.Add(txtFoneComercial.Text);
            c.Telefone.Add(txtFoneResidencial.Text);
            c.Obs = txtObs.Text;

            contato.Write(contatos);

            this.BindListBox();

            this.btnCancelar_Click(null, null);

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            pnlAlterar.Visible = false;
            pnlIncluir.Visible = true;

            txtNome.Text = txtCelular.Text = txtObs.Text = lblId.Text = string.Empty;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
