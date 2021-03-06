// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(PackageContext))]
    partial class PackageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chute")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ContainerId")
                        .HasColumnType("int");

                    b.Property<string>("Courier")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DeliverySlip")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Handling")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrackingNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Packages");
                });
#pragma warning restore 612, 618
        }
    }
}
