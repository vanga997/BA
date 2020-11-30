using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BA.Models;

#nullable disable

namespace BA.Data
{
    public partial class zags_dbContext : DbContext
    {
        public zags_dbContext()
        {
        }

        public zags_dbContext(DbContextOptions<zags_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Должности> Должностиs { get; set; }
        public virtual DbSet<ЗнакиЗодиака> ЗнакиЗодиакаs { get; set; }
        public virtual DbSet<Клиенты> Клиентыs { get; set; }
        public virtual DbSet<Национальности> Национальностиs { get; set; }
        public virtual DbSet<Отношения> Отношенияs { get; set; }
        public virtual DbSet<Сотрудники> Сотрудникиs { get; set; }
        public virtual DbSet<Услуги> Услугиs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\Пользователь\\Desktop\\zags_db.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Должности>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.ToTable("Должности");

                entity.Property(e => e.КодДолжности)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_должности");

                entity.Property(e => e.НаименованиеДолжности)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)")
                    .HasColumnName("Наименование_должности");

                entity.Property(e => e.Обязанности)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Оклад).HasColumnType("FLOAT");

                entity.Property(e => e.Требования)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<ЗнакиЗодиака>(entity =>
            {
                entity.HasKey(e => e.КодЗнака);

                entity.ToTable("Знаки_зодиака");

                entity.Property(e => e.КодЗнака)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_знака");

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<Клиенты>(entity =>
            {
                entity.HasKey(e => e.КодКлиента);

                entity.ToTable("Клиенты");

                entity.Property(e => e.КодКлиента)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_клиента");

                entity.Property(e => e.Адрес)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Вес)
                    .IsRequired()
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.Возраст)
                    .IsRequired()
                    .HasColumnType("CHAR(5)")
                    .HasColumnName("_Возраст");

                entity.Property(e => e.ВредныеПривычки)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)")
                    .HasColumnName("Вредные_привычки");

                entity.Property(e => e.ДатаРождения)
                    .IsRequired()
                    .HasColumnType("DATE")
                    .HasColumnName("Дата_рождения");

                entity.Property(e => e.ИнформацияОПартнёре)
                    .IsRequired()
                    .HasColumnType("VARCHAR(500)")
                    .HasColumnName("Информация_о_партнёре");

                entity.Property(e => e.КодЗнака)
                    .HasColumnType("INT")
                    .HasColumnName("Код_знака");

                entity.Property(e => e.КодНациональности)
                    .HasColumnType("INT")
                    .HasColumnName("Код_национальности");

                entity.Property(e => e.КодОтношения)
                    .HasColumnType("INT")
                    .HasColumnName("Код_отношения");

                entity.Property(e => e.КодУслуги)
                    .HasColumnType("INT")
                    .HasColumnName("Код_услуги");

                entity.Property(e => e.КоличествоДетей)
                    .IsRequired()
                    .HasColumnType("CHAR(100)")
                    .HasColumnName("Количество_детей");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.ПаспортныеДанные)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)")
                    .HasColumnName("Паспортные_данные");

                entity.Property(e => e.Пол)
                    .IsRequired()
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Рост)
                    .IsRequired()
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.СемейноеПоложение)
                    .IsRequired()
                    .HasColumnType("VARCHAR(1)")
                    .HasColumnName("Семейное_положение");

                entity.Property(e => e.Телефон)
                    .IsRequired()
                    .HasColumnType("CHAR(11)");

                entity.Property(e => e.Фио)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)")
                    .HasColumnName("ФИО");

                entity.Property(e => e.Хобби)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.HasOne(d => d.КодЗнакаNavigation)
                    .WithMany(p => p.Клиентыs)
                    .HasForeignKey(d => d.КодЗнака)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодНациональностиNavigation)
                    .WithMany(p => p.Клиентыs)
                    .HasForeignKey(d => d.КодНациональности)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодОтношенияNavigation)
                    .WithMany(p => p.Клиентыs)
                    .HasForeignKey(d => d.КодОтношения)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслугиNavigation)
                    .WithMany(p => p.Клиентыs)
                    .HasForeignKey(d => d.КодУслуги)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Национальности>(entity =>
            {
                entity.HasKey(e => e.КодНациональности);

                entity.ToTable("Национальности");

                entity.Property(e => e.КодНациональности)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_национальности");

                entity.Property(e => e.Замечания)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<Отношения>(entity =>
            {
                entity.HasKey(e => e.КодОтношения);

                entity.ToTable("Отношения");

                entity.Property(e => e.КодОтношения)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_отношения");

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.ToTable("Сотрудники");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_сотрудника");

                entity.Property(e => e.Адрес)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Возраст)
                    .IsRequired()
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.КодДолжности)
                    .HasColumnType("INT")
                    .HasColumnName("Код_должности");

                entity.Property(e => e.ПаспортныеДанные)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)")
                    .HasColumnName("Паспортные_данные");

                entity.Property(e => e.Пол)
                    .IsRequired()
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Телефон)
                    .IsRequired()
                    .HasColumnType("CHAR(11)");

                entity.Property(e => e.Фио)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)")
                    .HasColumnName("ФИО");

                entity.HasOne(d => d.КодДолжностиNavigation)
                    .WithMany(p => p.Сотрудникиs)
                    .HasForeignKey(d => d.КодДолжности)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Услуги>(entity =>
            {
                entity.HasKey(e => e.КодУслуги);

                entity.ToTable("Услуги");

                entity.Property(e => e.КодУслуги)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_услуги");

                entity.Property(e => e.Дата)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnType("INT")
                    .HasColumnName("Код_сотрудника");

                entity.Property(e => e.Стоимость).HasColumnType("FLOAT");

                entity.HasOne(d => d.КодСотрудникаNavigation)
                    .WithMany(p => p.Услугиs)
                    .HasForeignKey(d => d.КодСотрудника)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
