﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FoxAirlines.Entities;

namespace FoxAirlines.Migrations
{
    [DbContext(typeof(FlightTicketContext))]
    [Migration("20171114133409_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoxAirlines.Models.FlightTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Destination")
                        .IsRequired();

                    b.Property<DateTime>("TakeOffDate");

                    b.HasKey("Id");

                    b.ToTable("FlightTickets");
                });
        }
    }
}
