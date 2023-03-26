using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace WFAGetMessageClient
{
    public partial class frmGetMessage : Form
    {
        IGetMessageRemotingService.IGetMessageRemotingService client;

        public frmGetMessage()
        {
            InitializeComponent();

            TcpChannel channel = new TcpChannel();

            ChannelServices.RegisterChannel(channel);

            client = (IGetMessageRemotingService.IGetMessageRemotingService)Activator.GetObject(typeof(IGetMessageRemotingService.IGetMessageRemotingService), "tcp://localhost:8081/GetMessage");

        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            lblGetMessageResult.Text = client.GetMessage(tbxGetMessage.Text);

        }
    }
}
