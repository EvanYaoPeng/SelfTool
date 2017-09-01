using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


namespace Common
{
    public class CookieHelper
    {
        /// <summary>
        ///  新增Cookies
        /// </summary>
        /// <param name="Response">Response</param>
        /// <param name="Cookieskey">Cookieskey</param>
        /// <param name="Value">Value</param>
        /// <param name="minutes">失效的分钟</param>
        public static void AddCookies(HttpResponseBase Response, string Cookieskey, string Value, int minutes)
        {
            Response.Cookies[Cookieskey].Value = Value;
            Response.Cookies[Cookieskey].Expires = DateTime.Now.AddMinutes(minutes);
        }

        public static void AddCookies(string Cookieskey, string Value, int minutes)
        {
            HttpContext.Current.Response.Cookies[Cookieskey].Value = Value;
            HttpContext.Current.Response.Cookies[Cookieskey].Expires = DateTime.Now.AddMinutes(minutes);
        }

        /// <summary>
        ///  根据Key获取值
        /// </summary>
        /// <param name="Request"></param>
        /// <param name="Cookieskey"></param>
        /// <returns></returns>
        public static string GetValueByCookieskey(HttpRequestBase Request, string Cookieskey)
        {
            string cookiesValue = string.Empty;
            if (Request.Cookies[Cookieskey] != null)
            {
                cookiesValue = Request.Cookies[Cookieskey].Value;
            }
            return cookiesValue;
        }

        /// <summary>
        ///  根据Key获取值
        /// </summary>
        /// <param name="Request"></param>
        /// <param name="Cookieskey"></param>
        /// <returns></returns>
        public static string GetValueByCookieskey(string Cookieskey)
        {
            string cookiesValue = string.Empty;
            if (HttpContext.Current.Request.Cookies[Cookieskey] != null)
            {
                cookiesValue = HttpContext.Current.Request.Cookies[Cookieskey].Value;
            }
            return cookiesValue;
        }

        /// <summary>
        ///  删除Cookies
        /// </summary>
        /// <param name="Request">Request</param>
        /// <param name="Response">Response</param>
        /// <param name="Cookieskey">Cookieskey</param>
        public static void RemoveCookiesByCookieskey(HttpRequestBase Request, HttpResponseBase Response, string Cookieskey)
        {
            HttpCookie cookies = Request.Cookies[Cookieskey];
            if (cookies != null)
            {
                cookies.Expires = DateTime.Today.AddDays(-1);
                Response.Cookies.Add(cookies);
            }
        }

        /// <summary>
        ///  删除Cookies
        /// </summary>
        /// <param name="Request">Request</param>
        /// <param name="Response">Response</param>
        /// <param name="Cookieskey">Cookieskey</param>
        public static void RemoveCookiesByCookieskey(string Cookieskey)
        {
            HttpCookie cookies = HttpContext.Current.Request.Cookies[Cookieskey];
            if (cookies != null)
            {
                cookies.Expires = DateTime.Today.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(cookies);
            }
        }
    }
}
