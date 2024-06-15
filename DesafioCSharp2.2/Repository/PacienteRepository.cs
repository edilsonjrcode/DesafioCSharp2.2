using DesafioCSharp2._2.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharp2._2.Repository {
    internal class PacienteRepository {

        private List<Consulta> consultas;

        public void AgendarConsulta(Consulta consulta) {
            consultas.Add(consulta);
        }

        public void CancelarConsulta(Consulta consulta) {
            consultas.Remove(consulta);
        }

        public List<Consulta> ListarConsulta() {
            return consultas;
        }

    }
}
