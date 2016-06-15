using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDFOperate;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PDFReadWriter pdf = new PDFReadWriter();
            string str = pdf.ReadPdfFile(@"C:\Users\renaw\Desktop\创建多个Pdf新页.pdf");
            if (!string.IsNullOrEmpty(str))
            { 
                
            }
        }
    }
}
