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

namespace Lara_Media
{
    public partial class frmBrowser : Form
    {
        ListBox lbx = new ListBox();//LISTBOX TO display history
        WebBrowser[] web = new WebBrowser[20];//array of 20 webbrowsers
        TabPage[] Tabpg = new TabPage[20];//array of 20 tabs
        int pk = 0;//current picked tab
        int rowCount = 0;//number of tabs stancieted
        int imagePK = 0;//used for reload and cancel buttons
        
        public void newTab()
        {//Created new tab and new webbrowser
            try
            {
                //intantiates the first tab in the array
                Tabpg[rowCount] = new TabPage();
                //sets the tab tag to the current value of rowcount
                Tabpg[rowCount].Tag = rowCount.ToString();
                //sets the pk variable equal to the current tab tag
                pk = int.Parse(Tabpg[rowCount].Tag.ToString());
                //assigns the name to new tab as dsefault
                Tabpg[rowCount].Text = "New Tab " + rowCount;
                //adds the tab to the tab control
                tabMainTab.Controls.Add(Tabpg[rowCount]);
                //instantiates the first browser in the array and disables script errors
                web[rowCount] = new WebBrowser() { ScriptErrorsSuppressed = true };
                //makes the current tab the parent of the current browser
                web[rowCount].Parent = Tabpg[rowCount];
                //the webbrowser will fill the tab
                web[rowCount].Dock = DockStyle.Fill;
                //navigates to google as homepage
                web[rowCount].Navigate("http://www.google.com");
                //adds 1 to rowcount
                rowCount++;
                try
                {//unidentify error so had to do this...
                    //focus on the last tab instantiated
                    tabMainTab.SelectTab(tabMainTab.TabCount - 1);
                }
                catch (Exception)
                {
                    //focus on the last tab instantiated
                    tabMainTab.SelectTab(tabMainTab.TabCount - 1);
                }
            }
            catch (Exception)
            {
                tssStatus.Text = "Tab limit reached\nTabs will be Recycled";
                //tabMainTab.TabPages.RemoveAt(rowCount);
                //rowCount = 0;
            }
        }
        
        
        private void lbx_SelectedIndexChanged(object sender, EventArgs e)
        {//when selected index fro LISTBOX changes this runs(selecting an item from history)
            try
            {
                //the current url is set on the textbox
                txtURL.Text = data.history[lbx.SelectedIndex];
                //navigates to selected url
                Nav(txtURL.Text);
            }
            catch (Exception)
            {
                tssStatus.Text = "Exeption on list box SelectedIndexChanged";
            }
        }

        private void RefreshList()
        {//adds a new item to the history list and removes duplicates
            for (int i = 0; i < data.history.Count(); i++)
            {//loops the number of itemns in the lit
                if (web[pk].Url.ToString() == data.history[i])
                {//compares them to new entry
                    //deletes any duplicates
                    data.history.RemoveAt(i);
                }
            }
            //adds new entry
            data.history.Add(web[pk].Url.ToString());
        }

