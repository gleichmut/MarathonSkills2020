//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarathonSkills2020
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Бегун.
    /// </summary>
    public partial class Runner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Runner()
        {
            this.Registrations = new HashSet<Registration>();
        }

        /// <summary>
        /// ID.
        /// </summary>
        public int RunnerId { get; set; }
        /// <summary>
        /// Почта.
        /// Обязательное поле.
        /// </summary>
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// Пол.
        /// Обязательное поле.
        /// </summary>
        [Required]
        public string Gender { get; set; }
        /// <summary>
        /// Дата рождения.
        /// Обязательное поле.
        /// </summary>
        [Required]
        public string DateOfBirth { get; set; }
        /// <summary>
        /// Код страны.
        /// Обязательное поле.
        /// </summary>
        [Required]
        public string CountryCode { get; set; }
        /// <summary>
        /// Фото.
        /// Необязательное поле.
        /// </summary>
        public byte[] Photo { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Gender Gender1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual User User { get; set; }
    }
}
