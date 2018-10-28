using Afazeres.Models;
using System.Data.Entity.ModelConfiguration;

namespace Afazeres.Mapping
{
    public class AfazeresMap : EntityTypeConfiguration<Afazer>
    {
        public AfazeresMap()
        {
            ToTable("AFAZER");
            HasKey(x => x.IDAFAZER);
        }
    }
}