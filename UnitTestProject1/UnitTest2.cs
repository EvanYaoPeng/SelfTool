using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                PDWeb.LineServiceService p = new PDWeb.LineServiceService();
                string str = "{\"data\": {\"XM\":\"test15\",\"XB\":\"女\",\"NL\":27,\"VIP\":0,\"terminalno\":0,\"phone\":\"11+454\",\"appno\":0,\"floorno\":\"\",\"projects\":[{\"jcks\":\"0002\",\"ksmc\":\"收费处\"},{\"jcks\":\"0003\",\"ksmc\":\"一般检查\"},{\"jcks\":\"0004\",\"ksmc\":\"内科\"},{\"jcks\":\"0005\",\"ksmc\":\"外科\"},{\"jcks\":\"0006\",\"ksmc\":\"眼科\"},{\"jcks\":\"0008\",\"ksmc\":\"耳鼻喉\"},{\"jcks\":\"0010\",\"ksmc\":\"彩超室\"},{\"jcks\":\"0011\",\"ksmc\":\"心电图\"},{\"jcks\":\"0018\",\"ksmc\":\"化验室\"},{\"jcks\":\"0023\",\"ksmc\":\"心超室\"},{\"jcks\":\"0101\",\"ksmc\":\"放射科\"}],\"projectBcs\":[{\"xmdm\":\"040002\",\"xmmc\":\"肝、胆、胰、脾超声检查\"},{\"xmdm\":\"040003\",\"xmmc\":\"双肾超声检查\"},{\"xmdm\":\"040005\",\"xmmc\":\"甲状腺超声检查\"},{\"xmdm\":\"040008\",\"xmmc\":\"妇科超声检查（腹超）\"},{\"xmdm\":\"040010\",\"xmmc\":\"乳房超声检查\"}]},\"studyId\":\"351703223005\"}";
                string s = p.webNotifyMsg(8, 111, str);
                if (string.IsNullOrEmpty(s))
                {
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void TestBMYReport()
        {
            var dt = CRMDate();
            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            { 
                
            }
        }


        public DataTable CRMDate()
        {
            SqlConnection conn = new SqlConnection("Server=172.3.207.22;uid=dengly;pwd=Pass@word;database=RichCRM;");
            var sql = new StringBuilder();
//            sql.Append(@"
// select a.CheckCardNo,a.Status,a.BatchID,a.CheckCardType,a.CreateTime from CRM_CheckCard(nolock) a 
//where
//a.CheckCardType in (select id from CRM_CheckCardType(nolock) where SalesChannel='bmy') and 
// convert(varchar(10),a.CreateTime,112) between '2017-02-01' and '2017-04-21'");
            sql.Append(@" select a.CheckCardNo,a.Status,a.BatchID,a.CheckCardType,a.CreateTime from CRM_CheckCard(nolock) a 
where CheckCardNo in('V10002376455','V10003625642','V10003623150')
");
            var cmd = new SqlCommand(sql.ToString(), conn);
            var adapter = new SqlDataAdapter(cmd);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public DataTable DZDate(string vcardStr)
        {
            SqlConnection conn = new SqlConnection("Server=128.1.10.145;uid=new_Reconciliation;pwd=Pass@word;database=Rich_FinanceCheckSystem");
            var sql = new StringBuilder();
            sql.AppendFormat(@";with studyidlist as(
                                select studyid,cardno from CIS91.HEALTHCIS.DBO.jcxx_code
                                where cardno in({0})
                                ),
                                studyidKJJE as(
                                 select STUDYID,sum(KLJE) sklje,sum(SFJE) sJSJE from FC_JCXX_SFXM 
                                 where JXBZ!=1 and STUDYID in (select studyid from studyidlist)
                                 group by STUDYID
                                )
                                select a.YLJG,a.CKTC,a.NUM3,b.sklje,b.sJSJE,c.cardno from FC_jcxx a
                                left join studyidKJJE b on a.STUDYID=b.STUDYID
                                left join studyidlist c on a.STUDYID=c.STUDYID
                                where a.studyid in (select studyid from studyidlist)", vcardStr);

            var cmd = new SqlCommand(sql.ToString(), conn);
            var adapter = new SqlDataAdapter(cmd);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }

    internal class ProjectBc
    {
        public string xmdm { get; set; }
        public string xmmc { get; set; }
    }
    internal class Project
    {
        public string jcks { get; set; }
        public string ksmc { get; set; }
    }
    internal class Data
    {
        public string XM { get; set; }
        public string XB { get; set; }
        public int NL { get; set; }
        public int VIP { get; set; }
        public int terminalno { get; set; }
        public string phone { get; set; }
        public int appno { get; set; }
        public string floorno { get; set; }
        public IList<Project> projects { get; set; }
        public IList<ProjectBc> projectBcs { get; set; }
    }

    internal class evanpackage
    {
        public Data data { get; set; }
        public string studyId { get; set; }
    }
}
