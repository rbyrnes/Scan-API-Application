using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


namespace Scan_API_Application
{
    
    public partial class Form1 : Form
    {
        //Dimension Call Variables. The Server, Port, and Function Strings combine to make the overall URL String.
        String strURL_Server;
        String strURL_Port;
        String strURL_Function;
        String strURL;

        public static String strScanner;

        //Dimension Global Dictionary object.
        Dictionary<string, dynamic> Values = new Dictionary<string, dynamic>();
        Dictionary<string, dynamic> ScanValues = new Dictionary<string, dynamic>();

        //Response and Action Taken strings.
        public static String strResponse;
        String strActionTaken;

        public Form frmScannerList = new FormScannerList();

        public Form1()
        {
            //Load form defaults.
            InitializeComponent();
            //Load saved server setting.
            strURL_Server = Properties.Settings.Default.Server;
            txtServer.Text = strURL_Server;
            //Load saved scanner setting.
            strScanner = Properties.Settings.Default.Scanner;
            txtScanner.Text = strScanner;
            //Load saved port setting.
            strURL_Port = Properties.Settings.Default.Port;
            txtPort.Text = strURL_Port;
            UpdateURL();
            //Start a Session automatically on startup.
            object sender = "";
            System.EventArgs e = System.EventArgs.Empty;
            btnRenewSession_Click(sender, e);

            //Enable/Disable appropriate startup buttons.
            if (txtScanner.Text == "")
            {
                btnViewScannerSettings.Enabled = false;
                btnStartScan.Enabled = false;
            }
            btnEndScan.Enabled = false;
            btnCheckStatus.Enabled = false;
            btnGetDocument.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //End Current Scan if one is open.
            if (Values.ContainsKey("ScanID"))
            {
                btnEndScan_Click(sender, e);
            }
            //Return SessionID when application is closed.
            if (Values.ContainsKey("session"))
            {
                strURL_Function = @"/api/session?sessionid=" + Values["session"] + "&format=json";
                UpdateURL();
                SendRequest();
                Values.Remove("session");
            }
        }

        public void UpdateURL()
        {
            strURL = "http://" + strURL_Server + ":" + strURL_Port + strURL_Function;
        }

        private void btnRenewSession_Click(object sender, EventArgs e)
        {
            strActionTaken = "Start/Renew Session";
            strURL_Function = @"/api/session?license={licensetoken}&closeexisting=false&timeout=3600&scanner=" + strScanner + "&format=json";
            UpdateURL();
            SendRequest();
        }

        private void btnChangeServer_Click(object sender, EventArgs e)
        {
            if (txtServer.Enabled == false)
            {
                txtServer.Enabled = true;
                btnChangeServer.Text = "Accept";
                btnCancelChangeServer.Visible = true;
            }
            else
            {
                strURL_Server = txtServer.Text;
                txtServer.Enabled = false;
                btnChangeServer.Text = "Change Server";
                btnCancelChangeServer.Visible = false;
                //Save Server Setting to Config File.
                Properties.Settings.Default.Server = strURL_Server;
                Properties.Settings.Default.Save();
            }
        }

        private void btnCancelChangeServer_Click(object sender, EventArgs e)
        {
            txtServer.Enabled = false;
            txtServer.Text = strURL_Server;
            btnChangeServer.Text = "Change Server";
            btnCancelChangeServer.Visible = false;
        }

        private void btnSelectScanner_Click(object sender, EventArgs e)
        {
            strActionTaken = "Select Scanner";
            strURL_Function = @"/api/settings";
            UpdateURL();
            SendRequest();
        }

