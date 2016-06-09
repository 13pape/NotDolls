using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NotDolls.Models;

namespace NotDolls.Migrations
{
    [DbContext(typeof(NotDollsContext))]
    partial class NotDollsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotDolls.Models.Geek", b =>
                {
                    b.Property<int>("GeekId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_Date");

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

                    b.HasIndex("GeekId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("NotDolls.Models.InventoryImage", b =>
                {
                    b.Property<int>("InventoryImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<int>("InventoryId");

                    b.Property<string>("MetaData");

                    b.HasKey("InventoryImageId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryImage");
                });

            modelBuilder.Entity("NotDolls.Models.Inventory", b =>
                {
                    b.HasOne("NotDolls.Models.Geek")
                        .WithMany()
                        .HasForeignKey("GeekId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NotDolls.Models.InventoryImage", b =>
                {
                    b.HasOne("NotDolls.Models.Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
