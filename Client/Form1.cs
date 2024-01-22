using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;   // 간단히 3개 모듈만 추가하더라도 통신모듈을 확인해볼수 있다!


/*

// 클라이언트 프로그램 ①
namespace Client
{
    public partial class Form1 : Form
    {
        public string serverIP = "127.0.0.1";
        public int port = 9876;
        public string serverDomain = "localhost";
        public Form1()
        {
            InitializeComponent();
        }

        // 클라이언트 프로그램 ②
        private void button_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(serverIP, port);
            SslStream sslStream = new SslStream(client.GetStream(), false, validateCertificate, null);
            sslStream.AuthenticateAsClient(serverDomain);

            byte[] buf = Encoding.ASCII.GetBytes("Hello SSL!");
            sslStream.Write(buf, 0, buf.Length);
            sslStream.Flush();

            buf = new byte[4096];
            int length = sslStream.Read(buf, 0, 4096);
            messageText.Text = Encoding.ASCII.GetString(buf, 0, length);
        }
        private bool validateCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

    }

}

 */

