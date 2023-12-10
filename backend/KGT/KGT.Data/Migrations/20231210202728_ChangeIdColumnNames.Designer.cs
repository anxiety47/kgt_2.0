﻿// <auto-generated />
using System;
using KGT.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KGT.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231210202728_ChangeIdColumnNames")]
    partial class ChangeIdColumnNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KGT.Data.Models.Certificate", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificateId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValidThroughMonths")
                        .HasColumnType("int");

                    b.HasKey("CertificateId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("KGT.Data.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuideId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoBlobUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GuideId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("KGT.Data.Models.DogCertificate", b =>
                {
                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<int>("CertificateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcquiredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("DogId", "CertificateId");

                    b.HasIndex("CertificateId");

                    b.ToTable("DogCertificates");
                });

            modelBuilder.Entity("KGT.Data.Models.DogEvent", b =>
                {
                    b.Property<int>("DogEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DogEventId"), 1L, 1);

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<string>("DogTrackBlobUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("LostPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LostPersonTrackBlobUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weather")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DogEventId");

                    b.HasIndex("DogId");

                    b.HasIndex("EventId");

                    b.ToTable("DogEvents");
                });

            modelBuilder.Entity("KGT.Data.Models.DogTraining", b =>
                {
                    b.Property<int>("DogTrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DogTrainingId"), 1L, 1);

                    b.Property<string>("AdditionalPictureBlobUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DelayTimeTicks")
                        .HasColumnType("bigint");

                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<string>("DogTrackBlobUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroundType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LostPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LostPersonTrackBlobUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LostPersonTrackLength")
                        .HasColumnType("float");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<string>("Weather")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DogTrainingId");

                    b.HasIndex("DogId");

                    b.HasIndex("TrainingId");

                    b.ToTable("DogTrainings");
                });

            modelBuilder.Entity("KGT.Data.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EventId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCommercialTraining")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetOrLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("KGT.Data.Models.Guide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMember")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guides");
                });

            modelBuilder.Entity("KGT.Data.Models.GuideEvent", b =>
                {
                    b.Property<int>("GuideId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("GuideId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("GuideEvents");
                });

            modelBuilder.Entity("KGT.Data.Models.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("GeneralLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weather")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("KGT.Data.Models.Dog", b =>
                {
                    b.HasOne("KGT.Data.Models.Guide", "Guide")
                        .WithMany("Dogs")
                        .HasForeignKey("GuideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guide");
                });

            modelBuilder.Entity("KGT.Data.Models.DogCertificate", b =>
                {
                    b.HasOne("KGT.Data.Models.Certificate", "Certificate")
                        .WithMany("DogCertificates")
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KGT.Data.Models.Dog", "Dog")
                        .WithMany("DogCertificates")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certificate");

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("KGT.Data.Models.DogEvent", b =>
                {
                    b.HasOne("KGT.Data.Models.Dog", "Dog")
                        .WithMany("DogEvents")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KGT.Data.Models.Event", "Event")
                        .WithMany("DogEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("KGT.Data.Models.DogTraining", b =>
                {
                    b.HasOne("KGT.Data.Models.Dog", "Dog")
                        .WithMany("DogTrainings")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KGT.Data.Models.Training", "Training")
                        .WithMany("DogTrainings")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("KGT.Data.Models.GuideEvent", b =>
                {
                    b.HasOne("KGT.Data.Models.Event", "Event")
                        .WithMany("GuideEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KGT.Data.Models.Guide", "Guide")
                        .WithMany("GuideEvents")
                        .HasForeignKey("GuideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Guide");
                });

            modelBuilder.Entity("KGT.Data.Models.Certificate", b =>
                {
                    b.Navigation("DogCertificates");
                });

            modelBuilder.Entity("KGT.Data.Models.Dog", b =>
                {
                    b.Navigation("DogCertificates");

                    b.Navigation("DogEvents");

                    b.Navigation("DogTrainings");
                });

            modelBuilder.Entity("KGT.Data.Models.Event", b =>
                {
                    b.Navigation("DogEvents");

                    b.Navigation("GuideEvents");
                });

            modelBuilder.Entity("KGT.Data.Models.Guide", b =>
                {
                    b.Navigation("Dogs");

                    b.Navigation("GuideEvents");
                });

            modelBuilder.Entity("KGT.Data.Models.Training", b =>
                {
                    b.Navigation("DogTrainings");
                });
#pragma warning restore 612, 618
        }
    }
}
