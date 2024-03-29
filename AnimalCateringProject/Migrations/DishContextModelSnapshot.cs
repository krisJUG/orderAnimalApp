﻿// <auto-generated />
using AnimalCateringProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalCateringProject.Migrations
{
    [DbContext(typeof(DishContext))]
    partial class DishContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnimalCateringProject.Models.Dish", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("AnimalCateringProject.Models.OrderedDish", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DishId");

                    b.HasKey("Id");

                    b.ToTable("OrderedDish");
                });
#pragma warning restore 612, 618
        }
    }
}
