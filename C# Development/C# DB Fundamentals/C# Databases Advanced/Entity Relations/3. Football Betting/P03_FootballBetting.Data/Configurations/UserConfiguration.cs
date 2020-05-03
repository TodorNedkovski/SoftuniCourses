﻿namespace P03_FootballBetting.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P03_FootballBetting.Data.Models;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user
                .HasKey(u => u.UserId);

            user
                .HasMany(u => u.Bets)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId);
        }
    }
}