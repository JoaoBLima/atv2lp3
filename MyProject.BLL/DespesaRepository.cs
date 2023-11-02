using MyProject.DAL.DBContext;
using MyProject.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class DespesaRepository
    {
        public static void Add(Despesa _despesa)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(_despesa);
                dbContext.SaveChanges();
            }
        }

        public static Despesa GetById(int Id)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Despesa = dbContext.Despesas.Single(p => p.Id == Id);
                return Despesa;
            }
        }

        public static decimal getSoma()
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var valores = dbContext.Despesas.Select(r => r.Valor).ToList();

                decimal somaTotal = 0;

                foreach (var receita in valores)
                {
                    somaTotal = (decimal)(somaTotal + receita);
                }

                return somaTotal;
            }

        }

        public static List<Despesa> GetAll()
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Despesa = dbContext.Despesas.ToList();
                return Despesa;
            }

        }

        public static void Update(Despesa _despesa)
        {

            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Despesa = dbContext.Despesas.Single(p => p.Id == _despesa.Id);
                Despesa.Valor = _despesa.Valor;
                Despesa.Data = _despesa.Data;
                Despesa.Idusuario = _despesa.Idusuario;
                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Despesa _despesa)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Despesa = dbContext.Despesas.Single(p => p.Id == _despesa.Id);
                dbContext.Remove(Despesa);
                dbContext.SaveChanges();
            }
        }
    }
}
