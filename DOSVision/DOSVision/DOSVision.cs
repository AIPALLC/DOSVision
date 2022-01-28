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
using System.Net.Sockets;

namespace DOSVision
{

    public enum Protocol
    {
        TCP = 6,
        UDP = 17,
        Unknown = -1
    };

    public partial class DOSVision : Form
    {

        const string guidFWPolicy2 = "{E2B3C97F-6AE1-41AC-817A-F6F92166D7DD}";
        const string guidRWRule = "{2C5BC43E-3369-4C33-AB0C-BE9469677AF4}";
        private Socket mainSocket, mainSocket1;                          
        private byte[] byteData = new byte[4096];
        private bool bContinueCapturing = false;            
        int count = 0, dropped = 0, processpacket = 1;
        int timerflag = 1, treshold = 1000;

        private void checkmalicious(string p, string p_2, string p_3, string sip, string dip, string pro, string flags, string[] arr)
        {
            ListViewItem itm;
            string[] arr1 = arr;


            if (pro.CompareTo("UDP") == 0)
            {
                if (p_2.CompareTo("0") == 0 || p_3.CompareTo("0") == 0)
                {
                    arr1[7] = "UDP PORT 0 ATTACK";
                    itm = new ListViewItem(arr1);
                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Red;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {

                        bContinueCapturing = false;

                        processpacket = 0;


                    }
                }
                else if (count <= treshold)
                {
                    arr1[7] = "----------------";

                    itm = new ListViewItem(arr1);

                    listView1.Items.Add(itm);

                }
                else if (count > treshold)
                {
                    arr1[7] = "Treshold crossed";

                    itm = new ListViewItem(arr1);

                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Brown;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {

                        bContinueCapturing = false;

                        processpacket = 0;


                    }
                }

            }


            if (pro.CompareTo("TCP") == 0)
            {

                if (p_2.CompareTo("0") == 0 || p_3.CompareTo("0") == 0)
                {
                    arr1[7] = "PORT 0 ATTACK";
                    itm = new ListViewItem(arr1);
                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Red;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {

                        bContinueCapturing = false;

                        processpacket = 0;


                    }


                }
                else if (sip.CompareTo("0.0.0.0") == 0)
                {
                    arr1[7] = "INVALID IP ATTACK";
                    itm = new ListViewItem(arr1);
                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Red;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {
                        bContinueCapturing = false;
                        processpacket = 0;
                    }
                }
                else if (flags.Contains("SYN") == true && flags.Contains("FIN") == true)
                {
                    arr1[7] = "SYN FIN ATTACK";
                    itm = new ListViewItem(arr1);
                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Red;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {
                        bContinueCapturing = false;
                        processpacket = 0;
                    }
                }
                else if (flags.Contains("URG") == true && flags.Contains("FIN") == true && flags.Contains("PSH") == true)
                {
                    arr1[7] = "INVALID FLAG SETTINGS (URG,FIN,PSH)";
                    itm = new ListViewItem(arr1);
                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Red;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {
                        bContinueCapturing = false;
                        processpacket = 0;
                    }
                }
                else if (flags.Contains("SYN") == true && flags.Contains("RST") == true)
                {
                    arr1[7] = "INVALID FLAG SETTINGS (SYN,RST)";
                    itm = new ListViewItem(arr1);
                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Red;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {
                        bContinueCapturing = false;
                        processpacket = 0;
                    }
                }
                else if (flags.Contains("SYN") == true && flags.Contains("ACK") == true)
                {
                    arr1[7] = "INVALID FLAG SETTINGS (SYN,ACK)";
                    itm = new ListViewItem(arr1);
                    listView1.Items.Add(itm);
                    listView1.Items[count - 1].BackColor = Color.Red;
                    listView1.Items[count - 1].ForeColor = Color.White;
                    if (btnAntiDDOS.Checked == true)
                    {
                        processpacket = 0;
                    }
                }
                else
                {
                    if (count <= treshold)
                    {
                        arr1[7] = "----------------";

                        itm = new ListViewItem(arr1);

                        listView1.Items.Add(itm);

                    }
                    else if (count > treshold)
                    {
                        arr1[7] = "Treshold crossed";

                        itm = new ListViewItem(arr1);

                        listView1.Items.Add(itm);
                        listView1.Items[count - 1].BackColor = Color.Brown;
                        listView1.Items[count - 1].ForeColor = Color.White;

                    }

                    processpacket = 1;

                }

            }

        }

