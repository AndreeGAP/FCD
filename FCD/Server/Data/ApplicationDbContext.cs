using Duende.IdentityServer.EntityFramework.Options;
using FCD.Server.Models;
using FCD.Shared.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FCD.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        // Agregando modelo Pregunta al db set
        public virtual DbSet<Pregunta>? preguntas { get; set; }


    }
}