﻿// <auto-generated />
using System;
using LibraryManagementLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManagementLibrary.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AddressPerson", b =>
                {
                    b.Property<int>("AddressesID")
                        .HasColumnType("int");

                    b.Property<int>("PersonsPersonID")
                        .HasColumnType("int");

                    b.HasKey("AddressesID", "PersonsPersonID");

                    b.HasIndex("PersonsPersonID");

                    b.ToTable("AddressPerson");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.Address", b =>
                {
                    b.Property<int>("AddressesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AddressesID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.CheckedBook", b =>
                {
                    b.Property<int>("CheckedBooksID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CheckedBooksID");

                    b.HasIndex("BookID");

                    b.HasIndex("PersonID");

                    b.ToTable("CheckedBooks");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.EmailAddress", b =>
                {
                    b.Property<int>("EmailAddressesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("EmailAddressesID");

                    b.HasIndex("PersonID")
                        .IsUnique();

                    b.ToTable("EmailAddresses");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.Library", b =>
                {
                    b.Property<int>("LibraryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LibraryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LibraryID");

                    b.ToTable("Library");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.LibraryStock", b =>
                {
                    b.Property<int>("LibraryStockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("LibraryStockID");

                    b.HasIndex("BookID");

                    b.HasIndex("LibraryID");

                    b.ToTable("LibraryStocks");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PersonID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("AddressPerson", b =>
                {
                    b.HasOne("LibraryManagementLibrary.Models.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementLibrary.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsPersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.CheckedBook", b =>
                {
                    b.HasOne("LibraryManagementLibrary.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementLibrary.Models.Person", "Person")
                        .WithMany("CheckedBooks")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.EmailAddress", b =>
                {
                    b.HasOne("LibraryManagementLibrary.Models.Person", "Person")
                        .WithOne("EmailAddress")
                        .HasForeignKey("LibraryManagementLibrary.Models.EmailAddress", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.LibraryStock", b =>
                {
                    b.HasOne("LibraryManagementLibrary.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementLibrary.Models.Library", "Library")
                        .WithMany()
                        .HasForeignKey("LibraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("LibraryManagementLibrary.Models.Person", b =>
                {
                    b.Navigation("CheckedBooks");

                    b.Navigation("EmailAddress")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
