using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class Pdf<T>
    {
        public void CrearPdf(string filePath, List<T> lista)
        {
            try
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();
                foreach (object objeto in lista)
                {
                    doc.Add(new iTextSharp.text.Paragraph(objeto.ToString()));
                    doc.Add(new iTextSharp.text.Paragraph("-----------------------------------------------------------------------------------"));
                }
                doc.Close();              
            }
            catch(Exception e)
            {
                throw e;
            }
        }


    }
}
