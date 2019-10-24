﻿// <auto-generated />
using System;
using APIIBU.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIIBU.Migrations
{
    [DbContext(typeof(DepPuestoContexto))]
    partial class DepPuestoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIIBU.Models.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("APIIBU.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("estatus");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("APIIBU.Models.Empleado", b =>
                {
                    b.Property<int>("EmpleadoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Afore");

                    b.Property<string>("Categoria");

                    b.Property<string>("Colonia");

                    b.Property<int>("Cp");

                    b.Property<int>("Credito_info");

                    b.Property<int>("Cta_bancaria");

                    b.Property<int>("Cuenta_despensa");

                    b.Property<string>("Curp");

                    b.Property<int>("Dias_contrato");

                    b.Property<string>("Direccion");

                    b.Property<int>("Edad");

                    b.Property<string>("Edo_ivil");

                    b.Property<string>("Email");

                    b.Property<int>("EmpresaID");

                    b.Property<string>("Entre_calle1");

                    b.Property<string>("Entre_calle2");

                    b.Property<DateTime>("Fecha_creacion");

                    b.Property<DateTime>("Fecha_ingreso");

                    b.Property<DateTime>("Fecha_nacimiento");

                    b.Property<int>("Id_contrato");

                    b.Property<int>("Id_puesto");

                    b.Property<int>("Id_usuario_creo");

                    b.Property<int>("Imss");

                    b.Property<string>("Lugar_nacimiento");

                    b.Property<string>("Municipio");

                    b.Property<string>("Nombre");

                    b.Property<string>("Nombre_madre");

                    b.Property<string>("Nombre_padre");

                    b.Property<string>("Num_ext");

                    b.Property<string>("Num_int");

                    b.Property<int>("Num_trajeta");

                    b.Property<string>("Pais");

                    b.Property<string>("Photo");

                    b.Property<int>("Porcentaje_info");

                    b.Property<string>("Rfc");

                    b.Property<float>("Salario_diario");

                    b.Property<float>("Salrio_base");

                    b.Property<float>("Sdi");

                    b.Property<string>("Sexo");

                    b.Property<int>("Tarjet_despensa");

                    b.Property<int>("Umf");

                    b.Property<int>("reloj");

                    b.HasKey("EmpleadoID");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("APIIBU.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cp_empresa");

                    b.Property<string>("Direccion_empresa");

                    b.Property<string>("Estado_empresa");

                    b.Property<string>("Logo_empresa");

                    b.Property<string>("Municipio_empresa");

                    b.Property<string>("Nombre_empresa");

                    b.Property<string>("Num_ext_empresa");

                    b.Property<string>("Num_int_empresa");

                    b.Property<string>("Pais_empresa");

                    b.Property<string>("Rfc_empresa");

                    b.HasKey("EmpresaID");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("APIIBU.Models.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dinicio");

                    b.Property<int>("Dtrabajar");

                    b.Property<string>("ED")
                        .HasMaxLength(10);

                    b.Property<string>("EJ")
                        .HasMaxLength(10);

                    b.Property<string>("EMier")
                        .HasMaxLength(10);

                    b.Property<string>("ES")
                        .HasMaxLength(10);

                    b.Property<string>("EV")
                        .HasMaxLength(10);

                    b.Property<string>("El")
                        .HasMaxLength(10);

                    b.Property<string>("Emar")
                        .HasMaxLength(10);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("SD")
                        .HasMaxLength(10);

                    b.Property<string>("SJ")
                        .HasMaxLength(10);

                    b.Property<string>("SMier")
                        .HasMaxLength(10);

                    b.Property<string>("SS")
                        .HasMaxLength(10);

                    b.Property<string>("SV")
                        .HasMaxLength(10);

                    b.Property<string>("Sl")
                        .HasMaxLength(10);

                    b.Property<string>("Smar")
                        .HasMaxLength(10);

                    b.Property<int>("Ttrabajar");

                    b.Property<bool>("Turno");

                    b.HasKey("Id");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("APIIBU.Models.Puesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("estatus");

                    b.Property<int>("id_depto");

                    b.HasKey("Id");

                    b.HasIndex("id_depto");

                    b.ToTable("Puesto");
                });

            modelBuilder.Entity("APIIBU.Models.Reloj", b =>
                {
                    b.Property<int>("RelojID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ip");

                    b.Property<string>("Nombre");

                    b.Property<string>("Protocolo");

                    b.HasKey("RelojID");

                    b.ToTable("Reloj");
                });

            modelBuilder.Entity("APIIBU.Models.Puesto", b =>
                {
                    b.HasOne("APIIBU.Models.Departamento", "Departamento")
                        .WithMany("Puesto")
                        .HasForeignKey("id_depto")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
