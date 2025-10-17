using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace UdpCalculator
{
    public partial class Form1 : Form
    {
        UdpClient client;
        IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5005);

        public Form1()
        {
            InitializeComponent();
            client = new UdpClient();
        }

        // 🧮 Gönder butonu
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOp.SelectedIndex < 0)
                {
                    MessageBox.Show("Lütfen bir işlem seçin (+, -, * veya /)");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text) ||
                    txtA.Text == "Sayı 1 giriniz" || txtB.Text == "Sayı 2 giriniz")
                {
                    MessageBox.Show("Lütfen her iki sayıyı da girin.");
                    return;
                }

                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                byte op = (byte)cmbOp.SelectedIndex; // 0=+,1=-,2=*,3=/

                byte[] bufA = BitConverter.GetBytes(a);
                byte[] bufB = BitConverter.GetBytes(b);
                byte[] packet = new byte[9];
                Buffer.BlockCopy(bufA, 0, packet, 0, 4);
                Buffer.BlockCopy(bufB, 0, packet, 4, 4);
                packet[8] = op;

                client.Send(packet, packet.Length, serverEP);

                client.Client.ReceiveTimeout = 2000;
                IPEndPoint remote = null;

                byte[] res = client.Receive(ref remote);
                float result = BitConverter.ToSingle(res, 0);
                lblResult.Text = $"Sonuç: {result:F2}";
            }
            catch (SocketException)
            {
                MessageBox.Show("Sunucu yanıt vermedi (timeout). Lütfen tekrar deneyin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // 🧩 Placeholder olayları
        private void txtA_Enter(object sender, EventArgs e)
        {
            if (txtA.Text == "Sayı 1 giriniz")
            {
                txtA.Text = "";
                txtA.ForeColor = Color.Black;
            }
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                txtA.Text = "Sayı 1 giriniz";
                txtA.ForeColor = Color.Gray;
            }
        }

        private void txtB_Enter(object sender, EventArgs e)
        {
            if (txtB.Text == "Sayı 2 giriniz")
            {
                txtB.Text = "";
                txtB.ForeColor = Color.Black;
            }
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                txtB.Text = "Sayı 2 giriniz";
                txtB.ForeColor = Color.Gray;
            }
        }
    }
}
