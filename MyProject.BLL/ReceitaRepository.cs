using MyProject.DAL.DBContext;
using MyProject.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class ReceitaRepository
    {
        public static void Add(Receita _receita)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(_receita);
                dbContext.SaveChanges();
            }
        }

        public static Receita GetById(int Id)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Receita = dbContext.Receitas.Single(p => p.Id == Id);
                return Receita;
            }
        }

        public static List<Receita> GetAll()
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Receita = dbContext.Receitas.ToList();
                return Receita;
            }

        }

        public static decimal getSoma()
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var valores = dbContext.Receitas.Select(r => r.Valor).ToList();

                decimal somaTotal = 0;

                foreach (var receita in valores)
                {
                    somaTotal = (decimal)(somaTotal + receita);
                }

                return somaTotal;
            }

        }

        public static void Update(Receita _receita)
        {

            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Receita = dbContext.Receitas.Single(p => p.Id == _receita.Id);
                Receita.Valor = _receita.Valor;
                Receita.Data = _receita.Data;
                Receita.Idusuario = _receita.Idusuario;
                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Receita _receita)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Receita = dbContext.Receitas.Single(p => p.Id == _receita.Id);
                dbContext.Remove(Receita);
                dbContext.SaveChanges();
            }
        }
    }

}
