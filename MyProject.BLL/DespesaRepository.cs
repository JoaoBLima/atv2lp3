using MyProject.DAL.DBContext;
using MyProject.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    internal class DespesaRepository
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
