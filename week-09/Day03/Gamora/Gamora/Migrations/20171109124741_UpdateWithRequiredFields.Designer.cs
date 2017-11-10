using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Gamora.Entities;

namespace Gamora.Migrations
{
    [DbContext(typeof(SongContext))]
    [Migration("20171109124741_UpdateWithRequiredFields")]
    partial class UpdateWithRequiredFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gamora.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Rating");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Songs");
                });
        }
    }
}
