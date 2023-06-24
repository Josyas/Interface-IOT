using Interface.Endidades;
using Interface.Repositorio;
using System.IO.Ports;

namespace Interface
{
    public partial class Form2 : Form
    {
        public SerialPort portaSerial;
        private int pinoSensor = 4;
        private int pinoLampada = 5;
        private int pinoFumaca = 3;
        private int pinoBip = 7;

        private const int HIGH = 1;
        private const int LOW = 0;

        private bool arduinoLigado = false;
        private bool lampadaLigado = false;
        private bool fumacaLigado = false;
        private bool somLigado = false;

        public Form2()
        {
            InitializeComponent();
            portaSerial = new SerialPort("COM3", 9600); // Defina a porta COM correta e a taxa de transmissão adequada
            portaSerial.DataReceived += PortaSerial_DataReceived;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            try
            {
                portaSerial.Open();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Erro ao abrir a porta serial: " + ex.Message);
            }
        }

        private void btnLigarDesligarArduino_Click_1(object sender, EventArgs e)
        {
            if (arduinoLigado)
            {
                var teste = 9;
                EnviarComandoParaArduino(pinoSensor, teste);
                arduinoLigado = false;
            }
            else
            {
                EnviarComandoParaArduino(pinoSensor, HIGH);
                arduinoLigado = true;
            }
        }

        private void btnLampada_Click_1(object sender, EventArgs e)
        {
            if (lampadaLigado)
            {
                var desligarLampada = pinoLampada;
                btnLampada.Text = "Ligar Lampada";
                EnviarComandoParaArduino(desligarLampada, LOW);
                lampadaLigado = false;
            }
            else
            {
                btnLampada.Text = "Desligar Lampada";
                EnviarComandoParaArduino(pinoLampada, HIGH);
                lampadaLigado = true;
            }
        }

        private void desligarFumaca_Click_1(object sender, EventArgs e)
        {
            if (fumacaLigado)
            {
                var desligaFumaca = pinoFumaca;
                desligarFumaca.Text = "Ligar Fumaça";
                EnviarComandoParaArduino(desligaFumaca, LOW);
                fumacaLigado = false;
            }
            else
            {
                desligarFumaca.Text = "Desligar Fumaça";
                EnviarComandoParaArduino(pinoFumaca, HIGH);
                fumacaLigado = true;
            }
        }

        private void desligaSom_Click_1(object sender, EventArgs e)
        {
            if (somLigado)
            {
                desligaSom.Text = "Ligar Som";
                EnviarComandoParaArduino(pinoBip, LOW);
                somLigado = false;
            }
            else
            {
                desligaSom.Text = "Desligar Som";
                EnviarComandoParaArduino(pinoBip, HIGH);
                somLigado = true;
            }
        }

        private void logAcesso_Click_1(object sender, EventArgs e)
        {
            FormGridLog formGridLog = new();
            formGridLog.ShowDialog();
        }

        private void EnviarComandoParaArduino(int pino, int valor)
        {
            if (portaSerial.IsOpen)
            {
                try
                {
                    string comando = $"{pino}:{valor}";
                    portaSerial.WriteLine(comando);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar comando para o Arduino: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A porta serial não está aberta.");
            }
        }

        private void PortaSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string resposta = portaSerial.ReadLine();

            LogIot log = new()
            {
                NomeLog = resposta,
                DataLog = DateTime.Now
            };

            LogRespositorio logRespositorio = new();
            logRespositorio.CadastroLog(log.NomeLog, log.DataLog);
        }
    }
}
