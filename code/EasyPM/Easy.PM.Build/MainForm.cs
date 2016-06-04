using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Easy.PM.Build.Util;

namespace Easy.PM.Build
{
    public partial class MainForm : Form
    {
        private string  _basePath = System.Environment.CurrentDirectory;

        public MainForm()
        {
            InitializeComponent(); 
        }

        private void btnBuildDao_Click(object sender, EventArgs e)
        {
            //读取数据库所有的表名
            var sql = "select table_name from information_schema.tables where table_schema='easypm' and table_type='base table';";
            var ds = MySqlHelper.GetDataSet(MySqlHelper.DBConnectionString,CommandType.Text,sql,null);
            var distDir = _basePath + "\\dist\\Dao";
            IOHelper.DeleteDir( new DirectoryInfo(distDir));
            IOHelper.CreateDir(distDir);
            if (ds!=null && ds.Tables.Count>0) {
                foreach (DataRow row in ds.Tables[0].Rows) {
                    BuildDao(row[0].ToString());
                }
            }
        }

        private void BuildDao(string tableName) {
            try {
                //IDao
                var shortTableName = tableName.Replace("PM_", "");
                var tempPath = _basePath + "\\template\\Dao\\Dao.temp";
                var distPath = _basePath + "\\dist\\Dao\\"+ shortTableName + "Repository.cs";
                var tempText = IOHelper.Read(tempPath);
                var distText = tempText.Replace("<DTO>", tableName).Replace("<DAO>", shortTableName + "Repository");
                IOHelper.Write(distPath, distText);

                //Dao
                tempPath = _basePath + "\\template\\Dao\\IDao.temp";
                distPath = _basePath + "\\dist\\Dao\\I" + shortTableName + "Repository.cs";
                tempText = IOHelper.Read(tempPath);
                distText = tempText.Replace("<DTO>", tableName).Replace("<DAO>", shortTableName + "Repository");
                IOHelper.CreateDir(Path.GetDirectoryName(distPath));
                IOHelper.Write(distPath, distText);

                MessageBox.Show("生成完毕");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
