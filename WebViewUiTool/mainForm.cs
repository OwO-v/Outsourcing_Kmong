using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections;
using System.Windows.Forms;

namespace WebViewUiTool
{
    public partial class mainForm : Form
    {
        string m_title = string.Empty;
        string m_uri = string.Empty;
        int m_preTabIdx = 0;

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
                tabControl1.SelectedTab = addView(tabControl1.SelectedTab , false);
                tabControl1.SelectedTab.Text = "Tab 1";
                tabControl1.SelectTab(tabControl1.SelectedTab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

            m_preTabIdx = tabControl1.SelectedIndex;
        }
        
        private TabPage addView(TabPage _tabPage, bool _IsNewTab)
        {
            var view = new viewUC(m_uri, _IsNewTab);

            _tabPage.Controls.Add(view);

            view.Dock = DockStyle.Fill;
            view.sendTitle += titleChange;
            _tabPage.BackColor = System.Drawing.Color.Transparent;
            _tabPage.Text = $"Tab {tabControl1.TabPages.Count - 1}";

            return _tabPage;
        }

        private void titleChange(object sender, urlTitleEventArgs e)
        {
            var _tmpString = e.DocTitle;

            if(_tmpString.Length > 10)
            {
                _tmpString = _tmpString.Remove(10, _tmpString.Length - 10);
                _tmpString += "...";
            }

            foreach (TabPage x in tabControl1.TabPages)
            {
                if(x.Controls.Contains(e.nowUc) == true)
                {
                    x.Text = _tmpString;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            (tabControl1.TabPages[m_preTabIdx].GetNextControl(Controls[tabControl1.TabPages[m_preTabIdx].Controls.Count - 1], true) as UserControl).Hide();

            try
            {
                //Add 버튼
                if (tabControl1.SelectedIndex == tabControl1.TabPages.Count - 2)
                {
                    tabControl1.SelectTab(m_preTabIdx);

                    var tp = addView(new TabPage(), true);

                    tabControl1.TabPages.Insert(tabControl1.TabPages.Count - 2, tp);
                    tabControl1.SelectTab(tp);
                }

                //Del 버튼
                if (tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
                {
                    if (tabControl1.TabCount <= 3)
                    {
                        MessageBox.Show("마지막 탭은 지울 수 없습니다.");
                        return;
                    }

                    tabControl1.TabPages.RemoveAt(m_preTabIdx);

                    if (m_preTabIdx > 0)
                        tabControl1.SelectTab(m_preTabIdx - 1);
                    else
                        tabControl1.SelectTab(m_preTabIdx);
                }
            }
            catch
            {

            }
            finally
            {
                m_preTabIdx = tabControl1.SelectedIndex;

                foreach (Control loopContents in tabControl1.SelectedTab.Controls)
                {
                    (loopContents as UserControl).Show();
                }
            }
        }
    }

    public delegate void urlTitleEventHandler(object sender, urlTitleEventArgs e);
    public class urlTitleEventArgs : EventArgs
    {
        public string DocTitle;
        public UserControl nowUc;
    }
}
