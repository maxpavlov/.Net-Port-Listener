using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PortListener
{
    public partial class MainForm : Form
    {
        List<TcpListener> listeners;

        private bool terminateListeners = false;
        private bool started = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateAvailableIPs();
        }

        private void PopulateAvailableIPs()
        {
            lbAvailableInterfaces.Items.Clear();

            foreach (var i in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                foreach (var ua in i.GetIPProperties().UnicastAddresses)
                {
                    if (ua.SuffixOrigin != SuffixOrigin.LinkLayerAddress)
                        lbAvailableInterfaces.Items.Add(ua.Address);
                }
        }

        private void btnAddInterface_Click(object sender, EventArgs e)
        {
            foreach (var item in lbAvailableInterfaces.SelectedItems)
            {
                lbSelectedInterfaces.Items.Add(item);
            }

            for (int index = 0; index < lbAvailableInterfaces.SelectedItems.Count; index++)
            {
                var item = lbAvailableInterfaces.SelectedItems[index];
                lbAvailableInterfaces.Items.Remove(item);
            }
        }

        private void lbAvailableInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvailableInterfaces.SelectedItems.Count > 0)
                btnAddInterface.Enabled = true;
            else
                btnAddInterface.Enabled = false;
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                rtbLog.Clear();

                var port = int.Parse(tbPort.Text);

                listeners = new List<TcpListener>();

                foreach (var item in lbSelectedInterfaces.Items)
                {
                    var listener = new TcpListener(IPAddress.Parse(item.ToString()), port);
                    listener.Start();

                    LogTextEvent(rtbLog, Color.Lime, String.Format("Listinging on {0}.", item));

                    listeners.Add(listener);
                }

                var backListener = new Thread(PollIncoming);
                backListener.Start();

                started = true;
                btnStartListening.Text = "Stop";
                
            }
            else
            {
                TerminateListeners();
                btnStartListening.Text = "Start";
                started = false;
            }
        }

        private void PollIncoming()
        {
            while (!terminateListeners)
            {
                foreach (var tcpListener in listeners)
                {
                    if (tcpListener.Pending())
                    {
                        var client = tcpListener.AcceptTcpClient();
                        var writer = new StreamWriter(client.GetStream());
                        writer.WriteLine("Hello from Port Listener. I am here!");
                        writer.Flush();
                        LogTextEvent(rtbLog, Color.Maroon, String.Format("Just greeted a connector from {0}.", client.Client.RemoteEndPoint));
                    }
                }

                Thread.Sleep(1000);
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TerminateListeners();
        }

        private void TerminateListeners()
        {
            terminateListeners = true;

            foreach (var tcpListener in listeners)
            {
                tcpListener.Stop();
            }
        }

        public void LogTextEvent(RichTextBox TextEventLog, Color TextColor, string EventText)
        {
            if (TextEventLog.InvokeRequired)
            {
                TextEventLog.BeginInvoke(new Action(delegate
                {
                    LogTextEvent(TextEventLog, TextColor, EventText);
                }));
                return;
            }

            string nDateTime = DateTime.Now.ToString("hh:mm:ss tt") + " - ";

            // color text.
            TextEventLog.SelectionStart = TextEventLog.Text.Length;
            TextEventLog.SelectionColor = TextColor;

            // newline if first line, append if else.
            if (TextEventLog.Lines.Length == 0)
            {
                TextEventLog.AppendText(nDateTime + EventText);
                TextEventLog.ScrollToCaret();
                TextEventLog.AppendText(System.Environment.NewLine);
            }
            else
            {
                TextEventLog.AppendText(nDateTime + EventText + System.Environment.NewLine);
                TextEventLog.ScrollToCaret();
            }
        }
    }
}
