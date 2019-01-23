using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 爬取下载音乐.Entity
{
    /// <summary>
    /// 解析实体类定义
    /// </summary>
    public class UrlsEntity
    {
        /// <summary>
        /// 序号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 解析来源
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 解析地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 解析信息
        /// </summary>
        public string Info { get; set; }

    }
}
