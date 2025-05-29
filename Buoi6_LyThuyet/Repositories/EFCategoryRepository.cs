namespace Buoi6_LyThuyet.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public EFCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Tương tự như EFProductRepository, nhưng cho Category 
    }
}
