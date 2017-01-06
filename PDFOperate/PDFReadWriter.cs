//http://www.cnblogs.com/wit13142/p/3690341.html
//
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PDFOperate
{
    public class PDFReadWriter
    {
        /// <summary>
        /// 创建PDF文件
        /// </summary>
        private void CreatePdf()
        {
            string fileName = string.Empty;
            //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.FileName = "我的第一个PDF";
            //dlg.DefaultExt = ".pdf";
            //dlg.Filter = "Text documents (.pdf)|*.pdf";
            //Nullable<bool> result = dlg.ShowDialog();
            //if (result == true)
            //{
            // fileName = dlg.FileName;
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            document.Open();
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph("Hello World");
            document.Add(paragraph);
            document.Close();
            // }//end if          
        }
        /// <summary>
        /// 设置页面大小、作者、标题等相关信息设置
        /// </summary>
        private void CreatePdfSetInfo()
        {
            string fileName = string.Empty;
           
            //设置页面大小
            iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(216f, 716f);
            pageSize.BackgroundColor = new iTextSharp.text.BaseColor(0xFF, 0xFF, 0xDE);
            //设置边界
            Document document = new Document(pageSize, 36f, 72f, 108f, 180f);
            PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            // 添加文档信息
            document.AddTitle("PDFInfo");
            document.AddSubject("Demo of PDFInfo");
            document.AddKeywords("Info, PDF, Demo");
            document.AddCreator("SetPdfInfoDemo");
            document.AddAuthor("Evan");
            document.Open();
            // 添加文档内容
            for (int i = 0; i < 5; i++)
            {
                document.Add(new iTextSharp.text.Paragraph("Hello World! Hello People! " +
        "Hello Sky! Hello Sun! Hello Moon! Hello Stars!"));
            }
            document.Close();
        }
        /// <summary>
        /// 创建多个Pdf新页
        /// </summary>
        private void CreateNewPdfPage()
        {
            string fileName = string.Empty;
            //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.FileName = "创建多个Pdf新页";
            //dlg.DefaultExt = ".pdf";
            //dlg.Filter = "Text documents (.pdf)|*.pdf";
            //Nullable<bool> result = dlg.ShowDialog();
            //if (result == true)
            //{
            //    fileName = dlg.FileName;
            Document document = new Document(PageSize.NOTE);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            document.Open();
            // 第一页
            document.Add(new iTextSharp.text.Paragraph("PDF1, PDF1, PDF1, PDF1, PDF1"));
            document.Add(new iTextSharp.text.Paragraph("PDF1, PDF1, PDF1, PDF1, PDF1"));
            document.Add(new iTextSharp.text.Paragraph("PDF1, PDF1, PDF1, PDF1, PDF1"));
            document.Add(new iTextSharp.text.Paragraph("PDF1, PDF1, PDF1, PDF1, PDF1"));
            // 添加新页面
            document.NewPage();
            // 第二页
            // 添加第二页内容
            document.Add(new iTextSharp.text.Paragraph("PDF2, PDF2, PDF2, PDF2, PDF2"));
            document.Add(new iTextSharp.text.Paragraph("PDF2, PDF2, PDF2, PDF2, PDF2"));
            document.Add(new iTextSharp.text.Paragraph("PDF2, PDF2, PDF2, PDF2, PDF2"));
            document.Add(new iTextSharp.text.Paragraph("PDF2, PDF2, PDF2, PDF2, PDF2"));
            document.Add(new iTextSharp.text.Paragraph("PDF2, PDF2, PDF2, PDF2, PDF2"));
            document.Add(new iTextSharp.text.Paragraph("PDF2, PDF2, PDF2, PDF2, PDF2"));
            // 添加新页面
            document.NewPage();
            // 第三页
            // 添加新内容
            document.Add(new iTextSharp.text.Paragraph("PDF3, PDF3, PDF3, PDF3, PDF3"));
            document.Add(new iTextSharp.text.Paragraph("PDF3, PDF3, PDF3, PDF3, PDF3"));
            document.Add(new iTextSharp.text.Paragraph("PDF3, PDF3, PDF3, PDF3, PDF3"));
            document.Add(new iTextSharp.text.Paragraph("PDF3, PDF3, PDF3, PDF3, PDF3"));
            // 重新开始页面计数
            document.ResetPageCount();
            // 新建一页
            document.NewPage();
            // 第四页
            // 添加第四页内容
            document.Add(new iTextSharp.text.Paragraph("PDF4, PDF4, PDF4, PDF4, PDF4"));
            document.Add(new iTextSharp.text.Paragraph("PDF4, PDF4, PDF4, PDF4, PDF4"));
            document.Add(new iTextSharp.text.Paragraph("PDF4, PDF4, PDF4, PDF4, PDF4"));
            document.Add(new iTextSharp.text.Paragraph("PDF4, PDF4, PDF4, PDF4, PDF4"));
            document.Close();
            // }//end if
        }
        /// <summary>
        /// 生成图片pdf页（pdf中插入图片）
        /// </summary>
        public void ImageDirect()
        {
            string imagePath = AppDomain.CurrentDomain.BaseDirectory + @"Image\1.jpg"; //临时文件路径
            string fileName = string.Empty;
            //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.FileName = "我的第一个PDF";
            //dlg.DefaultExt = ".pdf";
            //dlg.Filter = "Text documents (.pdf)|*.pdf";
            //Nullable<bool> result = dlg.ShowDialog();
            //if (result == true)
            //{
            //    fileName = dlg.FileName;
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            document.Open();
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);
            img.SetAbsolutePosition((PageSize.POSTCARD.Width - img.ScaledWidth) / 2, (PageSize.POSTCARD.Height - img.ScaledHeight) / 2);
            writer.DirectContent.AddImage(img);
            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Foobar Film Festival", new iTextSharp.text.Font(Font.FontFamily.HELVETICA, 22f));
            p.Alignment = Element.ALIGN_CENTER;
            document.Add(p);
            document.Close();
            //}//end if
        }
        public void ReadPdf(string readPath, string writerPath)
        {
            Console.WriteLine("读取PDF文档");
            try
            {
                // 创建一个PdfReader对象
                PdfReader reader = new PdfReader(readPath);//@"C:\Users\renaw\Downloads\dotnetnuke4 高级编程.pdf"
                // 获得文档页数
                int n = reader.NumberOfPages;
                // 获得第一页的大小
                iTextSharp.text.Rectangle psize = reader.GetPageSize(1);
                float width = psize.Width;
                float height = psize.Height;
                // 创建一个文档变量
                Document document = new Document(psize, 50, 50, 50, 50);
                // 创建该文档
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(writerPath, FileMode.Create));//@"C:\Read.pdf"
                // 打开文档
                document.Open();
                // 添加内容
                PdfContentByte cb = writer.DirectContent;
                int i = 0;
                int p = 0;
                Console.WriteLine("一共有 " + n + " 页.");
                while (i < n)
                {
                    document.NewPage();//创建新页
                    p++;
                    i++;
                    PdfImportedPage page1 = writer.GetImportedPage(reader, i);
                    cb.AddTemplate(page1, .5f, 0, 0, .5f, 0, height / 2);
                    Console.WriteLine("处理第 " + i + " 页");
                    if (i < n)
                    {
                        i++;
                        PdfImportedPage page2 = writer.GetImportedPage(reader, i);
                        cb.AddTemplate(page2, .5f, 0, 0, .5f, width / 2, height / 2);
                        Console.WriteLine("处理第 " + i + " 页");
                    }
                    if (i < n)
                    {
                        i++;
                        PdfImportedPage page3 = writer.GetImportedPage(reader, i);
                        cb.AddTemplate(page3, .5f, 0, 0, .5f, 0, 0);
                        Console.WriteLine("处理第 " + i + " 页");
                    }
                    if (i < n)
                    {
                        i++;
                        PdfImportedPage page4 = writer.GetImportedPage(reader, i);
                        cb.AddTemplate(page4, .5f, 0, 0, .5f, width / 2, 0);
                        Console.WriteLine("处理第 " + i + " 页");
                    }
                    cb.SetRGBColorStroke(255, 0, 0);
                    cb.MoveTo(0, height / 2);
                    cb.LineTo(width, height / 2);
                    cb.Stroke();
                    cb.MoveTo(width / 2, height);
                    cb.LineTo(width / 2, 0);
                    cb.Stroke();
                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    cb.BeginText();
                    cb.SetFontAndSize(bf, 14);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "page " + p + " of " + ((n / 4) + (n % 4 > 0 ? 1 : 0)), width / 2, 40, 0);
                    cb.EndText();
                }
                // 关闭文档
                document.Close();
            }
            catch (Exception de)
            {
                Console.Error.WriteLine(de.Message);
                Console.Error.WriteLine(de.StackTrace);
            }
        }
        /// <summary>
        /// 背景添加水印
        /// </summary>
        /// <param name="readPath"></param>
        public void addLayer(string readPath)
        {
            string watermarkedFile = @"C:\Users\renaw\Desktop\123.pdf";
            // Creating watermark on a separate layer
            // Creating iTextSharp.text.pdf.PdfReader object to read the Existing PDF Document
            PdfReader reader1 = new PdfReader(watermarkedFile);
            using (FileStream fs = new FileStream("C:\\Watermarked.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Creating iTextSharp.text.pdf.PdfStamper object to write Data from iTextSharp.text.pdf.PdfReader object to FileStream object
                using (PdfStamper stamper = new PdfStamper(reader1, fs))
                {
                    // Getting total number of pages of the Existing Document
                    int pageCount = reader1.NumberOfPages;

                    // Create New Layer for Watermark
                    PdfLayer layer = new PdfLayer("WatermarkLayer", stamper.Writer);
                    // Loop through each Page
                    for (int i = 1; i <= pageCount; i++)
                    {
                        // Getting the Page Size
                        iTextSharp.text.Rectangle rect = reader1.GetPageSize(i);

                        // Get the ContentByte object
                        PdfContentByte cb = stamper.GetUnderContent(i);

                        // Tell the cb that the next commands should be "bound" to this new layer
                        cb.BeginLayer(layer);
                        cb.SetFontAndSize(BaseFont.CreateFont(
                          BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 50);

                        PdfGState gState = new PdfGState();
                        gState.FillOpacity = 0.25f;
                        cb.SetGState(gState);

                        cb.SetColorFill(BaseColor.BLACK);
                        cb.BeginText();
                        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Evan", rect.Width / 2, rect.Height / 2, 45f);
                        cb.EndText();

                        // Close the layer
                        cb.EndLayer();
                    }
                }
            }
        }

        /// <summary>
        /// 创建表格
        /// </summary>
        public void CreateFirstTable()
        {
            string imagePath = AppDomain.CurrentDomain.BaseDirectory + @"Image\1.pm"; //临时文件路径
            string fileName = string.Empty;
            //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.FileName = "我的第一个PDF";
            //dlg.DefaultExt = ".pdf";
            //dlg.Filter = "Text documents (.pdf)|*.pdf";
            //Nullable<bool> result = dlg.ShowDialog();
            //if (result == true)
            //{
            //    fileName = dlg.FileName;
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(3);
            PdfPCell cell;
            cell = new PdfPCell(new Phrase("Cell with colspan 3"));
            cell.Colspan = 3;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("Cell with rowspan 2"));
            cell.Rowspan = 2;
            table.AddCell(cell);
            table.AddCell("row 1; cell 1");
            table.AddCell("row 1; cell 2");
            table.AddCell("row 2; cell 1");
            table.AddCell("row 2; cell 2");
            document.Add(table);
            document.Close();
            //}//end if
        }

        public string ExtractTextFromPDFPage(string pdfFile, int pageNumber)
        {
            PdfReader reader = new PdfReader(pdfFile);
            string text =string.Empty;
            for (int i = 1; i < reader.NumberOfPages; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, i);
            }           
            try { reader.Close(); }
            catch { }
            text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
            return text;
        }
        public string ReadPdfFile(string pdfName)
        {
            StringBuilder strPdf = new StringBuilder();
            PdfReader reader = new PdfReader(pdfName);
            for (int page =1; page <= reader.NumberOfPages; page++)//reader.NumberOfPages
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string currentText = PdfTextExtractor.GetTextFromPage(reader, page,strategy);

                currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                strPdf.Append(currentText);
            }
            reader.Close();
            return strPdf.ToString();
        }


    }
}
