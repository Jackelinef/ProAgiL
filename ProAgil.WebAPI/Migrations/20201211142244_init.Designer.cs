﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAgil.WebAPI.Controllers.data;

namespace ProAgil.WebAPI.Migrations
{
    [DbContext(typeof(datacontext))]
    [Migration("20201211142244_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ProAgil.WebAPI.model.evento", b =>
                {
                    b.Property<int>("eventoid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("dataevento");

                    b.Property<string>("local");

                    b.Property<string>("lote");

                    b.Property<int>("quantidadepessoas");

                    b.Property<string>("tema");

                    b.HasKey("eventoid");

                    b.ToTable("eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
