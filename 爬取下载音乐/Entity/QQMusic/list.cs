using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 爬取下载音乐.Entity.QQMusic
{
    public class list
    {
        /// <summary>
        /// 媒体ID
        /// </summary>
        public string media_mid { get; set; }

        /// <summary>
        /// 音乐ID
        /// </summary>
        public string songmid { get; set; }

        /// <summary>
        /// 音乐名称
        /// </summary>
        public string songname { get; set; }

        /// <summary>
        /// 选择链接
        /// </summary>
        public string selOK { get; set; }

    }
}
