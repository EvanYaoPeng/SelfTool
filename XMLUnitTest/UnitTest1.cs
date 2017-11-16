using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Data;

namespace XMLUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string sql = "SELECT *from Sheet1$";
            DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.SqlConnFRS, CommandType.Text, sql, null);

            XElement word = new XElement("wordbook");
            foreach (DataRow dr in dt.Rows)
            {
                string aname = dr["F2"].ToString();
                int index = aname.IndexOf(']') + 1;
                word.Add(new XElement("item",
                         new XElement("word", dr["F1"].ToString()),
                         new XElement("trans", index > 1 ? aname.Substring(index, aname.Length - index) : aname),
                         new XElement("phonetic", index > 1 ? aname.Substring(0, index) : ""),
                         new XElement("tags", "")
                         ));
            }

            XElement xElement = new XElement(word);

            CreatXmlTree(xElement);
        }

        public void CreatXmlTree(XElement xElement)
        {

            //需要指定编码格式，否则在读取时会抛：根级别上的数据无效。 第 1 行 位置 1异常
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UTF8Encoding(false);
            settings.Indent = true;
            XmlWriter xw = XmlWriter.Create(@"C:\1234.xml", settings);
            xElement.Save(xw);
            //写入文件
            xw.Flush();
            xw.Close();
        }

        public void TestParallel()
        {

        }
    }
}
