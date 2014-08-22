using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scan_API_Application
{
    public partial class FormScannerList : Form
    {
        public static String strSelectedScanner;

        public FormScannerList()
        {
            InitializeComponent();
        }

        private void FormScannerList_Activated(object sender, EventArgs e)
        {
            //Reset Dialog listbox.
            lstScanners.Items.Clear();
            //Add detected scanners to the listbox.
            while (FormMain.strResponse.Contains('"'))
            {
                int intQuoteStartIndex = FormMain.strResponse.IndexOf('"');
                int intQuoteEndIndex = FormMain.strResponse.IndexOf('"', intQuoteStartIndex + 1);
                String strItem = FormMain.strResponse.Substring(intQuoteStartIndex + 1, intQuoteEndIndex - (intQuoteStartIndex + 1));
                FormMain.strResponse = FormMain.strResponse.Remove(0, intQuoteEndIndex + 1);
                lstScanners.Items.Add(strItem);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstScanners.SelectedIndex != -1)
            {
                //If a selection has been made, apply the change,
                strSelectedScanner = lstScanners.SelectedItem.ToString();
            }
            else
            {
                //If nothing is selected, keep the scanner setting to what it was set to.
                strSelectedScanner = FormMain.strScanner;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
