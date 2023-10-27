using MyProject.DAL.DBContext;
using MyProject.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    internal class CategoriaRepository
    {
        public static void Add(Categorium _categoria)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(_categoria);
                dbContext.SaveChanges();
            }
        }

        public static Categorium GetById(int Id)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Categorium = dbContext.Categoria.Single(p => p.Id == Id);
                return Categorium;
            }
        }

        public static List<Categorium> GetAll()
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Categorium = dbContext.Categoria.ToList();
                return Categorium;
            }

        }

        public static void Update(Categorium _categoria)
        {

            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Categorium = dbContext.Categoria.Single(p => p.Id == _categoria.Id);
                Categorium.Nome = _categoria.Nome;
                Categorium.Descricao = _categoria.Descricao;
                Categorium.Id = _categoria.Id;
                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Categorium _categoria)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var Categorium = dbContext.Categoria.Single(p => p.Id == _categoria.Id);
                dbContext.Remove(Categorium);
                dbContext.SaveChanges();
            }
        }
    }
}
