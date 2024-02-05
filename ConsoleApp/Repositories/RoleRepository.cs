using ConsoleApp.Contexts;
using ConsoleApp.Entites;

namespace ConsoleApp.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
