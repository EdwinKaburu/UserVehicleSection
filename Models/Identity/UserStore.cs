using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UserVehicleSection.Models.Identity
{
    public class UserStore : IUserStore<UserDb>, IUserPasswordStore<UserDb>
    {
        private readonly UserSectionContext db;

        public UserStore(UserSectionContext db)
        {
            this.db = db;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db?.Dispose();
            }
        }

        public Task<string> GetUserIdAsync(UserDb user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserId.ToString());
        }

        public Task<string> GetUserNameAsync(UserDb user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task SetUserNameAsync(UserDb user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(nameof(SetUserNameAsync));
        }

        public Task<string> GetNormalizedUserNameAsync(UserDb user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(nameof(GetNormalizedUserNameAsync));
        }

        public Task SetNormalizedUserNameAsync(UserDb user, string normalizedName, CancellationToken cancellationToken)
        {
            return Task.FromResult((object)null);
        }

        public async Task<IdentityResult> CreateAsync(UserDb user, CancellationToken cancellationToken)
        {
            db.Add(user);

            await db.SaveChangesAsync(cancellationToken);

            return await Task.FromResult(IdentityResult.Success);
        }

        public Task<IdentityResult> UpdateAsync(UserDb user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(nameof(UpdateAsync));
        }

        public async Task<IdentityResult> DeleteAsync(UserDb user, CancellationToken cancellationToken)
        {
            db.Remove(user);

            int i = await db.SaveChangesAsync(cancellationToken);

            return await Task.FromResult(i == 1 ? IdentityResult.Success : IdentityResult.Failed());
        }

        public async Task<UserDb> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            if (int.TryParse(userId, out int id))
            {
                return await db.UserDb.FindAsync(id);
            }
            else
            {
                return await Task.FromResult((UserDb)null);
            }
        }

        public async Task<UserDb> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return await db.UserDb.Where(n => n.UserName.ToLower().Equals(normalizedUserName.ToLower())).FirstOrDefaultAsync();
        }

        public Task SetPasswordHashAsync(UserDb user, string passwordHash, CancellationToken cancellationToken)
        {
            user.UserPassword = passwordHash;

            return Task.FromResult((object)null);
        }

        public Task<string> GetPasswordHashAsync(UserDb user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserPassword);
        }

        public Task<bool> HasPasswordAsync(UserDb user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrWhiteSpace(user.UserPassword));
        }
    }
}
