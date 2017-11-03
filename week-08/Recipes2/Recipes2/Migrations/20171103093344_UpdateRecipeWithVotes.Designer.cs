using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Recipes2.Entities;

namespace Recipes2.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20171103093344_UpdateRecipeWithVotes")]
    partial class UpdateRecipeWithVotes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Recipes2.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cuisine")
                        .HasMaxLength(50);

                    b.Property<bool>("IsVegetarian");

                    b.Property<string>("Level")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PreparationTimeInMinutes");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });
        }
    }
}
