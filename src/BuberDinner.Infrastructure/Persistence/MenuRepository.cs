using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Menu;

namespace BuberDinner.Infrastructure.Persistence
{
    public class MenuRepository : IMenuRepository
    {
        private readonly BuberDinnerDbContext _context;

        public MenuRepository(BuberDinnerDbContext context)
        {
            _context = context;
        }

        public void Add(Menu menu)
        {
            _context.Add(menu);
            _context.SaveChanges();
        }
    }
}
