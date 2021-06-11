using Umbraco.Cms.Core.Composing;

namespace Umbraco.Cms.Core.Migrations
{
    /// <summary>
    /// Represents a migration.
    /// </summary>
    public interface IMigration
    {
        /// <summary>
        /// Executes the migration.
        /// </summary>
        void Migrate();
    }
}
