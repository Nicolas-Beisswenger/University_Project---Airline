using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Aerolinea.BaseDeDatos
{
    class Conexion_XML
    {
        public void InformacionContacto_XML()
        {
            Contacto_Form contacto_Form = new Contacto_Form();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\Nicolas Beisswenger\\OneDrive\\Documentos\\ULACIT\\Cuatrimestre 05\\Diseño de Aplicaciones\\Semana 14\\Expo\\Versión Final\\Aerolínea\\Aerolinea\\BaseDeDatos\\Conexion_XML.cs");
            foreach (XmlNode xmlNode_01 in xmlDocument.DocumentElement.ChildNodes)
            {
                string contacto_CorreoElecronico = xmlNode_01.Attributes["correo_electronico"].Value;
                string contacto_NumeroTelefonico = xmlNode_01.Attributes["numero_telefonico"].Value;

                contacto_Form.contacto_XML_CorreoElectronico.Text = contacto_CorreoElecronico;
                contacto_Form.contacto_XML_NumeroTelefonico.Text = contacto_NumeroTelefonico;

                contacto_Form.ShowDialog();
            }
        }
    }
}
