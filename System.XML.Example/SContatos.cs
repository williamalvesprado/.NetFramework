using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace System.XML.Example

{    public class SContatos
    {
        public string arquivo = @"C:\Aulas\NETFwk\Agenda.xml";
        public XmlDocument xmlDoc = new XmlDocument();
        public XElement xDoc;
        public Contatos contatos;
        public SContatos()
        {
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }
        }
        public Contatos Read()
        {
            xDoc = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xDoc);

            return contatos;
        }
        public void Write(Contatos contatos)
        {
            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);

            xmlReturn.Save(arquivo);
        }
    }

}
