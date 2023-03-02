namespace PrincipiosSOLID.ISP
{
    // Separando o IRepository<T> em duas interfaces eu não forço a classe a implementar métodos desnecessários
    public class GymUnitRepository : IReadOnlyRepository<GymUnit> // IRepository<GymUnit>
    {
        private readonly GymDbContext _context;

        public GymUnitRepository(GymDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<GymUnit> GetAll()
        {
            return _context.Gyms;
        }

        public GymUnit GetById(Guid id)
        {
            return _context.Gyms.SingleOrDefault(gym => gym.Id == id);
        }
    }
}
