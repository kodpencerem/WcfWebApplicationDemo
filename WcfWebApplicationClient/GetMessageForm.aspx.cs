using System;

namespace WcfWebApplicationClient
{
    public partial class GetMessageForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetMessage_Click(object sender, EventArgs e)
        {
            GetMessageReference.GetMessageWebServiceSoapClient client = new GetMessageReference.GetMessageWebServiceSoapClient();

            lblGetMessage.Text = client.GetMessage(tbxGetMessage.Text);
        }
    }
}