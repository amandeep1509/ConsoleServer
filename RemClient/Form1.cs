using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ConsoleServer;


namespace RemClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemCustomer remoteCust = (RemCustomer)Activator.GetObject(typeof(RemCustomer), "tcp://localhost:13340/RemCustomer");

            //RemoteClient_003: Get Customer Id and Name exposed by the remote object itself
            int id = remoteCust.Get_id();
            string name = remoteCust.Get_Name();

            //RemoteClient_004: Get Some other object from the server through the remote
            //object. Note the object should be serializable.
            LastTrans trans = remoteCust.GetLastTrans();
            int lastdeposit = trans.GetLastDeposit();
            int lastwithdraw = trans.GetLastWithdraw();

            //RemoteClient_005: Display the information retrieved
            txtCustId.Text = id.ToString();
            txtCustName.Text = name;
            txtLastDeposit.Text = lastdeposit.ToString();
            txtLastWithdraw.Text = lastwithdraw.ToString();
            btnInvokeRemote.Enabled = false;
        }
    }
}
