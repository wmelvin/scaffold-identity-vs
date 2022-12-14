// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demo_webapp.Data;

#nullable disable

namespace demowebapp.Migrations
{
    [DbContext(typeof(UploadContext))]
    partial class UploadContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("demo_webapp.Data.Upload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContentType")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("User_Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("WhenUploaded")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Uploads");
                });
#pragma warning restore 612, 618
        }
    }
}
