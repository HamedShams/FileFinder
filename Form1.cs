using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinder
{
    /// <summary>
    /// File Finder
    /// A small C# windows application, that let you find you files very quickly (Thanks to Aync!).
    /// You should just copy it in the directory you want, then it'll search whole of that directory.
    /// 
    /// Developed by Seyed Hamed Shams @ 2014
    /// Hamed.Shams40@Gmail.com
    /// </summary>
    public partial class Form1 : Form
    {
        int HEIGHT2 = 420;
        int HEIGHT1 = 89;
        
        // Data Source
        Dictionary<string, string> DS = new Dictionary<string, string>();

        //

        public Form1()
        {
            InitializeComponent();
        }

        //

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Txt_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(this.Txt_Name.Text)) // If Txt_Text wasn't empty
                {
                    this.Height = HEIGHT2; // Maximize the form

                    Action a = null;
                    if (!String.IsNullOrWhiteSpace(this.Txt_Ext.Text)) // If Txt_Ext also wasn't empty => Search based on both Name & Extension (Search method)
                    {
                        a = new Action(Search);
                    }
                    else // If Txt_Ext was empty => Just search based on Name (Search_Name method)
                    {
                        a = new Action(Search_Name);
                    }
                    a.BeginInvoke(AsyncCore, a);
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(this.Txt_Ext.Text)) // If both text boxes was empty
                    {
                        this.Height = HEIGHT1; // Minimize the form
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Ext_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(this.Txt_Ext.Text)) // If Txt_Ext wasn't empty
                {
                    this.Height = HEIGHT2; // Maximize the form

                    Action a = null;
                    if (!String.IsNullOrWhiteSpace(this.Txt_Name.Text)) // If Txt_Name also wasn't empty => Search based on both Name & Extension (Search method)
                    {
                        a = new Action(Search);
                    }
                    else // If Txt_Name was empty => Just search based on Extension (Search_Ext method)
                    {
                        a = new Action(Search_Ext);
                    }
                    a.BeginInvoke(AsyncCore, a);
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(this.Txt_Name.Text)) // If both text boxes was empty, minimize the form
                    {
                        this.Height = HEIGHT1; // Minimize the form
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// To open the file that listed. (On user's click)
        /// </summary>
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string FPath = (from x in DS
                                where x.Key == this.ListBox.SelectedItem.ToString()
                                select x.Value).Single();

                Process.Start(FPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //

        /// <summary>
        /// Based on both Name & Extension
        /// </summary>
        void Search()
        {
            try
            {
                DirectoryInfo DI = new DirectoryInfo(Environment.CurrentDirectory);

                var Q = from FileInfo x in DI.GetFiles()
                        where x.Name.Contains(this.Txt_Name.Text) && x.Extension == "." + this.Txt_Ext.Text
                        select new { FName = x.Name, FPath = x.FullName };

                this.DS.Clear();
                foreach (var item in Q)
                {
                    DS.Add(item.FName, item.FPath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Based on Name
        /// </summary>
        void Search_Name()
        {
            try
            {
                DirectoryInfo DI = new DirectoryInfo(Environment.CurrentDirectory);

                var Q = from FileInfo x in DI.GetFiles()
                        where x.Name.Contains(this.Txt_Name.Text)
                        select new { FName = x.Name, FPath = x.FullName };

                this.DS.Clear();
                foreach (var item in Q)
                {
                    DS.Add(item.FName, item.FPath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Based on Extension
        /// </summary>
        void Search_Ext()
        {
            try
            {
                DirectoryInfo DI = new DirectoryInfo(Environment.CurrentDirectory);

                var Q = from FileInfo x in DI.GetFiles()
                        where x.Extension == "." + this.Txt_Ext.Text
                        select new { FName = x.Name, FPath = x.FullName };

                this.DS.Clear();
                foreach (var item in Q)
                {
                    DS.Add(item.FName, item.FPath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void FillListBox()
        {
            try
            {
                this.ListBox.Items.Clear();

                foreach (KeyValuePair<string, string> item in DS)
                {
                    this.ListBox.Items.Add(item.Key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void AsyncCore(IAsyncResult ar)
        {
            try
            {
                Action a = (Action)ar.AsyncState;

                a.EndInvoke(ar);

                this.Invoke((MethodInvoker)delegate
                {
                    FillListBox();
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
