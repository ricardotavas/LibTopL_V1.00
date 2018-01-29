using System;
using System.Windows.Forms;
using LibTopL;

namespace App
{
    public partial class Form1 : Form
    {
        ITopL TOPL = null;
        private bool usbConnected = false;

        public Form1()
        {
            InitializeComponent();
            Connect_TOPL();
            timer1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Encerra o recebimento dos pacotes USB
            TOPL.StopListening();
        }

        private void PrintResultServer()
        {
            textStatus.Text += TOPL._status + Convert.ToChar(13) + Convert.ToChar(10);
            textStatus.Refresh();
        }

        private void button_ReadDateTime_Click(object sender, EventArgs e)
        {
            if (usbConnected)
            {
                if (TOPL.GetDateTime())
                {
                    if (TOPL._dateTime != "")
                        dt.Value = DateTime.Parse(TOPL._dateTime);
                }
                PrintResultServer();
            }
        }

        private void button_WriteDateTime_Click(object sender, EventArgs e)
        {
            if (usbConnected)
            {
                TOPL.SetDateTime(dt.Value.ToString());
                PrintResultServer();
            }
        }

        private void button_enable_Click(object sender, EventArgs e)
        {
            if (usbConnected)
            {
                TOPL.StatusSurvey(1, true);
                PrintResultServer();
            }
        }

        private void button_disable_Click(object sender, EventArgs e)
        {
            if (usbConnected)
            {
                TOPL.StatusSurvey(1, false);
                PrintResultServer();
            }
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            if (usbConnected)
            {
                while (TOPL.GetResult())
                    PrintResultServer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TOPL._isPlugued == false)
            {
                usbConnected = false;
                label_connect.Text = "Teclado desconectado";
            }

            if (usbConnected)
            {
                if (TOPL._newInfo)
                {
                    TOPL._newInfo = false;
                    if (TOPL._numResults != 0)
                    {
                        DialogResult x = MessageBox.Show("O teclado conectado tem " + TOPL._numResults + " votos disponíveis. Deseja fazer a transferência dos dados agora?", "Novas informações de pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (x == DialogResult.Yes)
                        {
                            // Busca informações de voto
                            while (TOPL.GetResult())
                                PrintResultServer();
                            MessageBox.Show("Chegamos ao fim dos votos", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else if (TOPL._isPlugued)
            {
                Connect_TOPL();
            }

            if (TOPL._newResult)
            {
                TOPL._newResult = false;
                textStatus.Text += "Novo resultado: '" + TOPL._resultVote + "'" + Convert.ToChar(13) + Convert.ToChar(10);
                textStatus.Refresh();
            }
        }

        private void Connect_TOPL()
        {
            // Cria interface do teclado TOPL
            TOPL = new LibTopL.TopL();
            // Inicia recebimento de pacotes USB
            TOPL.StartListening();
            // Conecta com o teclado
            if (TOPL.Connect())
            {
                usbConnected = true;
                label_connect.Text = "Teclado conectado";

                // Busca voltagem da bateria
                TOPL.GetVoltage();
                label_Voltage.Text = Convert.ToString(TOPL._voltage) + "V";
                PrintResultServer();
            }
        }
    }
}
