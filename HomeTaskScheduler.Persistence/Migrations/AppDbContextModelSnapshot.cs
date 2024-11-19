﻿// <auto-generated />
using System;
using HomeTaskScheduler.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HomeTaskScheduler.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AbstractTaskConfigurationCourse", b =>
                {
                    b.Property<Guid>("CoursesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TasksId")
                        .HasColumnType("uuid");

                    b.HasKey("CoursesId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("TaskCourses", (string)null);
                });

            modelBuilder.Entity("AbstractTaskConfigurationStudent", b =>
                {
                    b.Property<Guid>("StudentsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TasksId")
                        .HasColumnType("uuid");

                    b.HasKey("StudentsId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("StudentTasks", (string)null);
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<Guid>("CoursesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StudentsId")
                        .HasColumnType("uuid");

                    b.HasKey("CoursesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("CourseStudents", (string)null);
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.Property<Guid>("CoursesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TeachersId")
                        .HasColumnType("uuid");

                    b.HasKey("CoursesId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("CourseTeachers", (string)null);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractAttachment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AttachmentName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("AttachmentType")
                        .HasColumnType("integer");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("SubmissionId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TaskConfigurationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SubmissionId");

                    b.HasIndex("TaskConfigurationId");

                    b.ToTable("Attachments");

                    b.HasDiscriminator<int>("AttachmentType");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractSubmission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("Grade")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.Property<int>("SubmissionStatus")
                        .HasColumnType("integer");

                    b.Property<int>("SubmissionType")
                        .HasColumnType("integer");

                    b.Property<Guid>("TaskConfigurationId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TaskConfigurationId");

                    b.ToTable("Submissions");

                    b.HasDiscriminator<int>("SubmissionType");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("MaxMark")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TaskInstructions")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("TaskTittle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("TaskType")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ThemeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("TaskConfigurations");

                    b.HasDiscriminator<int>("TaskType");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("LastActivity")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("PreferredLanguage")
                        .HasColumnType("integer");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<int>("UserType");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Feed.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AbstractTaskId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AbstractUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("CommentPayload")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<int>("CommentTargetType")
                        .HasColumnType("integer");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AbstractTaskId");

                    b.HasIndex("AbstractUserId");

                    b.HasIndex("CourseId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Feed.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Feed.Theme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ThemeName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Themes", (string)null);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Attachments.FileAttachment", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractAttachment");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<int?>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("ThumbnailPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Width")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Attachments.LinkAttachment", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractAttachment");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Attachments.VideoAttachment", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractAttachment");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<double?>("DurationInSeconds")
                        .HasColumnType("double precision");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<int?>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("ThumbnailPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Width")
                        .HasColumnType("integer");

                    b.ToTable("Attachments", t =>
                        {
                            t.Property("ContentType")
                                .HasColumnName("VideoAttachment_ContentType");

                            t.Property("Extension")
                                .HasColumnName("VideoAttachment_Extension");

                            t.Property("FileSize")
                                .HasColumnName("VideoAttachment_FileSize");

                            t.Property("Height")
                                .HasColumnName("VideoAttachment_Height");

                            t.Property("Path")
                                .HasColumnName("VideoAttachment_Path");

                            t.Property("ThumbnailPath")
                                .HasColumnName("VideoAttachment_ThumbnailPath");

                            t.Property("Width")
                                .HasColumnName("VideoAttachment_Width");
                        });

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Submissions.QuestionSubmission", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractSubmission");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<long>("AnswerId")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Submissions.SimpleSubmission", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractSubmission");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Submissions.TestSubmission", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractSubmission");

                    b.Property<string>("AnswerIds")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("AnswerIds");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Tasks.QuestionTaskConfiguration", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration");

                    b.Property<int>("AnswerUnit")
                        .HasColumnType("integer");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("QuestionAnswer")
                        .HasColumnType("text")
                        .HasColumnName("QuestionAnswer");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Tasks.SimpleTaskConfiguration", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Tasks.TestTaskConfiguration", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration");

                    b.Property<string>("QuestionsAnswers")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("QuestionsAnswers");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Users.Student", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractUser");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Users.Teacher", b =>
                {
                    b.HasBaseType("HomeTaskScheduler.Domain.Common.AbstractUser");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("AbstractTaskConfigurationCourse", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Entities.Feed.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AbstractTaskConfigurationStudent", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Entities.Users.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Entities.Feed.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeTaskScheduler.Domain.Entities.Users.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Entities.Feed.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeTaskScheduler.Domain.Entities.Users.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractAttachment", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Common.AbstractSubmission", "Submission")
                        .WithMany("Attachments")
                        .HasForeignKey("SubmissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", "TaskConfiguration")
                        .WithMany("Attachments")
                        .HasForeignKey("TaskConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Submission");

                    b.Navigation("TaskConfiguration");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractSubmission", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Entities.Users.Student", "Student")
                        .WithMany("Submissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", "Task")
                        .WithMany("Submissions")
                        .HasForeignKey("TaskConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Entities.Feed.Theme", "Theme")
                        .WithMany("Tasks")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Feed.Comment", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", "AbstractTaskConfiguration")
                        .WithMany("Comments")
                        .HasForeignKey("AbstractTaskId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HomeTaskScheduler.Domain.Common.AbstractUser", "AbstractUser")
                        .WithMany("Comments")
                        .HasForeignKey("AbstractUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeTaskScheduler.Domain.Entities.Feed.Course", "Course")
                        .WithMany("Comments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AbstractTaskConfiguration");

                    b.Navigation("AbstractUser");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Feed.Theme", b =>
                {
                    b.HasOne("HomeTaskScheduler.Domain.Entities.Feed.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractSubmission", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractTaskConfiguration", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Comments");

                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Common.AbstractUser", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Feed.Course", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Feed.Theme", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("HomeTaskScheduler.Domain.Entities.Users.Student", b =>
                {
                    b.Navigation("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
