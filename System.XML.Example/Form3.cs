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
        string arquivo = @"C:\Aulas\NETFwk\Agenda.xml";
        XmlDocument xmlDoc = new XmlDocument();
        /*XElement xDoc;*/
        /*Contatos contatos;*/



        public Form3()
        {
            InitializeComponent();
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }
            ReadAgenda();
        }

        private void ReadAgenda()
        {
            //Deserializer
            XElement xDoc = XElement.Load(arquivo);
            Contatos contatos = Serializer.Deserialize<Contatos>(xDoc);
            lblContatos.Text = string.Empty;

            foreach (Contato c in contatos.Contato)
            {
                lblContatos.Text += "Nome: " + c.Nome + "\nTelefone: " + c.Telefone + "\n\n";
            }

            //Serializer
            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;
            txtNome.Text = "";
            txtTelefone.Text = "";
        }
    }
}
