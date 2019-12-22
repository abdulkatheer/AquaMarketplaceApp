﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

namespace Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191222100439_SeedValuesToUser")]
    partial class SeedValuesToUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Domain.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<string>("area");

                    b.Property<string>("companyName");

                    b.Property<string>("companyType");

                    b.Property<string>("contactName");

                    b.Property<string>("country");

                    b.Property<string>("mobileCountryCode");

                    b.Property<string>("mobileNumber");

                    b.Property<string>("naupliiSupplier");

                    b.Property<string>("referralCode");

                    b.Property<string>("state");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            address = "Paraipatty",
                            area = "Dindigul",
                            companyName = "IG",
                            companyType = "IT",
                            contactName = "Mohideen Abdul Katheer M",
                            country = "India",
                            mobileCountryCode = "91",
                            mobileNumber = "8220644661",
                            naupliiSupplier = "None",
                            referralCode = "None",
                            state = "Tamilnadu"
                        },
                        new
                        {
                            Id = 2,
                            address = "TNagar",
                            area = "Chennai",
                            companyName = "Accenture",
                            companyType = "IT",
                            contactName = "Dhanalakshmi N",
                            country = "India",
                            mobileCountryCode = "91",
                            mobileNumber = "9789161541",
                            naupliiSupplier = "None",
                            referralCode = "None",
                            state = "Tamilnadu"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