        public frmBrowser()
        {
            InitializeComponent();
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {//loading the main form
            data d = new data();
            //gets the history file in to the list
            d.FileIn();
            //creates new tab
            newTab();
            //navigates to homepage
            web[pk].Navigate("http://www.google.com");
            //creates an event for webbrowser
            web[pk].DocumentCompleted += wbrWebBrowser_DocumentCompleted;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {//calls the nav function to validate url and run
            Nav(txtURL.Text);
        }
        
        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {//ENTER KEY  can be used as the button GO
            if(e.KeyChar == (char)ConsoleKey.Enter)
            {
                Nav(txtURL.Text);
            }
        }
        
        private void wbrWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {// when a page is loaded into the browser this runs at the end
            //image pk is set to sero to use the first image on an image list
            imagePK = 0;
            //displays the first image wich is reload from image list
            tsbReload.Image = imageList.Images[imagePK];
            //gets the current url and sets it to the textbox
            txtURL.Text = web[pk].Url.ToString();
            //calls the refresh list function(adds to history list)
            RefreshList();
            //changes the title of the tab to the page title
            tabMainTab.SelectedTab.Text = web[pk].DocumentTitle;
            //changes the status strip text
            tssStatus.Text = "Done!";
            //reenables the textbox and go button to let user navigate
            btnGo.Enabled = true;
            txtURL.Enabled = true;
        }

        public void Nav(string text)
        {//navigates and validates url
            //makes the current browser visible in case the history tab was beening used
            web[pk].Visible = true;
            //sets the tab title to current web page toitle
            tabMainTab.SelectedTab.Text = web[pk].DocumentTitle;
            //sets imagepk to 1 to use the second image on the image list
            imagePK = 1;
            //displays the red cross image to reenable navigation
            tsbReload.Image = imageList.Images[imagePK];
            //stores the url used to navigate
            string url;
            //sets url = to text passed to function
            url = text;
            //sets the status strip 
            tssStatus.Text = "Loading..";
            //disables the textbox and go button
            btnGo.Enabled = false;
            txtURL.Enabled = false;
            //val;idates for url behginings
            if (!url.StartsWith("http://"))
            {
                if (url.StartsWith("https://"))
                {
                    url = text;
                    web[pk].Navigate(url);
                    return;
                }
                else
                {
                    url = "http://" + text;
                }
            }
            //checks url and navigates if true
            if (CheckURL(url))
            {
                web[pk].Navigate(url);
            }
            else
            {//esle it make a gogle search
                web[pk].Navigate("http://google.com/search?q=" + text);
            }
        }

        bool CheckURL(string url)
        {//checks for valid url
            bool isURLValid = false;
            try
            {
                //request to creates url
                var req = (HttpWebRequest)HttpWebRequest.Create(url);
                req.AllowAutoRedirect = false;
                using (var resp = req.GetResponse())
                {//if a location a is fine for the url
                    var location = resp.Headers["Location"];
                    if (!String.IsNullOrEmpty(location))
                    {//valid is true
                        isURLValid = true;
                    }
                }
            }
            catch
            {
                //else valid is false
                isURLValid = false;
            }
            return isURLValid;
        }

        private void wbrWebBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {//gets the progress to use the progress bar
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                tspProgressBar.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }

        private void tsbPrevious_Click(object sender, EventArgs e)
        {//goes back on selected browser
            web[pk].GoBack();
            web[pk].Visible = true;
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {//goes to next on selected browser
            web[pk].GoForward();
            web[pk].Visible = true;
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {//goes home page on selected browser
            web[pk].Navigate("http://www.google.com");
            web[pk].Visible = true;
        }

        private void tsbReload_Click(object sender, EventArgs e)
        {//reloads page or reenables textbox and button
            if (imagePK == 0)
            {//if imagepk is 0 ir refreshes
                web[pk].Refresh();
            }
            else
            {//reenables textbox and button and changes back reload image
                btnGo.Enabled = true;
                txtURL.Enabled = true;
                imagePK = 0;
                tsbReload.Image = imageList.Images[imagePK];
            }
        }
        
        private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {//gest history list to file makes sure application closes completly
            data d = new data();
            d.FileOut();
            Application.Exit();
        }

        private void txtURL_Enter(object sender, EventArgs e)
        {//selects all text 
            txtURL.SelectAll();
        }
        
        private void tabMainTab_SelectedIndexChanged(object sender, EventArgs e)
        {//if tab index changes pk is set to the current tab tag
            pk = int.Parse(tabMainTab.SelectedTab.Tag.ToString());//tabMainTab.SelectedIndex;
            txtURL.Text = web[pk].Url.ToString();
        }
        
        private void lblCloseTab_Click(object sender, EventArgs e)
        {//closes current tab
            try
            {
                int currentIndex = tabMainTab.SelectedIndex;
                tabMainTab.TabPages.RemoveAt(tabMainTab.SelectedIndex);
                tabMainTab_SelectedIndexChanged(null,null);
                tabMainTab.SelectTab(currentIndex - 1);
                //web[pk].Dispose();
            }
            catch (Exception ex)
            {
                tssStatus.Text = ex.ToString();
                //rowCount = 0;
            }
            
        }

        private void lblNewTab_Click(object sender, EventArgs e)
        {//creates a new tab and focuses to taxtbox
            newTab();
            txtURL.Text = "";
            txtURL.Focus();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {//closes application
            Application.Exit();
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            //creates new tab
            newTab();//creates new tab
            frmHelp frm = new frmHelp();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabMainTab.TabPages[tabMainTab.SelectedIndex].Controls.Add(frm);
            //makes browser invisable to see listbox
            web[pk].Visible = false;
            Tabpg[pk].Text = "Help";
            pk = int.Parse(tabMainTab.SelectedTab.Tag.ToString());//tabMainTab.SelectedIndex;
        }

        private void mnuHistory_Click(object sender, EventArgs e)
        {//displays history tab
            //creates new tab
            newTab();
            //makes the listbox a child of tab
            lbx.Parent = Tabpg[pk];
            //listbox fill entire tab
            lbx.Dock = DockStyle.Fill;
            //creates select index event
            lbx.SelectedIndexChanged += lbx_SelectedIndexChanged;
            //makes browser invisable to see listbox
            web[pk].Visible = false;
            //clears listbox
            lbx.Items.Clear();
            //adds all itenms from list to listbox
            for (int i = 0; i < data.history.Count; i++)
            {
                lbx.Items.Add(data.history[i]);
            }
            pk = int.Parse(tabMainTab.SelectedTab.Tag.ToString());//tabMainTab.SelectedIndex;
        }

    }
}
