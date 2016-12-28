using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Filtros
{
    public class FiltroMaisDe500KDeSaldo : Filtro
    {
        public FiltroMaisDe500KDeSaldo(Filtro f) : base(f) { }
        public FiltroMaisDe500KDeSaldo() : base() { }
        public override IEnumerable<Conta> Filtra(IList<Conta> contas)
        {
            IEnumerable<Conta> filtradas = contas.Where(c => c.Saldo > 500000).ToList();
            IEnumerable<Conta> filtradasDoOutroFiltro = AplicaOutroFiltro(contas);
            IEnumerable<Conta> todas = filtradas.Concat(filtradasDoOutroFiltro);
            return todas;
        }
    }
}
