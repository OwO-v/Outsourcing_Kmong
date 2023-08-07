using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;

namespace WebViewUiTool
{
    public partial class mainForm : Form
    {
        string m_title = string.Empty;
        string m_uri = string.Empty;

        public mainForm(string _title, string _uri)
        {
            InitializeComponent();
            m_title = _title;
            m_uri = _uri;
        }

        private void mainForm_Load(object sender, System.EventArgs e)
        {
            this.Text = m_title;

            try
            {
                webView21.Source = new System.Uri(m_uri);
                webView21.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
            {
                tabControl1.SelectTab(tabControl1.TabPages.Count - 2);
                tabControl1.TabPages.RemoveAt(tabControl1.TabPages.Count - 1);

                var tp = new TabPage();
                var wb = new WebView2();

                tp.Controls.Add(wb);
                tp.Text = $"Tab {tabControl1.TabPages.Count + 1}";

                wb.Source = new Uri(m_uri);
                wb.Dock = DockStyle.Fill;
                wb.Update();

                tabControl1.TabPages.Add(tp);
                tabControl1.TabPages.Add("Add");
                tabControl1.SelectTab(tp);
            }
        }
    }
}
