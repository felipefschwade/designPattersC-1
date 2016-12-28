using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Filtros
{
    class FiltroMesCorrente : Filtro
    {
        public FiltroMesCorrente(Filtro f) : base(f) { }
        public FiltroMesCorrente() : base() { }
        public override IEnumerable<Conta> Filtra(IList<Conta> contas)
        {
            IEnumerable<Conta> filtradas = contas.Where(c => c.DataDeCriacao.Month == DateTime.Now.Month).ToList();
            IEnumerable<Conta> filtradasDoOutroFiltro = AplicaOutroFiltro(contas);
            IEnumerable<Conta> todas = filtradas.Concat(filtradasDoOutroFiltro);
            return todas;
        }
    }
}
