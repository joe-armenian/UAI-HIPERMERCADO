using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class MPPInformes
    {
        public List<BEResumenInformes> LeerXML()
        {
            try
            {
                var consulta = from informe in XElement.Load("ResumenInformes.XML")
                          .Elements("informe")
                               select new BEResumenInformes
                               {
                                   Codigo = Convert.ToInt32(Convert.ToString(informe.Attribute("id").Value).Trim()),
                                   Descripcion = Convert.ToString(informe.Element("descripcion").Value).Trim(),
                                   FechaReferencia = Convert.ToString(informe.Element("fechaReferencia").Value).Trim(),
                                   FacturasEmitidas = Convert.ToInt32(informe.Element("facturasEmitidas").Value),
                                   FacturasAbonadas = Convert.ToInt32(informe.Element("facturasAbonadas").Value),
                                   ProductosEnStock = Convert.ToInt32(informe.Element("productosEnStock").Value),
                                   PymesRegistradas = Convert.ToInt32(informe.Element("pymesRegistradas").Value),
                                   IndividuosRegistrados = Convert.ToInt32(informe.Element("individuosRegistrados").Value),
                                   TotalRecaudado = Convert.ToInt32(informe.Element("totalRecaudado").Value)
                               };

                // Convertimos la consulta a una lista de objetos tipo Informe
                List<BEResumenInformes> LstResumen = consulta.ToList<BEResumenInformes>();
                return LstResumen;

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }


        public void AgregarXML(BEResumenInformes resumen)
        {

            try
            {
                XDocument xmlDoc = XDocument.Load("ResumenInformes.XML");


                // Acceder al nodo "informes" dentro de "resumen"
                xmlDoc.Element("informes").Add(new XElement("informe",
                   
                   new XAttribute ("id",resumen.Codigo),
                   new XElement("descripcion", resumen.Descripcion),
                   new XElement("fechaReferencia", resumen.FechaReferencia),
                   new XElement("facturasEmitidas", resumen.FacturasEmitidas),
                   new XElement("facturasAbonadas", resumen.FacturasAbonadas),
                   new XElement("productosEnStock", resumen.ProductosEnStock),
                   new XElement("pymesRegistradas", resumen.PymesRegistradas),
                   new XElement("individuosRegistrados", resumen.IndividuosRegistrados),
                   new XElement("totalRecaudado", resumen.TotalRecaudado)));

                // Guardar el XML actualizado
                xmlDoc.Save("ResumenInformes.XML");
                LeerXML();
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
        }



        public void BajaXML(BEResumenInformes resumen)
        {
            try
            {
                XDocument doc = XDocument.Load("ResumenInformes.XML");

                var consulta = from documentos in doc.Descendants("informe")
                               where documentos.Attribute("id").Value == resumen.Codigo.ToString()
                               select documentos;

                consulta.Remove();


                doc.Save("ResumenInformes.XML");
                LeerXML();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ModificarXML(BEResumenInformes resumen)
        {
            XDocument doc = XDocument.Load("ResumenInformes.XML");

            var consulta= from documentos in doc.Descendants("informe")
                          where documentos.Attribute("id").Value==resumen.Codigo.ToString()  
                          select documentos;


            foreach (XElement EModificar in consulta)
            {
                EModificar.Element("descripcion").Value=resumen.Descripcion.ToString(); 
                EModificar.Element("fechaReferencia").Value=resumen.FechaReferencia.ToString();
                EModificar.Element("facturasEmitidas").Value = resumen.FacturasEmitidas.ToString();
                EModificar.Element("facturasAbonadas").Value = resumen.FacturasAbonadas.ToString();
                EModificar.Element("productosEnStock").Value = resumen.ProductosEnStock.ToString();
                EModificar.Element("pymesRegistradas").Value = resumen.PymesRegistradas.ToString();
                EModificar.Element("individuosRegistrados").Value = resumen.IndividuosRegistrados.ToString();
                EModificar.Element("totalRecaudado").Value = resumen.TotalRecaudado.ToString();

            }

            doc.Save("ResumenInformes.XML");
            LeerXML();
        }

        public bool BuscarEnXML(BEResumenInformes resumen)
        {
            try
            {
                var consulta =
                    from informes in XElement.Load("ResumenInformes.XML").Elements("informe")
                    where (string)informes.Attribute("codigo") == resumen.Codigo.ToString().Trim()
                    select new BEResumenInformes
                    {
                        Codigo = Convert.ToInt32(Convert.ToString(informes.Attribute("codigo").Value).Trim()),
                        FechaReferencia = Convert.ToString(informes.Element("fechaReferencia").Value).Trim()

                    };

                List<BEResumenInformes> lstResumen = consulta.ToList<BEResumenInformes>();

                if (lstResumen.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex) { throw ex; }
        }




    }
}