        private void ParseData(byte[] byteData, int nReceived)
        {
            IPHeader ipHeader = new IPHeader(byteData, nReceived);


            string[] arr = new string[8];

            switch (ipHeader.ProtocolType)
            {
                case Protocol.TCP:

                    TCPHeader tcpHeader = new TCPHeader(ipHeader.Data,               
                                                                                
                                                        ipHeader.MessageLength);                  


                    arr = new string[8];

                    if (listView1.InvokeRequired)
                    {
                        listView1.Invoke(new MethodInvoker(delegate
                        {
                            if (false)
                            {

                            }
                            else
                            {

                                ++count;
                                arr[0] = count.ToString();
                                arr[1] = tcpHeader.SourcePort;
                                arr[2] = tcpHeader.DestinationPort;
                                arr[3] = ipHeader.SourceAddress.ToString();
                                arr[4] = ipHeader.DestinationAddress.ToString();
                                arr[5] = "TCP";
                                arr[6] = tcpHeader.Flags.ToString();
                                checkmalicious(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr);
                            }
                        }));
                    }




                    break;



                case Protocol.UDP:

                    UDPHeader udpHeader = new UDPHeader(ipHeader.Data,

                                                       (int)ipHeader.MessageLength);




                    UDPHeader udp = new UDPHeader(ipHeader.Data,              
                                                                              
                                                       ipHeader.MessageLength);                  


                    arr = new string[8];

                    if (listView1.InvokeRequired)
                    {
                        listView1.Invoke(new MethodInvoker(delegate
                        {
                            if (false)
                            {

                            }
                            else
                            {

                                ++count;
                                arr[0] = count.ToString();
                                arr[1] = udp.SourcePort;
                                arr[2] = udp.DestinationPort;
                                arr[3] = ipHeader.SourceAddress.ToString();
                                arr[4] = ipHeader.DestinationAddress.ToString();
                                arr[5] = "UDP";
                                arr[6] = "";
                                checkmalicious(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr);
                            }
                        }));
                    }

                    break;

                case Protocol.Unknown:
                    break;
            }


        }

        private void OnReceive1(IAsyncResult ar)
        {
            try
            {
                int nReceived = mainSocket.EndReceive(ar);


                ParseData(byteData, nReceived);

                if (bContinueCapturing)
                {
                    byteData = new byte[4096];

                    mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                        new AsyncCallback(OnReceive), null);
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DOSVision", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void beginsocket(object source, System.Timers.ElapsedEventArgs e, string receiver)
        {
            processpacket = 1;
            bContinueCapturing = true;
            timerflag = 1;
            try
            {
                mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                          new AsyncCallback(OnReceive), null);
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                // Error, but undefined.
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                int nReceived = mainSocket.EndReceive(ar);


                if (processpacket == 1)
                {
                    ParseData(byteData, nReceived);
                }

                if (processpacket == 0)
                {
                    dropped += 1;

                    label1.Invoke(new MethodInvoker(delegate {
                        label1.Text = dropped.ToString() + " Packet(s) blocked.";
                    }));

                    if (timerflag == 1)
                    {
                        System.Timers.Timer mytimer = new System.Timers.Timer(1000);
                        mytimer.Elapsed += (timerSender, timerEvent) => beginsocket(timerSender, timerEvent, null);
                        mytimer.AutoReset = true;
                        mytimer.Enabled = true;
                        timerflag = 0;
                    }
                }


                if (bContinueCapturing)
                {
                    byteData = new byte[4096];
                    mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                        new AsyncCallback(OnReceive), null);
                }
                else
                {

                }


            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                // Error, but undefined.
            }


        }

        private void btnAntiDDOS_Click(object sender, EventArgs e)
        {
            if (btnAntiDDOS.Checked == true)
            {


                btnAntiDDOS.Text = "Disable Anti-DDOS";

            }
            else
                btnAntiDDOS.Text = "Enable Anti-DDOS";
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (cmbInterfaces.Text == "")
            {
                MessageBox.Show("Please select an interface to supervise.", "DOSVision",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (!bContinueCapturing)
                {

                    btnEnable.Text = "Disable";

                    bContinueCapturing = true;

                    mainSocket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Raw, ProtocolType.IP);

                    mainSocket.Bind(new IPEndPoint(IPAddress.Parse(cmbInterfaces.Text), 0));

                    mainSocket.SetSocketOption(SocketOptionLevel.IP,            
                                               SocketOptionName.HeaderIncluded, 
                                               true);                           

                    byte[] byTrue = new byte[4] { 1, 0, 0, 0 };
                    byte[] byOut = new byte[4] { 1, 0, 0, 0 };

                    mainSocket.IOControl(IOControlCode.ReceiveAll,              
                                                                                
                                         byTrue,
                                         byOut);


                    mainSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                        new AsyncCallback(OnReceive), null);
                }
                else
                {
                    btnEnable.Text = "Enable";
                    bContinueCapturing = false;
                    mainSocket.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DOSVision", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DOSVision()
        {
            InitializeComponent();
        }

        private void DOSVision_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            btnAntiDDOS.Checked = false;
            listView1.Columns.Add("Position", 75);
            listView1.Columns.Add("Port: Source", 100);
            listView1.Columns.Add("Port: Destination", 100);
            listView1.Columns.Add("Source: IP", 200);
            listView1.Columns.Add("Destination: IP", 200);
            listView1.Columns.Add("Category: Protocol", 100);
            listView1.Columns.Add("Category: Flags", 150);
            listView1.Columns.Add("Category: Reason", 200);


            string strIP = null;

            IPHostEntry HosyEntry = Dns.GetHostEntry((Dns.GetHostName()));
            if (HosyEntry.AddressList.Length > 0)
            {
                foreach (IPAddress ip in HosyEntry.AddressList)
                {
                    strIP = ip.ToString();
                    cmbInterfaces.Items.Add(strIP);
                }
            }
        }

        private void DOSVision_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bContinueCapturing)
            {
                mainSocket.Close();
            }
        }
    }
}
