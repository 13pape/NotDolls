using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NotDolls.Models;

namespace NotDolls.Migrations
{
    [DbContext(typeof(NotDollsContext))]
    [Migration("20160606181659_NukeFromOrbit")]
    partial class NukeFromOrbit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotDolls.Models.Geek", b =>
                {
                    b.Property<int>("GeekId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_Date");

                    b.Property<string>("Email");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Location");

                    b.Property<string>("Username");

                    b.HasKey("GeekId");

                    b.ToTable("Geek");
                });

            modelBuilder.Entity("NotDolls.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDated");

                    b.Property<int>("GeekId");

                    b.Property<string>("Height");

                    b.Property<string>("InventoryDescription");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("Quality");

                    b.Property<int>("Quantity");

                    b.Property<bool>("Sold");

                    b.Property<string>("Weight");

                    b.Property<int>("Year");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("NotDolls.Models.InventoryImage", b =>
                {
                    b.Property<int>("InventoryImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<int>("InventoryId");

                    b.HasKey("InventoryImageId");

                    b.ToTable("InventoryImage");
                });
        }
    }
}
