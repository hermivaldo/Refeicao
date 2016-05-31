
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApp.DATA
{
    public class RefeicaoDAO
    {

        private SQLiteConnection conexao;

        public RefeicaoDAO(SQLiteConnection con)
        {
            this.conexao = con;
            this.conexao.CreateTable<Refeicao>();
        }

        internal void Salvar(Refeicao refeicao)
        {
            conexao.Insert(refeicao);
        }
    }
}
