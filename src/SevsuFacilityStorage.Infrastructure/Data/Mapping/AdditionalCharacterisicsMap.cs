using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SevsuFacilityStorage.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Infrastructure.Data.Mapping
{
    class AdditionalCharacterisicsMap : IEntityTypeConfiguration<AdditionalCharacteristics>
    {
        public void Configure(EntityTypeBuilder<AdditionalCharacteristics> builder)
        {
            builder.HasKey(x => new { x.AdditionalId, x.PremisesId });
        }
    }
}
