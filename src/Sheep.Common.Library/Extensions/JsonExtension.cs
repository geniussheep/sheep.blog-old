using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sheep.Common.Library.Extensions
{
    public static class JsonExtension
    {
        /// <summary>
        /// 转换成json字符串
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToJsonString(this object source) => JsonConvert.SerializeObject(source, new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        });

        /// <summary>
        /// 转换成json字符串
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static async Task<string> ToJsonStringAsync(this object source) => await Task.Run(() => JsonConvert.SerializeObject(source));
    }
}
