using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime sysAllDtNew = DateTime.Now.AddDays(-1);
            DateTime sysAllDtNew2 = DateTime.Now.AddDays(-2);
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(@";with yznosfxm as(SELECT transcode,frontaccount from 
                                (SELECT transcode,frontaccount from FC_JCXX_CWMX a
                                where  businessdate in({0}) and frontaccount is not null 
                                ) a
                                LEFT JOIN FC_JCXX_SFXM b on a.frontaccount=b.studyid and a.transcode=b.sfxm 
                                where b.id is null
                                )
                                INSERT INTO FC_JCXX_SFXM
		                                (
			                                ID,YLJG,STUDYID,SFXM,SFBZ,KLJE,SFJE,SFRQ,ZFRQ,SFRY,ZFPB,ZFRY,FPHM,SFJG,WCBZ,
			                                JCKS,JCRQ,CYBZ,CYRY,CYRQ,CKTC,HSRQ,HSRY,ZKL,ZKRY,ZKRQ,DJRQ,DJJG,JCRY,
			                                YSZKL,JXBZ,SFFS,XMSX,SQRY,SFSL,VCRTTIME,VCRTUSER,VMDFTIME,VMDFUSER	
		                                )
                                select a.ID,a.YLJG,a.STUDYID,a.SFXM,a.SFBZ,a.KLJE,a.SFJE,a.SFRQ,a.ZFRQ,a.SFRY,a.ZFPB,a.ZFRY,a.FPHM,a.SFJG,a.WCBZ,
			                                a.JCKS,a.JCRQ,a.CYBZ,a.CYRY,a.CYRQ,a.CKTC,a.HSRQ,a.HSRY,a.ZKL,a.ZKRY,a.ZKRQ,a.DJRQ,a.DJJG,a.JCRY,
			                                a.YSZKL,a.JXBZ,a.SFFS,a.XMSX,a.SQRY,a.SFSL,GETDATE() AS VCRTTIME,'sysadmin' AS VCRTUSER,NULL AS VMDFTIME,NULL AS VMDFUSER
                                from   CIS91.HealthCis.[dbo].[JCXX_SFXM] a
                                where a.STUDYID in(select frontaccount from yznosfxm b WHERE a.SFXM=b.TransCode)", string.Format("'{0}','{1}'",sysAllDtNew.ToString("yyyy-MM-dd"), sysAllDtNew2.ToString("yyyy-MM-dd")));
            string strr = sql.ToString();
            if(strr!=null)
            {

            }
        }
    }
}
