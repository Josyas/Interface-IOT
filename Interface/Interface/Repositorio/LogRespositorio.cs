using Dapper;
using Interface.ConexaoDB;
using Interface.Endidades;
using System.Data;

namespace Interface.Repositorio
{
    public class LogRespositorio
    {
        private readonly AppDbContext _dbContext;

        public LogRespositorio()
        {
            AppDbContext dbContext = new();
            _dbContext = dbContext;
        }

        public void CadastroLog(string nome, DateTime data)
        {
            using (IDbConnection db = _dbContext.PegarConexao())
            {
                string query = "Insert Into LogIot (NomeLog, DataLog) Values (@NomeLog, @DataLog)";

                db.Query(query, new {NomeLog = nome, DataLog = data});

                _dbContext.FecharConexao();
            }
        }

        public List<LogIot> ListaLog()
        {
            using (IDbConnection db = _dbContext.PegarConexao())
            {
                string query = "SELECT * FROM LogIot";

                var lista = db.Query<LogIot>(query).ToList();

                _dbContext.FecharConexao();

                return lista;
            }
        }
    }
}
