using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDFOperate;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class ExcleOpearte
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

        [TestMethod]
        public void ExportDate()
        {
            StringBuilder sql = new StringBuilder();
//            sql.Append(@"select FLOOR(datediff(DY,CSNY,getdate())/365.25) as 年龄, a.jcrq,a.xb,b.* from jcxx a with(nolock) inner join 
//(select studyid,
//max(CASE jcxm WHEN '001001' THEN jgtxt ELSE '' END) AS '身高',
//max(CASE jcxm WHEN '001002' THEN jgtxt ELSE '' END) AS '体重',
//max(CASE jcxm WHEN '001003' THEN jgtxt ELSE '' END) AS 'BMI' ,
//max(CASE jcxm WHEN '001007' THEN jgtxt ELSE '' END) AS '腰围' ,
//max(CASE jcxm WHEN '001004' THEN jgtxt ELSE '' END) AS '收缩压'  ,
//max(CASE jcxm WHEN '001005' THEN jgtxt ELSE '' END) AS '舒张压'  ,
//max(CASE jcxm WHEN '017005' THEN jgtxt ELSE '' END) AS '血清丙氨酸氨基转移酶（ALT）'  ,
//max(CASE jcxm WHEN '017006' THEN jgtxt ELSE '' END) AS '血清天冬氨酸氨基转移酶（AST）'  ,
//max(CASE jcxm WHEN '017009' THEN jgtxt ELSE '' END) AS '血清直接胆红素（DBIL）'  ,
//max(CASE jcxm WHEN '017010' THEN jgtxt ELSE '' END) AS '血清间接胆红素（IBIL）'  ,
//max(CASE jcxm WHEN '017011' THEN jgtxt ELSE '' END) AS '血清碱性磷酸酶（ALP）'  ,
//max(CASE jcxm WHEN '017013' THEN jgtxt ELSE '' END) AS '血清γ-谷氨酰基转移酶（GGT）'  ,
//max(CASE jcxm WHEN '017016' THEN jgtxt ELSE '' END) AS '血清总胆汁酸'  ,
//max(CASE jcxm WHEN '020001' THEN jgtxt ELSE '' END) AS '血清尿素'  ,
//max(CASE jcxm WHEN '100549' THEN jgtxt ELSE '' END) AS '尿肌酐',
//max(CASE jcxm WHEN '020002' THEN jgtxt ELSE '' END) AS '血清肌酐'  ,
//max(CASE jcxm WHEN '020003' THEN jgtxt ELSE '' END) AS '血清尿酸'  ,
//max(CASE jcxm WHEN '020005' THEN jgtxt ELSE '' END) AS '尿微量白蛋白测定（mALB）'  ,
//max(CASE jcxm WHEN '020006' THEN jgtxt ELSE '' END) AS '血清胱抑素C测定'  ,
//max(CASE jcxm WHEN '011001' THEN jgtxt ELSE '' END) AS '空腹血糖',
//max(CASE jcxm WHEN '011002' THEN jgtxt ELSE '' END) AS '餐后血糖(2小时)'  ,
//max(CASE jcxm WHEN '011003' THEN jgtxt ELSE '' END) AS '葡萄糖耐量试验（OGTT）'  ,
//max(CASE jcxm WHEN '011004' THEN jgtxt ELSE '' END) AS '糖化血红蛋白'  ,
//max(CASE jcxm WHEN '011005' THEN jgtxt ELSE '' END) AS '胰岛素检测（INS）'  ,
//max(CASE jcxm WHEN '013002' THEN jgtxt ELSE '' END) AS '甘油三酯',
//max(CASE jcxm WHEN '013001' THEN jgtxt ELSE '' END) AS '总胆固醇'  ,
//max(CASE jcxm WHEN '013003' THEN jgtxt ELSE '' END) AS '高密度脂蛋白胆固醇（HDL-C）'  ,
//max(CASE jcxm WHEN '013004' THEN jgtxt ELSE '' END) AS '低密度脂蛋白胆固醇（LDL-C）'  ,
//max(CASE jcxm WHEN '013005' THEN jgtxt ELSE '' END) AS '血清载脂蛋白A1测定（ApoA1）'  ,
//max(CASE jcxm WHEN '013006' THEN jgtxt ELSE '' END) AS '血清载脂蛋白B测定（ApoB）'  ,
//max(CASE jcxm WHEN '013007' THEN jgtxt ELSE '' END) AS '血清脂蛋白α测定（LPα）',
//max(CASE jcxm WHEN '013008' THEN jgtxt ELSE '' END) AS '血清载脂蛋白A1测定/血清载脂蛋白B测定'  ,
//max(CASE jcxm WHEN '021002' THEN jgtxt ELSE '' END) AS 'C反应蛋白CRP'  ,
//max(CASE jcxm WHEN '022025' THEN jgtxt ELSE '' END) AS '血皮质醇测定（CORT）'  ,
//max(CASE jcxm WHEN '022026' THEN jgtxt ELSE '' END) AS '促肾上腺皮质激素测定（ACTH）'  ,
//max(CASE jcxm WHEN '013009' THEN jgtxt ELSE '' END) AS '动脉硬化指数',
//(max(CASE jcxm WHEN '040001' THEN jgtxt ELSE '' END)+max(CASE jcxm WHEN '040002' THEN jgtxt ELSE '' END)
//+max(CASE jcxm WHEN '040012' THEN jgtxt ELSE '' END)+max(CASE jcxm WHEN '040013' THEN jgtxt ELSE '' END) )
//AS '超声'
// from JCXX_JCXM with(nolock) group by studyid) b  
// on a.studyid=b.studyid
//");
            sql.Append("select top 500 STUDYID,klje,SFJE,CKTC from jcxx_SFXM ");
            string strConnection = "Server=128.1.10.80;uid=dkh;pwd=Rich@903;database=HealthCIS";
            ExportExcle(sql.ToString(), strConnection, "100002", "报表.xls");
        }


        public void ExportExcle(string sql, string strConnection, string logincode, string file)
        {
            int rowsPerSheet = 100;
            DataTable ResultsData = new DataTable();
            string fileName = @"D:\ExcleLSFiles\" + logincode + DateTime.Now.ToString("yyyyMMddhhssmm") + ".xlsx";

            using (var connection = new SqlConnection(strConnection))
            {
                var command = new SqlCommand(sql, connection);
                command.CommandTimeout = 60 * 30 * 30 * 7;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int c = 0;
                bool firstTime = true;

                //Get the Columns names, types, this will help when we need to format the cells in the excel sheet.
                DataTable dtSchema = reader.GetSchemaTable();
                var listCols = new List<DataColumn>();
                if (dtSchema != null)
                {
                    foreach (DataRow drow in dtSchema.Rows)
                    {
                        string columnName = Convert.ToString(drow["ColumnName"]);
                        var column = new DataColumn(columnName, (Type)(drow["DataType"]));
                        column.Unique = (bool)drow["IsUnique"];
                        column.AllowDBNull = (bool)drow["AllowDBNull"];
                        column.AutoIncrement = (bool)drow["IsAutoIncrement"];
                        listCols.Add(column);
                        ResultsData.Columns.Add(column);
                    }
                }

                // Call Read before accessing data. 
                while (reader.Read())
                {
                    DataRow dataRow = ResultsData.NewRow();
                    for (int i = 0; i < listCols.Count; i++)
                    {
                        dataRow[(listCols[i])] = reader[i];
                    }
                    ResultsData.Rows.Add(dataRow);
                    c++;
                    if (c == rowsPerSheet)
                    {
                        c = 0;
                        EnumSugarExtenions.ExportToOxml(ResultsData, firstTime, fileName);
                        ResultsData.Clear();
                        firstTime = false;
                    }
                }
                if (ResultsData.Rows.Count > 0)
                {
                    EnumSugarExtenions.ExportToOxml(ResultsData, firstTime, fileName);
                    ResultsData.Clear();
                }
                // Call Close when done reading.
                reader.Close();
            }

            //HttpResponse response = System.Web.HttpContext.Current.Response;
            //response.Clear();
            //response.Buffer = true;
            //response.Charset = "utf-8";
            //response.AppendHeader("Content-Disposition", "attachment;filename=" + file);
            //response.ContentEncoding = System.Text.Encoding.UTF8;
            //response.ContentType = "application/ms-excel";
            //if (File.Exists(fileName))
            //{

            //    response.WriteFile(fileName);
            //    response.End();

            //    FileInfo fi = new FileInfo(fileName);
            //    File.Delete(fileName);
            //}
            //else
            //{
            //    response.Write("未查询到记录");
            //    response.End();

            //}
        }
    }

    public static class EnumSugarExtenions
    {

        public static void ExportToOxml(DataTable ResultsData, bool firstTime, string filename)
        {
            string fileName = filename;// @"D:\ExcleLSFiles\" + logincode + DateTime.Now.ToString("yyyyMMddhhssmm") + ".xlsx";

            //Delete the file if it exists. 
            if (firstTime && File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            uint sheetId = 1; //Start at the first sheet in the Excel workbook.

            if (firstTime)
            {
                //This is the first time of creating the excel file and the first sheet.
                // Create a spreadsheet document by supplying the filepath.
                // By default, AutoSave = true, Editable = true, and Type = xlsx.
                DocumentFormat.OpenXml.Packaging.SpreadsheetDocument spreadsheetDocument = DocumentFormat.OpenXml.Packaging.SpreadsheetDocument.
                    Create(fileName, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook);

                // Add a WorkbookPart to the document.
                DocumentFormat.OpenXml.Packaging.WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
                workbookpart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                // Add a WorksheetPart to the WorkbookPart.
                var worksheetPart = workbookpart.AddNewPart<DocumentFormat.OpenXml.Packaging.WorksheetPart>();
                var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);


                var bold1 = new DocumentFormat.OpenXml.Spreadsheet.Bold();
                DocumentFormat.OpenXml.Spreadsheet.CellFormat cf = new DocumentFormat.OpenXml.Spreadsheet.CellFormat();


                // Add Sheets to the Workbook.
                DocumentFormat.OpenXml.Spreadsheet.Sheets sheets;
                sheets = spreadsheetDocument.WorkbookPart.Workbook.
                    AppendChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>(new DocumentFormat.OpenXml.Spreadsheet.Sheets());

                AddSheetOperator(ResultsData, sheetId, spreadsheetDocument, worksheetPart, sheetData, sheets);
                //// Append a new worksheet and associate it with the workbook.
                //var sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet()
                //{
                //    Id = spreadsheetDocument.WorkbookPart.
                //        GetIdOfPart(worksheetPart),
                //    SheetId = sheetId,
                //    Name = "Sheet" + sheetId
                //};
                //sheets.Append(sheet);

                ////Add Header Row.
                //var headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                //foreach (DataColumn column in ResultsData.Columns)
                //{
                //    var cell = new DocumentFormat.OpenXml.Spreadsheet.Cell { DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String, CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName) };
                //    headerRow.AppendChild(cell);
                //}
                //sheetData.AppendChild(headerRow);

                //foreach (DataRow row in ResultsData.Rows)
                //{
                //    var newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                //    foreach (DataColumn col in ResultsData.Columns)
                //    {
                //        //var cell = new DocumentFormat.OpenXml.Spreadsheet.Cell {
                //        //    DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String,
                //        //    CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row[col].ToString())
                //        //};

                //        var cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                //        if (row[col].GetType().Name == "DateTime")
                //        {
                //            if (row[col] != null && row[col] != DBNull.Value)
                //            {
                //                cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                //                cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(Convert.ToDateTime(row[col]).ToString("yyyy-MM-dd"));
                //                // cells[rowidx, colidx++].PutValue(Convert.ToDateTime(row[i]).ToString("yyyy-MM-dd"));
                //            }
                //        }
                //        else if (row[col].GetType().Name == "String")
                //        {
                //            cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                //            cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row[col].ToString());
                //            //cells[rowidx, colidx++].PutValue(row[i]);
                //        }
                //        else
                //        {
                //            cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.Number;
                //            cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row[col].ToString());
                //        }
                //        newRow.AppendChild(cell);
                //    }

                //    sheetData.AppendChild(newRow);
                //}
                workbookpart.Workbook.Save();

                spreadsheetDocument.Close();
            }
            else
            {
                // Open the Excel file that we created before, and start to add sheets to it.
                var spreadsheetDocument = DocumentFormat.OpenXml.Packaging.SpreadsheetDocument.Open(fileName, true);

                var workbookpart = spreadsheetDocument.WorkbookPart;
                if (workbookpart.Workbook == null)
                    workbookpart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                var worksheetPart = workbookpart.AddNewPart<DocumentFormat.OpenXml.Packaging.WorksheetPart>();
                var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);
                var sheets = spreadsheetDocument.WorkbookPart.Workbook.Sheets;

                if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Any())
                {
                    //Set the new sheet id
                    sheetId = sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Max(s => s.SheetId.Value) + 1;
                }
                else
                {
                    sheetId = 1;
                }

                AddSheetOperator(ResultsData, sheetId, spreadsheetDocument, worksheetPart, sheetData, sheets);
               
                workbookpart.Workbook.Save();

                // Close the document.
                spreadsheetDocument.Close();
            }
        }

        private static void AddSheetOperator(DataTable ResultsData, uint sheetId, DocumentFormat.OpenXml.Packaging.SpreadsheetDocument spreadsheetDocument, DocumentFormat.OpenXml.Packaging.WorksheetPart worksheetPart, DocumentFormat.OpenXml.Spreadsheet.SheetData sheetData, DocumentFormat.OpenXml.Spreadsheet.Sheets sheets)
        {
            // Append a new worksheet and associate it with the workbook.
            var sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.
                    GetIdOfPart(worksheetPart),
                SheetId = sheetId,
                Name = "Sheet" + sheetId
            };
            sheets.Append(sheet);

            //Add the header row here.
            var headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

            foreach (DataColumn column in ResultsData.Columns)
            {
                var cell = new DocumentFormat.OpenXml.Spreadsheet.Cell
                {
                    DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String,
                    CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName)
                };
                headerRow.AppendChild(cell);
            }
            sheetData.AppendChild(headerRow);

            foreach (DataRow row in ResultsData.Rows)
            {
                var newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                foreach (DataColumn col in ResultsData.Columns)
                {

                    var cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                    if (row[col].GetType().Name == "DateTime")
                    {
                        if (row[col] != null && row[col] != DBNull.Value)
                        {
                            cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                            cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(Convert.ToDateTime(row[col]).ToString("yyyy-MM-dd"));
                        }
                    }
                    else if (row[col].GetType().Name == "String")
                    {
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row[col].ToString());
                    }
                    else
                    {
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.Number;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row[col].ToString());
                    }
                    newRow.AppendChild(cell);
                }

                sheetData.AppendChild(newRow);
            }
        }

    }


    ///// <summary>
    ///// 字段或属性的中文解释属性
    ///// </summary>
    //[Serializable]
    //[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    //public class Desc : Attribute
    //{
    //    /// <summary>
    //    /// 获得字段或属性的中文解释.
    //    /// </summary>
    //    /// <value>字段或属性的中文解释.</value>
    //    public string Value { get; private set; }
    //    /// <summary>
    //    /// 初始化创建一个 <see cref="Desc"/> 类的实例, 用于指示字段或属性的解释说明.
    //    /// </summary>
    //    /// <param name="value">字段或属性的解释说明.</param>
    //    public Desc(string value)
    //    {
    //        Value = value;
    //    }
    //}


}
