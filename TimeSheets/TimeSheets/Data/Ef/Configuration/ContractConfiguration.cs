using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeSheets.Models;

namespace TimeSheets.Data.Configuration
{
    public class ContractConfiguration: IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts");

            builder.HasOne(contract => contract.Client)
                .WithMany(client => client.Contracts)
                .HasForeignKey("ClientId");
        }
    }
}