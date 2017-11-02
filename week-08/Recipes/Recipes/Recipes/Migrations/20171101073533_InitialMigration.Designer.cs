using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Recipes.Entities;

namespace Recipes.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20171101073533_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Recipes.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cuisine");

                    b.Property<bool>("IsVegetarian");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("PreparationTimeInMinutes");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });
        }
    }
}
