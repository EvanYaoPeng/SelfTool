using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ExcleOperate
{
    public class ExcelHelper
    {
        /// <summary>
        /// 导出Excel 文件
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="fileName"></param>
        public static void ExeclOut(DataTable dt, Dictionary<string, string> titles, string fileName)
        {
            HSSFWorkbook wk = new HSSFWorkbook();
            ISheet sheet = null;

            // 标题样式  
            NPOI.SS.UserModel.ICellStyle cellStyle = wk.CreateCellStyle();
            cellStyle.Alignment = HorizontalAlignment.Center;
            cellStyle.VerticalAlignment = VerticalAlignment.Center;
            cellStyle.BottomBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;
            cellStyle.LeftBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;
            cellStyle.RightBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;
            cellStyle.TopBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;

            if (titles != null && titles.Count > 0)
            {
                int rows = 0;
                if (dt.Rows.Count == 0)
                {
                    sheet = wk.CreateSheet();
                    IRow topRow = sheet.CreateRow(0);
                    int m = 0;
                    foreach (var item in titles)
                    {
                        ICell cell = topRow.CreateCell(m);
                        cell.SetCellValue(item.Value);
                        cell.CellStyle = cellStyle;
                        m++;
                    }
                }
                else
                {
                    //导出信息
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (i % 65535 == 0)
                        {
                            rows = 0;
                            sheet = wk.CreateSheet();
                            IRow topRow = sheet.CreateRow(0);
                            int m = 0;
                            foreach (var item in titles)
                            {
                                ICell cell = topRow.CreateCell(m);
                                cell.SetCellValue(item.Value);
                                cell.CellStyle = cellStyle;
                                m++;
                            }
                        }
                        DataRow dr = dt.Rows[i];
                        rows++;
                        IRow row = sheet.CreateRow(rows);
                        int n = 0;
                        foreach (var item in titles)
                        {
                            row.CreateCell(n).SetCellValue(dr[item.Key].ToString());
                            row.GetCell(n).CellStyle = cellStyle;
                            n++;
                        }
                    }
                }
            }
            else
            {

                int rows = 0;
                ////没有数据的时候，到处表头
                if (dt.Rows.Count == 0)
                {
                    rows = 0;
                    sheet = wk.CreateSheet();
                    IRow topRow = sheet.CreateRow(0);
                    int m = 0;
                    foreach (DataColumn item in dt.Columns)
                    {
                        ICell cell = topRow.CreateCell(m);
                        cell.SetCellValue(item.ColumnName);
                        cell.CellStyle = cellStyle;
                        m++;
                    }
                }
                else
                {
                    //导出信息
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i % 65535 == 0)
                        {
                            rows = 0;
                            sheet = wk.CreateSheet();
                            IRow topRow = sheet.CreateRow(0);
                            int m = 0;
                            foreach (DataColumn item in dt.Columns)
                            {
                                ICell cell = topRow.CreateCell(m);
                                cell.SetCellValue(item.ColumnName);
                                cell.CellStyle = cellStyle;
                                m++;
                            }
                        }
                        DataRow dr = dt.Rows[i];
                        rows++;
                        IRow row = sheet.CreateRow(rows);
                        for (int n = 0; n < dt.Columns.Count; n++)
                        {
                            row.CreateCell(n).SetCellValue(dr[n].ToString());
                            row.GetCell(n).CellStyle = cellStyle;
                        }
                    }
                }
            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            wk.Write(ms);

            System.Web.HttpResponse Response = System.Web.HttpContext.Current.Response;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}.xlsx", HttpUtility.UrlEncode(fileName + DateTime.Now.ToString("yyyyMMddHHmmss"))));
            Response.Clear();
            Response.BinaryWrite(ms.ToArray());
            Response.End();
            ms.Close();
            ms.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="titles"></param>
        /// <param name="fileName"></param>
        /// <param name="path"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static void ExeclOut(DataTable dt, Dictionary<string, string> titles, string fileName, string path, string username, string password, string Area)
        {
            HSSFWorkbook wk = new HSSFWorkbook();
            ISheet sheet = null;

            // 标题样式  
            NPOI.SS.UserModel.ICellStyle cellStyle = wk.CreateCellStyle();
            cellStyle.Alignment = HorizontalAlignment.Center;
            cellStyle.VerticalAlignment = VerticalAlignment.Center;
            cellStyle.BottomBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;
            cellStyle.LeftBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;
            cellStyle.RightBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;
            cellStyle.TopBorderColor = NPOI.HSSF.Util.HSSFColor.Black.Index;

            if (titles != null && titles.Count > 0)
            {
                int rows = 0;
                if (dt.Rows.Count == 0)
                {
                    sheet = wk.CreateSheet();
                    IRow topRow = sheet.CreateRow(0);
                    int m = 0;
                    foreach (var item in titles)
                    {
                        ICell cell = topRow.CreateCell(m);
                        cell.SetCellValue(item.Value);
                        cell.CellStyle = cellStyle;
                        m++;
                    }
                }
                else
                {
                    //导出信息
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (i % 65535 == 0)
                        {
                            rows = 0;
                            sheet = wk.CreateSheet();
                            IRow topRow = sheet.CreateRow(0);
                            int m = 0;
                            foreach (var item in titles)
                            {
                                ICell cell = topRow.CreateCell(m);
                                cell.SetCellValue(item.Value);
                                cell.CellStyle = cellStyle;
                                m++;
                            }
                        }
                        DataRow dr = dt.Rows[i];
                        rows++;
                        IRow row = sheet.CreateRow(rows);
                        int n = 0;
                        foreach (var item in titles)
                        {
                            row.CreateCell(n).SetCellValue(dr[item.Key].ToString());
                            row.GetCell(n).CellStyle = cellStyle;
                            n++;
                        }
                    }
                }
            }
            else
            {

                int rows = 0;
                ////没有数据的时候，到处表头
                if (dt.Rows.Count == 0)
                {
                    rows = 0;
                    sheet = wk.CreateSheet();
                    IRow topRow = sheet.CreateRow(0);
                    int m = 0;
                    foreach (DataColumn item in dt.Columns)
                    {
                        ICell cell = topRow.CreateCell(m);
                        cell.SetCellValue(item.ColumnName);
                        cell.CellStyle = cellStyle;
                        m++;
                    }
                }
                else
                {
                    //导出信息
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i % 65535 == 0)
                        {
                            rows = 0;
                            sheet = wk.CreateSheet();
                            IRow topRow = sheet.CreateRow(0);
                            int m = 0;
                            foreach (DataColumn item in dt.Columns)
                            {
                                ICell cell = topRow.CreateCell(m);
                                cell.SetCellValue(item.ColumnName);
                                cell.CellStyle = cellStyle;
                                m++;
                            }
                        }
                        DataRow dr = dt.Rows[i];
                        rows++;
                        IRow row = sheet.CreateRow(rows);
                        for (int n = 0; n < dt.Columns.Count; n++)
                        {
                            row.CreateCell(n).SetCellValue(dr[n].ToString());
                            row.GetCell(n).CellStyle = cellStyle;
                        }
                    }
                }
            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            wk.Write(ms);

            //Process.Start("cmd.exe", @"/k Net Use * " + path + " " + password + @" /user:" + username);

            Connect(path, username, password);

            FileStream fs = new FileStream(path + "\\" + Area + "\\" + fileName, FileMode.OpenOrCreate);
            BinaryWriter w = new BinaryWriter(fs);
            w.Write(ms.ToArray());
            fs.Close();

            ms.Close();

        }

        /// <summary>
        /// 将excel中的数据导入到DataTable中
        /// </summary>
        /// <param name="sheetName">excel工作薄sheet的名称</param>
        /// <param name="isFirstRowColumn">第一行是否是DataTable的列名</param>
        /// <returns>返回的DataTable</returns>
        public static DataTable ExcelToDataTable(string sheetName, bool isFirstRowColumn, System.IO.Stream stream)
        {
            ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            try
            {
                IWorkbook wb = new HSSFWorkbook(stream);

                if (!String.IsNullOrEmpty(sheetName))
                {
                    sheet = wb.GetSheet(sheetName);
                }
                else
                {
                    sheet = wb.GetSheetAt(0);
                }
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            DataColumn column = new DataColumn(firstRow.GetCell(i).StringCellValue);
                            data.Columns.Add(column);
                        }
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        startRow = sheet.FirstRowNum;
                    }

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　

                        DataRow dataRow = data.NewRow();
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                                dataRow[j] = row.GetCell(j).ToString();
                        }
                        data.Rows.Add(dataRow);
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }

        public static DataTable ExcelToDataTable(string sheetName, bool isFirstRowColumn, System.IO.Stream stream, int columnCount)
        {
            ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            try
            {
                IWorkbook wb = new HSSFWorkbook(stream);

                if (!String.IsNullOrEmpty(sheetName))
                {
                    sheet = wb.GetSheet(sheetName);
                }
                else
                {
                    sheet = wb.GetSheetAt(0);
                }
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = columnCount; //一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            DataColumn column = new DataColumn(firstRow.GetCell(i).StringCellValue);
                            data.Columns.Add(column);
                        }
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        startRow = sheet.FirstRowNum;
                    }

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　

                        DataRow dataRow = data.NewRow();
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                                dataRow[j] = row.GetCell(j).ToString();
                        }
                        data.Rows.Add(dataRow);
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }

        // 使用方法：
        //if (Connect("192.168.1.48", "用户名", "密码"))   
        //{
        //    File.Copy(@"\\192.168.1.48\共享目录\test.txt",   @"e:\\test.txt",   true);   
        //}
        public static bool Connect(string remoteHost, string userName, string passWord)
        {
            bool Flag = true;
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.CreateNoWindow = true;
            try
            {
                proc.Start();
                string command = @"net  use " + remoteHost + "  " + passWord + "  " + "  /user:" + userName + ">NUL";
                proc.StandardInput.WriteLine(command);
                command = "exit";
                proc.StandardInput.WriteLine(command);
                while (proc.HasExited == false)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                if (errormsg != "")
                    Flag = false;
                proc.StandardError.Close();
            }
            catch (Exception ex)
            {
                Flag = false;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }

    }
}
