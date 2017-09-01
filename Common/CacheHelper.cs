using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;

namespace Common
{
    /// <summary>
    /// 缓存Helper
    /// </summary>
    public class CacheHelper
    {
        /// <summary>
        ///     获取数据缓存
        /// </summary>
        /// <param name="cacheKey">键</param>
        public static object GetCache(string cacheKey)
        {
            Cache objCache = HttpRuntime.Cache;
            return objCache.Get(cacheKey);
        }

        /// <summary>
        ///  设置数据缓存
        /// </summary>
        /// <param name="cacheKey">Key值</param>
        /// <param name="objObject">对象</param>
        /// <param name="fileName">文件名</param>
        /// <param name="timeOutHours">过期时间</param>
        public static void SetCache(string cacheKey, object objObject, string fileName = null, int timeOutHours = 2)
        {
            Cache objCache = HttpRuntime.Cache;
            CacheDependency cacheDependency = fileName == string.Empty ? null : new CacheDependency(fileName);
            //objCache.Insert(cacheKey, objObject);
            objCache.Insert(cacheKey, objObject, cacheDependency, Cache.NoAbsoluteExpiration,
                TimeSpan.FromMinutes(timeOutHours));
        }

        /// <summary>
        ///  设置数据缓存
        /// </summary>
        /// <param name="cacheKey">Key值</param>
        /// <param name="objObject">对象</param>
        /// <param name="fileName">文件名</param>
        /// <param name="timeOutHours">过期时间</param>
        public static void SetCache(string cacheKey, object objObject, int timeOutMinute)
        {
            Cache objCache = HttpRuntime.Cache;
            objCache.Insert(cacheKey, objObject, null, Cache.NoAbsoluteExpiration,
                TimeSpan.FromMinutes(timeOutMinute));
        }

        /// <summary>
        /// 设置数据缓存
        /// </summary>
        /// <param name="cacheKey">Key值></param>
        /// <param name="objObject">对象</param>
        /// <param name="Timeout">过期时间</param>
        public static void SetCache(string cacheKey, object objObject, TimeSpan Timeout)
        {
            Cache objCache = HttpRuntime.Cache;
            objCache.Insert(cacheKey, objObject, null, DateTime.MaxValue, Timeout, CacheItemPriority.NotRemovable, null);
        }

        /// <summary>
        ///     设置数据缓存
        /// </summary>
        /// <param name="cacheKey">Key值</param>
        /// <param name="objObject">对象</param>
        /// <param name="absoluteExpiration">绝对过期</param>
        /// <param name="slidingExpiration">滑动过期</param>
        public static void SetCache(string cacheKey, object objObject, DateTime absoluteExpiration,
            TimeSpan slidingExpiration)
        {
            Cache objCache = HttpRuntime.Cache;
            objCache.Insert(cacheKey, objObject, null, absoluteExpiration, slidingExpiration);
        }

        /// <summary>
        ///   移除指定数据缓存
        /// </summary>
        /// <param name="cacheKey">Key值</param>
        public static void RemoveCache(string cacheKey)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Remove(cacheKey);
        }

        /// <summary>
        ///     移除全部缓存
        /// </summary>
        public static void RemoveAllCache()
        {
            Cache cache = HttpRuntime.Cache;
            IDictionaryEnumerator cacheEnum = cache.GetEnumerator();
            while (cacheEnum.MoveNext())
            {
                cache.Remove(cacheEnum.Key.ToString());
            }
        }
    }
}
