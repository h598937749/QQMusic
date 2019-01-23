using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 爬取下载音乐.Entity;
using 爬取下载音乐.Entity.QQMusic;
using 爬取下载音乐.Helper;

namespace 爬取下载音乐
{
    public partial class MainForm : Form
    {
        #region 分页变量声明
        /// <summary>
        /// 当前分页序号
        /// </summary>
        private int iPageIndex;

        /// <summary>
        /// 分页数量
        /// </summary>
        private int iPageNum;

        /// <summary>
        /// 每页显示数量
        /// </summary>
        private int iPageCount;

        /// <summary>
        /// 总记录数
        /// </summary>
        private int iTotalCount;

        #endregion
        #region 其他变量声明
        /// <summary>
        /// 解析地址
        /// </summary>
        private string strUrl;

        /// <summary>
        /// 查询关键字
        /// </summary>
        private string strKeyWord;

        /// <summary>
        /// 是否首次查询
        /// </summary>
        private bool IsFirstSearch;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitData();
            BindUrlCMB();
        }

        /// <summary>
        /// 解析搜索并返回列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!Valid() == true)
            {
                return;
            }

            strUrl = cmbUrlList.SelectedValue.ToString();
            strKeyWord = tbKeyWord.Text.Trim();
            BeginQuery(strUrl, strKeyWord);
            FYControl();

        }

        /// <summary>
        /// 解锁查询因素并重置局部变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认解锁吗？\n解锁会重置查询因素。", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                cmbUrlList.Enabled = true;
                tbKeyWord.Enabled = true;
                cmbPageNum.Enabled = true;

                InitData();
            }

        }

        /// <summary>
        /// 选择下载目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseDownloadFold_Click(object sender, EventArgs e)
        {
            // 打开选择文件夹对话框，点击确认后
            if (fldDownload.ShowDialog() == DialogResult.OK)
            {
                string strFileFolderName = fldDownload.SelectedPath;
                tbDownloadFoldPath.Text = strFileFolderName;
            }
        }

        /// <summary>
        /// 下载按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            // 1、选择目标文件夹校验
            if (string.IsNullOrEmpty(tbDownloadFoldPath.Text) == true)
            {
                MessageBox.Show("请选择下载目录！");
                return;
            }
            // 2、待下载列表非空校验
            if (selectGrid.Rows.Count == 0)
            {
                MessageBox.Show("请先选择需要下载的歌曲！");
                return;
            }

            if (MessageBox.Show("即将进入下载，下载过程中请勿关闭程序！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow row in selectGrid.Rows)
                    {
                        DownloadFile(row);
                    }
                    lblDownloadInfo.Text = "";
                    MessageBox.Show("全部下载完毕，请打开下载目录查看！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 查询列表“选择”事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SongGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 3)
            {
                var row = SongGrid.Rows[e.RowIndex];
                string strMid = row.Cells[0].Value.ToString();
                string strSongId = row.Cells[1].Value.ToString();
                string strName = row.Cells[2].Value.ToString();

                if (selectGrid.Rows.Count == 10)
                {
                    MessageBox.Show("为保证传输效率，每次只能选择10条记录！");
                    return;
                }
                if (IsSelected(strMid) == true)
                {
                    MessageBox.Show("不能重复选择！");
                    return;
                }
                else
                {
                    int iRowIndex = selectGrid.Rows.Add();
                    selectGrid.Rows[iRowIndex].Cells[0].Value = strMid;
                    selectGrid.Rows[iRowIndex].Cells[1].Value = strSongId;
                    selectGrid.Rows[iRowIndex].Cells[2].Value = strName;
                    selectGrid.Rows[iRowIndex].Cells[3].Value = "移除";
                }
            }
        }

        /// <summary>
        /// 已选列表“移除”事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 3)
            {
                var row = selectGrid.Rows[e.RowIndex];
                selectGrid.Rows.Remove(row);
            }
        }

        #region 分页事件
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (!Valid() == true)
            {
                return;
            }

            iPageIndex = 1;
            BeginQuery(strUrl, strKeyWord);
            FYControl();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (!Valid() == true)
            {
                return;
            }

            iPageIndex = iPageIndex - 1;
            BeginQuery(strUrl, strKeyWord);
            FYControl();
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!Valid() == true)
            {
                return;
            }

            iPageIndex = iPageIndex + 1;
            BeginQuery(strUrl, strKeyWord);
            FYControl();
        }

        /// <summary>
        /// 末页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (!Valid() == true)
            {
                return;
            }

            iPageIndex = iPageNum;
            BeginQuery(strUrl, strKeyWord);
            FYControl();
        }

        /// <summary>
        /// 设置每页显示数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPageNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            iPageCount = Convert.ToInt32(cmbPageNum.SelectedItem.ToString());
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 初始化局部变量
        /// </summary>
        private void InitData()
        {
            iPageIndex = 1;
            iPageNum = 0;
            iPageCount = 20;
            iTotalCount = 0;

            strUrl = string.Empty;
            strKeyWord = string.Empty;

            IsFirstSearch = true;

            // 分页数量默认显示20
            cmbPageNum.SelectedIndex = 1;
            // 分页信息置空
            lblCurPageInfo.Text = "0 / 0";
            // 总记录数置空
            lblTotalNum.Text = "0";

            // 查询列表取消自动生成列信息
            SongGrid.AutoGenerateColumns = false;
            // 查询列表数据源重置
            SongGrid.DataSource = null;

            // 查询关键字置空
            tbKeyWord.Text = "";

            FYControl();
        }

        /// <summary>
        /// 绑定解析来源信息下拉框
        /// </summary>
        private void BindUrlCMB()
        {
            cmbUrlList.Items.Clear();
            List<UrlsEntity> urlList = JsonHelper.GetMusicUrlsEntity();
            if (urlList != null && urlList.Count != 0)
            {
                cmbUrlList.DataSource = urlList;
                cmbUrlList.ValueMember = "Url";
                cmbUrlList.DisplayMember = "Info";
            }
            else
            {
                MessageBox.Show("请配置解析来源文件！");
            }
        }

        /// <summary>
        /// 分页控制
        /// </summary>
        private void FYControl()
        {
            if (iTotalCount == 0)
            {
                btnFirst.Enabled = false;
                btnPre.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                iPageCount = Convert.ToInt32(cmbPageNum.SelectedItem.ToString());
                iPageNum = (int)Math.Ceiling((double)iTotalCount / (double)iPageCount); //向上取整

                lblCurPageInfo.Text = iPageIndex.ToString() + "/" + iPageNum.ToString();
                lblTotalNum.Text = iTotalCount.ToString();

                btnFirst.Enabled = iPageIndex == 1 ? false : true;
                btnPre.Enabled = iPageIndex > 1 ? true : false;
                btnNext.Enabled = (iPageIndex > 0 && iPageIndex < iPageNum) ? true : false;
                btnLast.Enabled = iPageIndex == iPageNum ? false : true;
            }
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Valid()
        {
            // 1、解析地址校验：
            if (cmbUrlList.Items.Count == 0)
            {
                MessageBox.Show("请配置解析来源文件！");
                return false;
            }
            // 2、关键字非空校验：
            if (string.IsNullOrEmpty(tbKeyWord.Text.Trim()) == true)
            {
                MessageBox.Show("请输入关键字！");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 开始查询
        /// </summary>
        /// <param name="strUrl">解析地址</param>
        /// <param name="strKeyWord">关键字</param>
        private void BeginQuery(string strUrl, string strKeyWord)
        {
            if (string.IsNullOrEmpty(strUrl) == true || string.IsNullOrEmpty(strKeyWord) == true)
            {
                return;
            }

            string strReturnJson = string.Empty;
            try
            {
                // 根据解析地址模拟发送请求
                string strUrlParams = string.Empty;
                strUrlParams += "&w=" + strKeyWord; //关键字
                strUrlParams += "&p=" + iPageIndex.ToString(); //起始页
                strUrlParams += "&n=" + iPageCount.ToString(); //每页数量
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl + strUrlParams);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Headers.Add("charset:utf-8");
                request.Timeout = 300000;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                strReturnJson = reader.ReadToEnd();
                strReturnJson = strReturnJson.Trim(new char[] { 'c', 'a', 'l', 'l', 'b', 'a', 'c', 'k', '(', ')', '[', ']' });
                response.Close();
                request.Abort();

                if (!string.IsNullOrEmpty(strReturnJson))
                {
                    string strTotalCount;
                    List<list> QQSongList = JsonHelper.GetQQMusicSongListEntity(strReturnJson, out strTotalCount);
                    if (QQSongList != null && QQSongList.Count != 0)
                    {
                        SongGrid.DataSource = QQSongList;
                        iTotalCount = Convert.ToInt32(strTotalCount);

                        if (IsFirstSearch == true)
                        {
                            // 锁定查询因素
                            cmbUrlList.Enabled = false;
                            tbKeyWord.Enabled = false;
                            cmbPageNum.Enabled = false;
                            IsFirstSearch = false;

                            MessageBox.Show("查询完毕，查询因素已锁定，如需修改查询因素，请点击解锁按钮！");
                        }
                    }
                    else
                    {
                        SongGrid.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 校验是否已经选择
        /// </summary>
        /// <returns></returns>
        private bool IsSelected(string strMid)
        {
            if (selectGrid.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in selectGrid.Rows)
                {
                    if (row.Cells[1].Value.ToString() == strMid)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="row">当前处理行</param>
        /// <returns></returns>
        private void DownloadFile(DataGridViewRow row)
        {
            string strMid = "C400" + row.Cells[0].Value.ToString() + ".m4a";
            string strSongMid = row.Cells[1].Value.ToString();
            string strSongName = row.Cells[2].Value.ToString();

            string strDownloadUrl = string.Empty;
            if (string.IsNullOrEmpty(strMid) == true || string.IsNullOrEmpty(strSongMid) == true)
            {
                return;
            }

            // 根据解析地址模拟发送请求：获得vkey
            string strGetVKeyUrl = "https://c.y.qq.com/base/fcgi-bin/fcg_music_express_mobile3.fcg?&jsonpCallback=MusicJsonCallback&cid=205361747&guid=6612300644";
            string strUrlParams = string.Empty;
            strUrlParams += "&filename=" + strMid; //媒体文件
            strUrlParams += "&songmid=" + strSongMid; //歌曲ID
            strGetVKeyUrl += strUrlParams;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strGetVKeyUrl);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers.Add("charset:utf-8");
            request.Timeout = 300000;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
            string strVKeyJson = reader.ReadToEnd();
            response.Close();
            request.Abort();

            JObject jObject = JsonConvert.DeserializeObject<JObject>(strVKeyJson);
            string strVKey = jObject["data"]["items"][0]["vkey"].ToString();
            strDownloadUrl = "http://dl.stream.qqmusic.qq.com/" + strMid + "?vkey=" + strVKey + "&guid=6612300644&uin=0&fromtag=66";

            // 执行下载动作并保存下载文件
            DoDownloadFile(row.Index, strDownloadUrl, strSongName);
        }

        /// <summary>        
        /// c#,.net 下载文件        
        /// </summary>        
        /// <param name="strDownloadUrl">下载文件地址</param>
        /// <param name="strSongName">歌曲名称</param>
        public void DoDownloadFile(int iRowIndex, string strDownloadUrl, string strSongName)
        {
            // 下载后的存放地址（带完整路径的文件名）
            string strFullFileName = tbDownloadFoldPath.Text + "\\" + strSongName + ".m4a";
            HttpWebRequest Myrq = (HttpWebRequest)WebRequest.Create(strDownloadUrl);
            HttpWebResponse myrp = (HttpWebResponse)Myrq.GetResponse();

            float percent = 0;
            long totalDownloadedByte = 0;
            long totalBytes = myrp.ContentLength;

            using (Stream st = myrp.GetResponseStream())
            {
                using (Stream so = new FileStream(strFullFileName, FileMode.Create))
                {
                    byte[] by = new byte[1024];
                    int osize = st.Read(by, 0, (int)by.Length);
                    while (osize > 0)
                    {
                        totalDownloadedByte = osize + totalDownloadedByte;
                        so.Write(by, 0, osize);
                        osize = st.Read(by, 0, (int)by.Length);
                        // 下载进度
                        percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                        lblDownloadInfo.Text = "当前下载文件为：" + strSongName + "，下载进度为：" + percent.ToString() + "%";
                        Application.DoEvents();
                    }
                    lblDownloadInfo.Text = "当前下载文件为：" + strSongName + "，下载进度为：100%   完成！";
                }
            }

            myrp.Close();
            Myrq.Abort();
        }

        #endregion

    }
}
