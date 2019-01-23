using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 爬取下载音乐.Entity;
using 爬取下载音乐.Entity.QQMusic;

namespace 爬取下载音乐.Helper
{
    /// <summary>
    /// JsonHelper类
    /// </summary>
    public static class JsonHelper
    {
        /// <summary>
        /// 获取配置文件中的音乐解析地址
        /// 返回实体对象集合
        /// </summary>
        /// <returns></returns>
        public static List<UrlsEntity> GetMusicUrlsEntity()
        {
            // 解析实体对象声明
            List<UrlsEntity> urlList = new List<UrlsEntity>();
            // 解析地址配置文件地址
            string strUrlJsonFilePath = AppDomain.CurrentDomain.BaseDirectory + "_config\\UrlsJson.json";
            // 读取解析地址配置文件
            using (StreamReader urlJsonFile = new StreamReader(strUrlJsonFilePath))
            {
                using (JsonTextReader reader = new JsonTextReader(urlJsonFile))
                {
                    JObject jsonObject = (JObject)JToken.ReadFrom(reader);
                    string strUrlJson = jsonObject["data"].ToString();
                    if (!string.IsNullOrEmpty(strUrlJson) == true)
                    {
                        urlList = JsonConvert.DeserializeObject<List<UrlsEntity>>(strUrlJson);
                        if (urlList != null && urlList.Count != 0)
                        {
                            foreach (var urlData in urlList)
                            {
                                // 组成拼接信息，如： 1 【QQ音乐】
                                urlData.Info = " " + urlData.Id + " " + "【" + urlData.Name + "】";
                            }
                        }
                    }
                }
            }

            return urlList;

        }

        /// <summary>
        /// 通过返回的QQ音乐JSon对象返回歌曲列表信息
        /// </summary>
        /// <returns></returns>
        public static List<list> GetQQMusicSongListEntity(string strReturnJson, out string strTotalCount)
        {
            strTotalCount = "0";
            List<list> songList = null;
            if (!string.IsNullOrEmpty(strReturnJson) == true)
            {
                QQMusiceEntity entity = JsonConvert.DeserializeObject<QQMusiceEntity>(strReturnJson);
                if (entity != null)
                {
                    strTotalCount = entity.data.song.totalnum;
                    songList = entity.data.song.list;
                    if (songList != null && songList.Count != 0)
                    {
                        foreach (var song in songList)
                        {
                            song.selOK = "选择";
                        }
                    }
                }
            }
            return songList;
        }

    }

}
