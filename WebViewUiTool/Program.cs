using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewUiTool
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string _title = string.Empty;
            string _uri = string.Empty;
            
            try
            {
                string targetTitlePath = $@"{Application.StartupPath}\runtimes2\title.ini";
                string targetUriPath = $@"{Application.StartupPath}\runtimes2\run.ini";
                string strLine = string.Empty;

                if (File.Exists(targetTitlePath) == true)
                {
                    using (var titleReader = new StreamReader(targetTitlePath))
                    {
                        strLine = titleReader.ReadLine();
                        titleReader.Close();
                        _title = strLine;
                    }
                }
                else
                {
                    throw new Exception($"File doesn't exist {targetTitlePath}");
                }

                if (File.Exists(targetUriPath) == true)
                {
                    using (var uriReader = new StreamReader(targetUriPath))
                    {
                        strLine = uriReader.ReadLine();
                        uriReader.Close();
                        _uri = strLine;
                    }
                }
                else
                {
                    throw new Exception($"File doesn't exist {targetUriPath}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm(_title, _uri));
        }
    }
}
