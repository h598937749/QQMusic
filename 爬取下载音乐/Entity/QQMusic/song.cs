using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 爬取下载音乐.Entity.QQMusic
{
    public class song
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        public string totalnum { get; set; }

        /// <summary>
        /// 歌曲列表
        /// </summary>
        public List<list> list { get; set; }

    }
}
