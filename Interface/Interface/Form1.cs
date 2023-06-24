using System.IO.Ports;

namespace Interface
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            portaSerial = new SerialPort("COM3", 9600); // Defina a porta COM correta e a taxa de transmiss�o adequada
        }

        private void Form1_Load_1(object sender, EventArgs e)
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
                btnLigarDesligarArduino.Text = "Ligar Arduino";
            }
            else
            {
                EnviarComandoParaArduino(pinoSensor, HIGH);
                arduinoLigado = true;
                btnLigarDesligarArduino.Text = "Desligar Arduino";
            }
        }

        private void btnLampada_Click_1(object sender, EventArgs e)
        {
            if (lampadaLigado)
            {
                btnLampada.Text = "Ligar Lampada";
                EnviarComandoParaArduino(pinoLampada, LOW);
                lampadaLigado = false;
            }
            else
            {
                btnLampada.Text = "Desligar Lampada";
                EnviarComandoParaArduino(pinoLampada, HIGH);
                lampadaLigado = true;  
            }
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
                MessageBox.Show("A porta serial n�o est� aberta.");
            }
        }
    }
}


//int pinoSensor = 4;
//int pinoLampada = 5;
//int pinoFumaca = 3;
//int pinoBip = 7;

//bool ativo = false;
//unsigned long inicioAtivacao;

//void setup()
//{
//    pinMode(pinoSensor, INPUT);
//    pinMode(pinoLampada, OUTPUT);
//    pinMode(pinoFumaca, OUTPUT);
//    pinMode(pinoBip, OUTPUT);
//    Serial.begin(9600);
//}

//void loop()
//{
//    if (Serial.available() > 0)
//    {
//        String comando = Serial.readStringUntil('\n'); 

//        int pino = comando.toInt(); 

//        if (pino == pinoSensor)
//        {
//            if (!ativo)
//            {
//                ativo = true;
//                inicioAtivacao = millis();
//                Serial.println("Sensor ativado");
//                Serial.print("Tempo de inicio: ");
//                Serial.println(inicioAtivacao);
//            }
//            digitalWrite(pinoLampada, HIGH);
//            digitalWrite(pinoFumaca, HIGH);
//            digitalWrite(pinoBip, HIGH);
//            tone(pinoBip, 1000);
//        }
//        else if (pino == pinoLampada)
//        {
//           digitalWrite(pinoLampada, HIGH); 
//        }

//        Serial.print("Pino recebido: ");
//        Serial.println(pino);
//    }
//}