        private void btnChangePort_Click(object sender, EventArgs e)
        {
            if (txtPort.Enabled == false)
            {
                txtPort.Enabled = true;
                btnChangePort.Text = "Accept";
                btnCancelChangePort.Visible = true;
            }
            else
            {
                strActionTaken = "Change Port";
                strURL_Function = @"/api/settings?port=" + txtPort.Text;
                UpdateURL();
                SendRequest();
                if (lblStatus.Text == "(200) OK")
                {
                    strURL_Port = txtPort.Text;
                    txtPort.Enabled = false;
                    btnChangePort.Text = "Change Port";
                    btnCancelChangePort.Visible = false;
                    //Save Port Setting to Config File.
                    Properties.Settings.Default.Port = strURL_Port;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnCancelChangePort_Click(object sender, EventArgs e)
        {
            txtPort.Enabled = false;
            txtPort.Text = strURL_Port;
            btnChangePort.Text = "Change Port";
            btnCancelChangePort.Visible = false;
        }

        private void btnViewScannerSettings_Click(object sender, EventArgs e)
        {
            if (txtScanner.Text != "")
            {
                strActionTaken = "View Scanner Settings";
                strURL_Function = @"/api/settings?scanner=" + strScanner;
                UpdateURL();
                SendRequest();
            }
            else
            {
                MessageBox.Show("Please select a scanner.", "No Scanner Selected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            if (txtScanner.Text != "")
            {
                try
                {
                    if (Values.ContainsKey("session"))
                    {
                        //End Current Scan if one is open.
                        if (Values.ContainsKey("ScanID"))
                        {
                            btnEndScan_Click(sender, e);
                        }

                        strActionTaken = "Start Scan";
                        strURL_Function = @"/api/scan?sessionid=" + Values["session"];
                        UpdateURL();
                        SendRequest();

                        strActionTaken = "Start Scan 2";
                        strURL_Function = @"/api/scan?sessionid=" + Values["session"] + "&scanid=" + Values["ScanID"];
                        UpdateURL();
                        SendRequest();

                        //Enable the other Scanning actions.
                        btnEndScan.Enabled = true;
                        btnCheckStatus.Enabled = true;
                        btnGetDocument.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please start a session before scanning.\n\n" + "Select \"Renew Session\" and try scanning again.",
                            "No Active Session", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The scan failed to initialize.\n\n" + "Please verify the server name, renew the session, and try again.",
                        "Start Scan Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please select a scanner before scanning.", "No scanner selected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            if (Values.ContainsKey("session") && Values.ContainsKey("ScanID"))
            {
                strActionTaken = "Check Scan Status";
                strURL_Function = @"/api/scan?sessionid=" + Values["session"] + "&scanid=" + Values["ScanID"];
                UpdateURL();
                SendRequest();
            }
            else
            {
                MessageBox.Show("There is active scan to check.", "Check Status - No Active Scan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEndScan_Click(object sender, EventArgs e)
        {
            if (Values.ContainsKey("session") && Values.ContainsKey("ScanID"))
            {
                strActionTaken = "End Scan";
                strURL_Function = @"/api/scan?sessionid=" + Values["session"] + "&scanid=" + Values["ScanID"] + "&status=End";
                UpdateURL();
                SendRequest();

                //Disable the Scanning actions.
                btnEndScan.Enabled = false;
                btnCheckStatus.Enabled = false;
                btnGetDocument.Enabled = false;
            }
            else
            {
                MessageBox.Show("There is no active scan to delete.", "Delete Scan - No Active Scan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGetDocument_Click(object sender, EventArgs e)
        {
            if (Values.ContainsKey("session") && Values.ContainsKey("ScanID"))
            {
                strActionTaken = "Get Document";
                strURL_Function = @"/api/scan?sessionid=" + Values["session"] + "&scanid=" + Values["ScanID"];
                UpdateURL();
                SendRequest();
                if (ScanValues["Path"] != null)
                    System.Diagnostics.Process.Start(ScanValues["Path"]);
                else
                    MessageBox.Show("No file path was provided to access the document.", "No File Path Defined", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("There is no active scan to retrieve.", "Get Document - No Active Scan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SendRequest()
        {
            try
            {
                //Dimension WebRequest and Stream Reader objects.
                WebRequest webRequest;
                webRequest = WebRequest.Create(strURL);
                webRequest.Credentials = CredentialCache.DefaultCredentials;
                if (strActionTaken != "Start Scan 2")
                    webRequest.Method = "GET";
                else
                {
                    webRequest.Method = "POST";
                    webRequest.ContentLength = 0;
                }
                Stream objStream;

                //Dimension response string and read the new Web Request Response.
                //String strResponse = "";
                strResponse = "";
                lblStatus.Text = "_";
                try
                {
                    objStream = webRequest.GetResponse().GetResponseStream();

                    StreamReader objReader = new StreamReader(objStream);

                    string sLine = "";
                    int i = 0;

                    while (sLine != null)
                    {
                        i++;
                        sLine = objReader.ReadLine();
                        if (sLine != null)
                            strResponse = strResponse + sLine;
                    }

                    //Perform desired action depending on length of Response string and the Action Taken.
                    if (strResponse != "")
                    {
                        if (strActionTaken == "Start/Renew Session")
                        {
                            //If Dictionary is not null, add/overwrite the SessionID value.
                            if (Values.ContainsKey("session"))
                            {
                                Values.Remove("session");
                            }
                            strResponse = strResponse.Trim('"');
                            Values.Add("session", strResponse);
                        }
                        else if (strActionTaken == "Select Scanner")
                        {
                            frmScannerList.Activate();
                            frmScannerList.ShowDialog();
                            strScanner = FormScannerList.strSelectedScanner;
                            txtScanner.Text = strScanner;
                            //Enabled/disable appropriate options.
                            if (txtScanner.Text == "")
                            {
                                btnViewScannerSettings.Enabled = false;
                                btnStartScan.Enabled = false;
                            }
                            else
                            {
                                btnViewScannerSettings.Enabled = true;
                                btnStartScan.Enabled = true;
                            }
                            //Save Scanner Setting to Config File.
                            Properties.Settings.Default.Scanner = strScanner;
                            Properties.Settings.Default.Save();
                        }
                        else if (strActionTaken == "Start Scan")
                        {
                            //If Dictionary is not null, add/overwrite the ScanID value.
                            if (Values.ContainsKey("ScanID"))
                            {
                                Values.Remove("ScanID");
                            }
                            strResponse = strResponse.Trim('"');
                            Values.Add("ScanID", strResponse);
                        }
                        else if (strActionTaken == "Check Scan Status" || strActionTaken == "Get Document")
                        {
                            try
                            {
                                ScanValues = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(strResponse);
                                if (strActionTaken == "Check Scan Status")
                                    MessageBox.Show("Scan ID:  " + ScanValues["ScanID"] + "\n" + "Progress:  " + ScanValues["Progress"] + "\n" +
                                        "Time of Request:  " + ScanValues["TimeofRequest"] + "\n" + "Length:  " + ScanValues["Length"] + "\n" +
                                        "Path:  " + ScanValues["Path"], "Scan Progress", MessageBoxButtons.OK);
                            }
                            catch (Newtonsoft.Json.JsonSerializationException)
                            {
                                //Throw exception if JSON response cannot be serialized.
                                MessageBox.Show("Unable to Deserialize JSON response.", "Error - JSON Deserialization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception)
                            {
                                //Catch all exception.
                                MessageBox.Show("Unexpected Response Data was retrieved. Please try again.", "Error - Invalid Response",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (strActionTaken == "End Scan")
                    {
                        //Remove Scan ID from dictionary.
                        Values.Remove("ScanID");
                    }
                    lblStatus.Text = "(200) OK";
                }
                catch (System.Net.WebException e)
                {
                    //Show HTTP status code if an error is thrown.
                    lblStatus.Text = Convert.ToString(e.Message.Remove(0, 37));
                }
                strActionTaken = "";
            }
            catch (Exception e)
            {
                //Show error message for unhandled exceptions.
                lblStatus.Text = e.Message;
            }
        }

    }

}
