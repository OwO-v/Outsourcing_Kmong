using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewUiTool
{
    public partial class viewUC : UserControl
    {
        public urlTitleEventHandler sendTitle;

        string m_uri = null;

        public viewUC(string _uri, bool IsNewTab)
        {
            InitializeComponent();

            m_uri = _uri;

            //각각 다른 세션을 보유하도록 생성
            if(IsNewTab == true)
            {
                wv_contents.CreationProperties = new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties();
                wv_contents.CreationProperties.UserDataFolder = System.IO.Path.Combine(Application.StartupPath, $"{Guid.NewGuid()}");
            }
        }

        private async void viewUC_Load(object sender, EventArgs e)
        {
            wv_contents.Source = new Uri(m_uri);
            wv_contents.CoreWebView2InitializationCompleted += CoreWebView2InitializationCompleted;
            await wv_contents.EnsureCoreWebView2Async();
        }

        private void CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                this.wv_contents.CoreWebView2.DocumentTitleChanged += DocumentTitleChanged;
                wv_contents.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            }
        }

        private void DocumentTitleChanged(object sender, object e)
        {
            tb_location.Text = wv_contents.Source.ToString();

            sendTitle(this, new urlTitleEventArgs()
            {
                DocTitle = this.wv_contents.CoreWebView2.DocumentTitle,
                nowUc = this
            });
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.NewWindow = wv_contents.CoreWebView2;
        }

        private void btn_navigate_Click(object sender, EventArgs e)
        {
            if (tb_location.Text.StartsWith("https://") == false && tb_location.Text.StartsWith("http://") == false)
            {
                tb_location.Text = $"https://{tb_location.Text}";
            }

            wv_contents.CoreWebView2.Navigate(tb_location.Text);
        }
    }
}
