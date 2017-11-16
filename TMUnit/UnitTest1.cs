using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using Top.Api;
using System.Net;
using System.IO;

namespace TMUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("cardId", "V10005588750");
            parameters.Add("cardPwd", "113011");
            parameters.Add("PID", "692855178");
            parameters.Add("timestamp", "2017-09-14 00:15:15");
            parameters.Add("app_key", "23568039");
            parameters.Add("method", "alibaba.alihealth.healtharchive.examination.rich.validate");
            string sign = SignTopRequest(parameters,"ac1927fc618297e557da42257a4a49cc", "md5");
        //http://139.159.33.52:6000/TMService.ashx?
            //    cardId=V10005588750&  FBD3FF75B9F313361592D38A3ED3B0FE
        //        cardPwd=113011&
        //        PID=692855178&
        //        timestamp=2017-10-11+00:18:22&
        //            sign=96C3648FACA87825305062932D64632E&app_key=23568039&method=alibaba.alihealth.healtharchive.examination.rich.validate
            //parameters.Add("timestamp", "2017-10-09 06:19:19");
            //parameters.Add("app_key", "23568039");
            ////parameters.Add("packageId","1601920101");
            //parameters.Add("method", "alibaba.alihealth.healtharchive.examination.rich.getschedules");
            //{'institutionID':'9','timeTo':'2017-11-08','timeFrom':'2017-10-10','packageID':'1300189130'}
            //Dictionary<string, string> parms = new Dictionary<string, string>();
            //parms.Add("institutionID", "9");
            //parms.Add("timeTo", "2017-11-08");
            //parms.Add("timeFrom", "2017-10-10");
            //parms.Add("packageID", "1300189130");// "{'institutionID':'9','timeTo':'2017-11-08','timeFrom':'2017-10-10','packageID':'1300189130'}"
            //string sign = Sign(parameters,FastJSON.JSON.ToJSON(parms), "ac1927fc618297e557da42257a4a49cc", "md5");


            Console.WriteLine(sign + "\r\n");

        }

        [TestMethod]
        public void GetRequeest()
        {
            string str = "http://20.0.0.27:6010/TMService.ashx?PID=692855178&app_key=23568039&cardId=V10005588750&cardPwd=113011&method=alibaba.alihealth.healtharchive.examination.rich.validate&sign=5AC803EFE67D3B618B27F99C24288F6F&timestamp=2017-09-14 00:15:15";
            HttpWebRequest myHttpWebRequest = null;
            myHttpWebRequest = (HttpWebRequest)WebRequest.Create(str);
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
            //byte[] buf = System.Text.Encoding.UTF8.GetBytes(strParm);
            //myHttpWebRequest.ContentLength = buf.Length;
            //Stream rs = myHttpWebRequest.GetRequestStream();
            //rs.Write(buf, 0, buf.Length);
            //rs.Close();

            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    string responseFromServer1 = reader.ReadToEnd();  //返回结果

                }
            }
            response.Close();
        }


        [TestMethod]
        public void Posttest()
        {
            HttpWebRequest myHttpWebRequest = null;
            //myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://172.3.212.24:9000/TmallEticket.ashx");//接口地址
           // myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:28176/TmallEticket.ashx");//接口地址
            //myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:24333/api/Insurance");
            myHttpWebRequest = (HttpWebRequest)WebRequest.Create("https://test.bmyi.cn/api/Insurance");
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
            string paraUrlCoded = "info=[{'CVALIDATE':'2017-11-15','SERENDDATE':'2017-11-15','CONTNO':'8828901070386128','SERCVALIDATE':'2017-11-15','SERVICEITEM':'视频咨询,门诊预约及名医诊疗服务,住院安排','PHONE':'15012770099','INSUREDNAME':'梅飞1','IDNO':'340881198503045312'}]";
            byte[] buf = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            myHttpWebRequest.ContentLength = buf.Length;
            Stream rs = myHttpWebRequest.GetRequestStream();
            rs.Write(buf, 0, buf.Length);
            rs.Close();

            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    string responseFromServer1 = reader.ReadToEnd();  //返回结果

                }
            }
            response.Close();
        }

        public static string SignTopRequest(IDictionary<string, string> parameters, string secret, string signMethod)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder();
            if (Constants.SIGN_METHOD_MD5.Equals(signMethod))
            {
                query.Append(secret);
            }
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }

            // 第三步：使用MD5/HMAC加密
            byte[] bytes;
            if (Constants.SIGN_METHOD_HMAC.Equals(signMethod))
            {
                HMACMD5 hmac = new HMACMD5(Encoding.UTF8.GetBytes(secret));
                bytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));
            }
            else
            {
                query.Append(secret);
                MD5 md5 = MD5.Create();
                bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));
            }

            // 第四步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }

            return result.ToString();
        }

        private static string Sign(IDictionary<string, string> parameters, string body, string secret, string charset)
        {
            IEnumerator<KeyValuePair<string, string>> em = parameters.GetEnumerator();

            // 第1步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder(secret);
            while (em.MoveNext())
            {
                string key = em.Current.Key;
                if (!Constants.SIGN.Equals(key))
                {
                    string value = em.Current.Value;
                    query.Append(key).Append(value);
                }
            }
            if (body != null)
            {
                query.Append(body);
            }

            query.Append(secret);

            // 第2步：使用MD5加密
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));

            // 第3步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }

            return result.ToString();
        }


        public static string SignTopRequest(IDictionary<string, string> parameters,string body, string secret, string signMethod)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder();
            if (Constants.SIGN_METHOD_MD5.Equals(signMethod))
            {
                query.Append(secret);
            }
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }
            query.Append(body);

            // 第三步：使用MD5/HMAC加密
            byte[] bytes;
            if (Constants.SIGN_METHOD_HMAC.Equals(signMethod))
            {
                HMACMD5 hmac = new HMACMD5(Encoding.UTF8.GetBytes(secret));
                bytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));
            }
            else
            {
                query.Append(secret);
                MD5 md5 = MD5.Create();
                bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));
            }

            // 第四步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }

            return result.ToString();
        }

     
    }
}
