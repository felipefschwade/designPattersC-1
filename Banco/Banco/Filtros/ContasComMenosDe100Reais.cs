using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco.Filtros
{
    class ContasComMenosDe100Reais : Filtro
    {
        public ContasComMenosDe100Reais(Filtro f) : base(f) { }
        public ContasComMenosDe100Reais() : base() {}
        public override IEnumerable<Conta> Filtra(IList<Conta> contas)
        {
            IEnumerable<Conta> filtradas = contas.Where(c => c.Saldo < 100).ToList();
            IEnumerable<Conta> filtradasDoOutroFiltro = AplicaOutroFiltro(contas);
            IEnumerable<Conta> todas = filtradas.Concat(filtradasDoOutroFiltro);
            return todas;
        }
    }
}
