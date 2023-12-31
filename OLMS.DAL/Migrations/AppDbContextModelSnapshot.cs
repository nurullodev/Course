﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OLMS.DAL.DbContexts;

#nullable disable

namespace OLMS.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OLMS.Domain.Entities.CourseCategories.CourseCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("CourseCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(3955),
                            IsDeleted = false,
                            Name = "Programming"
                        });
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Courses.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CourseCategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.Property<long>("TeacherId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CourseCategoryId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(4124),
                            Description = "This course is very good",
                            IsDeleted = false,
                            Name = ".net",
                            Price = 2000000.0,
                            ShortDescription = "Good",
                            TeacherId = 1L
                        });
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Lessons.Assigment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<short>("Term")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Assigments");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(4161),
                            Description = "birichi mavzu boycha qoshimcha malumot topish!",
                            IsDeleted = false,
                            LessonId = 1L,
                            Term = (short)4,
                            Title = "read a documentation"
                        });
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Lessons.Lesson", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CourseId1")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("CourseId1");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CourseId = 1L,
                            CreatedAt = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(4137),
                            Description = ". net ga kirish",
                            IsDeleted = false,
                            Name = "Kirish"
                        });
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Lessons.Quiz", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VariantOne")
                        .HasColumnType("text");

                    b.Property<string>("VariantThree")
                        .HasColumnType("text");

                    b.Property<string>("VariantTwo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Quizzes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Answer = "Framework",
                            CreatedAt = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(4150),
                            IsDeleted = false,
                            LessonId = 1L,
                            Question = ". net nima ?",
                            VariantOne = "Framework",
                            VariantThree = "Programming language",
                            VariantTwo = "Library"
                        });
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Teachers.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Experience")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<double>("Salary")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(4178),
                            Description = "Very good teacher",
                            Experience = "4 yil",
                            FirstName = "Aqilbek",
                            IsDeleted = false,
                            LastName = "Aqilov",
                            Phone = "+998992002526",
                            Salary = 50000751.0
                        });
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<double>("CoursePayment")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CourseId = 1L,
                            CoursePayment = 50000751.0,
                            CreatedAt = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(4193),
                            DateOfBirth = new DateTime(2023, 8, 20, 15, 41, 48, 352, DateTimeKind.Utc).AddTicks(4192),
                            FirstName = "Krasavchik",
                            IsDeleted = false,
                            LastName = "Ikromov",
                            Phone = "+998992002526"
                        });
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Courses.Course", b =>
                {
                    b.HasOne("OLMS.Domain.Entities.CourseCategories.CourseCategory", "CourseCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OLMS.Domain.Entities.CourseCategories.CourseCategory", null)
                        .WithMany("Categories")
                        .HasForeignKey("CourseCategoryId");

                    b.HasOne("OLMS.Domain.Entities.Teachers.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CourseCategory");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Lessons.Assigment", b =>
                {
                    b.HasOne("OLMS.Domain.Entities.Lessons.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Lessons.Lesson", b =>
                {
                    b.HasOne("OLMS.Domain.Entities.Courses.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OLMS.Domain.Entities.Courses.Course", null)
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId1");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Lessons.Quiz", b =>
                {
                    b.HasOne("OLMS.Domain.Entities.Lessons.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Users.User", b =>
                {
                    b.HasOne("OLMS.Domain.Entities.Courses.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("OLMS.Domain.Entities.CourseCategories.CourseCategory", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("OLMS.Domain.Entities.Courses.Course", b =>
                {
                    b.Navigation("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
