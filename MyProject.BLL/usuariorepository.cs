using MyProject.MODEL;
using MyProject.DAL.DBContext;

namespace MyProject.BLL
{
    public static class usuarioRepository
    {
        public static void Add(Usuario _usuario)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(_usuario);
                dbContext.SaveChanges();
            }
        }

        public static Usuario GetById(int Id)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var usuario = dbContext.Usuario.Single(p => p.Id == Id);
                return usuario;
            }
        }

        public static List<Usuario> GetAll()
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var usuario = dbContext.Usuario.ToList();
                return usuario;
            }

        }

        public static void Update(Usuario _usuario)
        {

            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var usuario = dbContext.Usuario.Single(p => p.Id == _usuario.Id);
                usuario.Nome = _usuario.Nome;
                usuario.Email = _usuario.Email;
                usuario.Telefone = _usuario.Telefone;
                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Usuario usuario)
        {
            using (var dbContext = new CUsersVictoSourceReposGerenciadorFinannças2MyprojectDalDatabaseDatabase1MdfContext())
            {
                var usuario = dbContext.Usuario.Single(p => p.Id == _usuario.Id);
                dbContext.Remove(usuario);
                dbContext.SaveChanges();
            }
        }

    }
}