using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Filtros
{
    public abstract class Filtro
    {
        protected Filtro outroFiltro { get; set; }
        public Filtro(Filtro outro)
        {
            outroFiltro = outro;
        }
        public Filtro()
        {
            outroFiltro = null;
        }

        public abstract IEnumerable<Conta> Filtra(IList<Conta> contas);

        public IEnumerable<Conta> AplicaOutroFiltro(IList<Conta> contas)
        {
            if (outroFiltro == null)
                return new List<Conta>();
            return outroFiltro.Filtra(contas);
        }
    }
}
