using Microsoft.EntityFrameworkCore.Storage;
using Doodle.Social.Infrastructure.Repository.Data.Contexts;
using Doodle.Social.Infrastructure.Repository.Data;

namespace Doodle.Social.Infrastructure.Repository.Data
{
    public interface IDatabaseTransaction
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
    }

    public class DoodleDatabaseTransaction : IDatabaseTransaction
    {
        private readonly SocialDbContext _context;

        public DoodleDatabaseTransaction(SocialDbContext context) => _context = context;

        public Task<IDbContextTransaction> BeginTransactionAsync() => _context.Database.BeginTransactionAsync();
    }
}
