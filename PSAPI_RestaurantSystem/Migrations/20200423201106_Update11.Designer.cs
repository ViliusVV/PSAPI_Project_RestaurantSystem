﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSAPIRestaurantSystem;

namespace PSAPIRestaurantSystem.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20200423201106_Update11")]
    partial class Update11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("WorkEmail")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AdminId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BeganWork")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EmployeeState")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndedWork")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("RegisteredByAdminId")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("RegisteredByAdminId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Changed")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MenuId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.MenuEntry", b =>
                {
                    b.Property<int>("MenuEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Changed")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MenuEntryName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("MenuEntryId");

                    b.ToTable("MenuEntries");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Order", b =>
                {
                    b.Property<int>("OrderNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("OrderNum");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.OrderedMeal", b =>
                {
                    b.Property<int>("OrderedMealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderedMealId");

                    b.ToTable("OrderedMeals");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PeopleCount")
                        .HasColumnType("int");

                    b.Property<int>("ReservedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ReservedForDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("ReservedByUserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ReviewText")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Table", b =>
                {
                    b.Property<int>("TableNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int");

                    b.HasKey("TableNum");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.TakeoutOrder", b =>
                {
                    b.Property<int>("TakeoutOrderNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ConfirmationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("OrderedForDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("TakeoutOrderNum");

                    b.ToTable("TakeoutOrders");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LoyalityPoints")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Waiter", b =>
                {
                    b.Property<int>("WaiterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<double>("Tips")
                        .HasColumnType("double");

                    b.HasKey("WaiterId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Waiters");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Admin", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Employee", "Employee")
                        .WithOne("Admin")
                        .HasForeignKey("PSAPIRestaurantSystem.Models.Admin", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Employee", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Admin", "RegisteredBy")
                        .WithMany("RegisteredEmployees")
                        .HasForeignKey("RegisteredByAdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSAPIRestaurantSystem.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("PSAPIRestaurantSystem.Models.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Reservation", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.User", "ReservedBy")
                        .WithMany("Reservations")
                        .HasForeignKey("ReservedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Review", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.User", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Person", "Person")
                        .WithOne("User")
                        .HasForeignKey("PSAPIRestaurantSystem.Models.User", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Waiter", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Employee", "Employee")
                        .WithOne("Waiter")
                        .HasForeignKey("PSAPIRestaurantSystem.Models.Waiter", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
