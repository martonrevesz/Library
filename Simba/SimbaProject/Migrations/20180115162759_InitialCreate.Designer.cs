﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SimbaProject.Entities;
using System;

namespace SimbaProject.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20180115162759_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimbaProject.Models.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Fine");

                    b.Property<string>("Name");

                    b.Property<string>("UserType");

                    b.Property<bool>("VIP");

                    b.HasKey("Id");

                    b.ToTable("ReaderCards");
                });
#pragma warning restore 612, 618
        }
    }
}
