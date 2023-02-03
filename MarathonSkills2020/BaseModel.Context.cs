﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarathonSkills2020
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class MarathonEntities : DbContext
    {
        /// <summary>
        /// Контекст базы данных.
        /// </summary>
        private static MarathonEntities context;

        /// <summary>
        /// Модель базы данных.
        /// </summary>
        public MarathonEntities() : base("name=MarathonEntities") { }

        /// <summary>
        /// Получение контекста базы данных.
        /// </summary>
        /// <returns>Контекст базы данных.</returns>
        public static MarathonEntities GetContext()
        {
            if (context == null)
                context = new MarathonEntities();
            return context;
        }

        /// <summary>
        /// Создание базы данных.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        /// <summary>
        /// Благотворотельные организации.
        /// </summary>
        public virtual DbSet<CharityDB> CharityDBs { get; set; }
        /// <summary>
        /// Страны.
        /// </summary>
        public virtual DbSet<Country> Countries { get; set; }
        /// <summary>
        /// События.
        /// </summary>
        public virtual DbSet<Event> Events { get; set; }
        /// <summary>
        /// Типы событий.
        /// </summary>
        public virtual DbSet<EventType> EventTypes { get; set; }
        /// <summary>
        /// Пол.
        /// </summary>
        public virtual DbSet<Gender> Genders { get; set; }
        /// <summary>
        /// Марафоны.
        /// </summary>
        public virtual DbSet<Marathon> Marathons { get; set; }
        /// <summary>
        /// Статусы.
        /// </summary>
        public virtual DbSet<Position> Positions { get; set; }
        /// <summary>
        /// Варианты гоночного комплекта.
        /// </summary>
        public virtual DbSet<RaceKitOption> RaceKitOptions { get; set; }
        /// <summary>
        /// Регистрация.
        /// </summary>
        public virtual DbSet<Registration> Registrations { get; set; }
        /// <summary>
        /// События регистрации.
        /// </summary>
        public virtual DbSet<RegistrationEvent> RegistrationEvents { get; set; }
        /// <summary>
        /// Статус регистрации.
        /// </summary>
        public virtual DbSet<RegistrationStatu> RegistrationStatus { get; set; }
        /// <summary>
        /// Роли.
        /// </summary>
        public virtual DbSet<Role> Roles { get; set; }
        /// <summary>
        /// Бегуны.
        /// </summary>
        public virtual DbSet<Runner> Runners { get; set; }
        /// <summary>
        /// Спонсоры.
        /// </summary>
        public virtual DbSet<Sponsorship> Sponsorships { get; set; }
        /// <summary>
        /// Персонал.
        /// </summary>
        public virtual DbSet<Staff> Staffs { get; set; }
        /// <summary>
        /// Системная диаграмма.
        /// </summary>
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        /// <summary>
        /// Расписание.
        /// </summary>
        public virtual DbSet<Timesheet> Timesheets { get; set; }
        /// <summary>
        /// Пользователи.
        /// </summary>
        public virtual DbSet<User> Users { get; set; }
        /// <summary>
        /// Волонтеры.
        /// </summary>
        public virtual DbSet<Volunteer> Volunteers { get; set; }
    }
}
