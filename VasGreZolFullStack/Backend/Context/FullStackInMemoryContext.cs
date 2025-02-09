using Microsoft.EntityFrameworkCore;

namespace VasGreZolFullStack.Backend.Context
{
    public class FullStackInMemoryContext : FullStackContext
    {
        public FullStackInMemoryContext(DbContextOptions<FullStackContext> options) : base(options) { }
    }
}
