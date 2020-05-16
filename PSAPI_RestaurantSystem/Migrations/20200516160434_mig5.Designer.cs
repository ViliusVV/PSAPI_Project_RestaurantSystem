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
    [Migration("20200516160434_mig5")]
    partial class mig5
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

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            EmployeeId = 1,
                            WorkEmail = "workmail@mymail.com"
                        });
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

                    b.Property<int?>("RegisteredByAdminId")
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

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BeganWork = new DateTime(2020, 5, 16, 19, 4, 33, 698, DateTimeKind.Local).AddTicks(1437),
                            EmployeeState = 1,
                            EndedWork = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Salary = 1000,
                            UserId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            BeganWork = new DateTime(2020, 5, 16, 19, 4, 33, 698, DateTimeKind.Local).AddTicks(2758),
                            EmployeeState = 1,
                            EndedWork = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Salary = 3000,
                            UserId = 2
                        });
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

                    b.HasData(
                        new
                        {
                            MenuId = 1,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 693, DateTimeKind.Local).AddTicks(1210),
                            Title = "Sriubos"
                        },
                        new
                        {
                            MenuId = 2,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1040),
                            Title = "Užkandžiai"
                        },
                        new
                        {
                            MenuId = 3,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1114),
                            Title = "Salotos"
                        },
                        new
                        {
                            MenuId = 4,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1118),
                            Title = "Kiauliena"
                        },
                        new
                        {
                            MenuId = 5,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1122),
                            Title = "Vistiena"
                        },
                        new
                        {
                            MenuId = 6,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1122),
                            Title = "Zuvis"
                        },
                        new
                        {
                            MenuId = 7,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1126),
                            Title = "Miltiniai patiekalai"
                        },
                        new
                        {
                            MenuId = 8,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1130),
                            Title = "Gaivieji gėrimai"
                        },
                        new
                        {
                            MenuId = 9,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1134),
                            Title = "Alus"
                        },
                        new
                        {
                            MenuId = 10,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1138),
                            Title = "Šampanas"
                        },
                        new
                        {
                            MenuId = 11,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1138),
                            Title = "Konjakas"
                        },
                        new
                        {
                            MenuId = 12,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1142),
                            Title = "Degtinė"
                        },
                        new
                        {
                            MenuId = 13,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1146),
                            Title = "Brendis"
                        },
                        new
                        {
                            MenuId = 14,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1150),
                            Title = "Vynas"
                        },
                        new
                        {
                            MenuId = 15,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1155),
                            Title = "Sidras"
                        },
                        new
                        {
                            MenuId = 16,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1159),
                            Title = "Burbonas"
                        },
                        new
                        {
                            MenuId = 17,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1159),
                            Title = "Džinas"
                        },
                        new
                        {
                            MenuId = 18,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(1163),
                            Title = "Viskis"
                        });
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

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("MenuEntryId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuEntries");

                    b.HasData(
                        new
                        {
                            MenuEntryId = 1,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(5667),
                            MenuEntryName = "Dienos sriuba",
                            MenuId = 1,
                            Price = 1.2
                        },
                        new
                        {
                            MenuEntryId = 2,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6274),
                            MenuEntryName = "Čili",
                            MenuId = 1,
                            Price = 3.0
                        },
                        new
                        {
                            MenuEntryId = 3,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6303),
                            MenuEntryName = "Cibulynė",
                            MenuId = 1,
                            Price = 2.0
                        },
                        new
                        {
                            MenuEntryId = 4,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6307),
                            MenuEntryName = "Šaltibarščiai",
                            MenuId = 1,
                            Price = 2.5
                        },
                        new
                        {
                            MenuEntryId = 5,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6311),
                            MenuEntryName = "Šviežių daržovių salotos",
                            MenuId = 3,
                            Price = 3.0
                        },
                        new
                        {
                            MenuEntryId = 6,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6315),
                            MenuEntryName = "Sveikuolių salotos ",
                            MenuId = 3,
                            Price = 3.5
                        },
                        new
                        {
                            MenuEntryId = 7,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6319),
                            MenuEntryName = "Vištienos salotos",
                            MenuId = 3,
                            Price = 3.5
                        },
                        new
                        {
                            MenuEntryId = 8,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6324),
                            MenuEntryName = "Graikiškos salotos ",
                            MenuId = 3,
                            Price = 4.5
                        },
                        new
                        {
                            MenuEntryId = 9,
                            Changed = new DateTime(2020, 5, 16, 19, 4, 33, 696, DateTimeKind.Local).AddTicks(6324),
                            MenuEntryName = "Burokėlių salotos su fetos sūriu ",
                            MenuId = 3,
                            Price = 4.5
                        });
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Order", b =>
                {
                    b.Property<int>("OrderNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("ManagedByWaiterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("OrderNum");

                    b.HasIndex("ManagedByWaiterId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.OrderedMeal", b =>
                {
                    b.Property<int>("OrderedMealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("InOrderOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("InOrderOrderNum")
                        .HasColumnType("int");

                    b.Property<int>("InTakeoutTakeoutOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("InTakeoutTakeoutOrderNum")
                        .HasColumnType("int");

                    b.Property<int>("MenuEntryId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderedMealId");

                    b.HasIndex("InOrderOrderNum");

                    b.HasIndex("InTakeoutTakeoutOrderNum");

                    b.HasIndex("MenuEntryId");

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

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Name = "Jonas",
                            Surname = "Petraitis"
                        },
                        new
                        {
                            PersonId = 2,
                            Name = "Mantas",
                            Surname = "Jablonoskis"
                        },
                        new
                        {
                            PersonId = 3,
                            Name = "Tomas",
                            Surname = "Tomaitis"
                        },
                        new
                        {
                            PersonId = 4,
                            Name = "Petras",
                            Surname = "Petraitis"
                        });
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

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Rating = 2,
                            ReviewDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(8044),
                            ReviewText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum.",
                            UserId = 1
                        },
                        new
                        {
                            ReviewId = 2,
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(9140),
                            ReviewText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum.",
                            UserId = 2
                        },
                        new
                        {
                            ReviewId = 3,
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(9169),
                            ReviewText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam consectetur tincidunt justo ac sollicitudin. Quisque erat mauris, malesuada in sapien quis, accumsan condimentum dui. Curabitur porttitor nibh in odio ultrices, eget efficitur arcu sollicitudin. Quisque at eros lectus. Vestibulum et bibendum arcu. Nunc a nulla consequat leo congue egestas eget in enim. Aliquam dictum ultricies arcu, finibus accumsan nisi imperdiet sed. Curabitur ac nibh tellus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras porta cursus odio eget volutpat. Praesent tristique sollicitudin lacus, vel faucibus nisl vestibulum nec. Vestibulum iaculis nulla eu risus mattis, quis finibus risus bibendum.",
                            UserId = 3
                        });
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

                    b.HasData(
                        new
                        {
                            TableNum = 1,
                            SeatCount = 4
                        },
                        new
                        {
                            TableNum = 2,
                            SeatCount = 2
                        },
                        new
                        {
                            TableNum = 3,
                            SeatCount = 4
                        },
                        new
                        {
                            TableNum = 4,
                            SeatCount = 5
                        },
                        new
                        {
                            TableNum = 5,
                            SeatCount = 12
                        },
                        new
                        {
                            TableNum = 6,
                            SeatCount = 12
                        },
                        new
                        {
                            TableNum = 7,
                            SeatCount = 4
                        },
                        new
                        {
                            TableNum = 8,
                            SeatCount = 4
                        },
                        new
                        {
                            TableNum = 9,
                            SeatCount = 2
                        },
                        new
                        {
                            TableNum = 10,
                            SeatCount = 2
                        },
                        new
                        {
                            TableNum = 11,
                            SeatCount = 6
                        },
                        new
                        {
                            TableNum = 12,
                            SeatCount = 6
                        });
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.TableOccupancy", b =>
                {
                    b.Property<int>("TableOccupancyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("TableOccupancyId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("TableId");

                    b.ToTable("TableOccupancies");
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.TakeoutOrder", b =>
                {
                    b.Property<int>("TakeoutOrderNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ConfirmationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ManagedByWaiterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OrderedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderedForDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("TakeoutOrderNum");

                    b.HasIndex("ManagedByWaiterId");

                    b.HasIndex("OrderedByUserId");

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

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Confirmed = true,
                            Email = "jonas@emai.com",
                            LastLoginDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(1924),
                            LoyalityPoints = 1,
                            Password = "slaptozodis",
                            PersonId = 1,
                            RegistrationDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(1316)
                        },
                        new
                        {
                            UserId = 2,
                            Confirmed = true,
                            Email = "mantas@email.com",
                            LastLoginDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(5378),
                            LoyalityPoints = 10,
                            Password = "slaptozodis",
                            PersonId = 2,
                            RegistrationDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(5341)
                        },
                        new
                        {
                            UserId = 3,
                            Confirmed = true,
                            Email = "tomas@email.com",
                            LastLoginDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(5415),
                            LoyalityPoints = 20,
                            Password = "slaptozodis",
                            PersonId = 3,
                            RegistrationDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(5411)
                        },
                        new
                        {
                            UserId = 4,
                            Confirmed = true,
                            Email = "petraitis@gmail.com",
                            LastLoginDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(5423),
                            LoyalityPoints = 5,
                            Password = "slaptozodis",
                            PersonId = 4,
                            RegistrationDate = new DateTime(2020, 5, 16, 19, 4, 33, 697, DateTimeKind.Local).AddTicks(5419)
                        });
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

                    b.HasData(
                        new
                        {
                            WaiterId = 1,
                            EmployeeId = 2,
                            Tips = 100.0
                        });
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
                        .HasForeignKey("RegisteredByAdminId");

                    b.HasOne("PSAPIRestaurantSystem.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("PSAPIRestaurantSystem.Models.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.MenuEntry", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Menu", "Menu")
                        .WithMany("MenuEntries")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.Order", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Waiter", "ManagedBy")
                        .WithMany("Orders")
                        .HasForeignKey("ManagedByWaiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.OrderedMeal", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Order", "InOrder")
                        .WithMany("OrderedMeals")
                        .HasForeignKey("InOrderOrderNum");

                    b.HasOne("PSAPIRestaurantSystem.Models.TakeoutOrder", "InTakeout")
                        .WithMany("OrderedMeals")
                        .HasForeignKey("InTakeoutTakeoutOrderNum");

                    b.HasOne("PSAPIRestaurantSystem.Models.MenuEntry", "MenuEntry")
                        .WithMany("OrderedMeals")
                        .HasForeignKey("MenuEntryId")
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

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.TableOccupancy", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Order", "Order")
                        .WithMany("TableOccupancies")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSAPIRestaurantSystem.Models.Reservation", "Reservation")
                        .WithMany("TableOccupancies")
                        .HasForeignKey("ReservationId");

                    b.HasOne("PSAPIRestaurantSystem.Models.Table", "Table")
                        .WithMany("TableOccupancies")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PSAPIRestaurantSystem.Models.TakeoutOrder", b =>
                {
                    b.HasOne("PSAPIRestaurantSystem.Models.Waiter", "ManagedBy")
                        .WithMany("TakeoutOrders")
                        .HasForeignKey("ManagedByWaiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSAPIRestaurantSystem.Models.User", "OrderedBy")
                        .WithMany("TakeoutOrders")
                        .HasForeignKey("OrderedByUserId")
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
