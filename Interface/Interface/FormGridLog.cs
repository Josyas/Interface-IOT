using Interface.Repositorio;

namespace Interface
{
    public partial class FormGridLog : Form
    {
        LogRespositorio _respositorio = new();

        public FormGridLog()
        {
            InitializeComponent();
        }

        private void FormGridLog_Load(object sender, EventArgs e)
        {
           ListaLog();
        }

        public void ListaLog()
        {
            var logs = _respositorio.ListaLog();

            dataGridViewLog.Rows.Clear();

            foreach (var log in logs)
            {
                string dataHoraLog = String.Format("{0:MM/dd/yyyy HH:mm:ss}", log.DataLog);

                dataGridViewLog.Rows.Add(log.IdLog, log.NomeLog, dataHoraLog);
            }
        }
    }
}
