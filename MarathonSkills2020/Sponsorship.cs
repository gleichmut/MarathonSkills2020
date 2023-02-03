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
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Спонсор.
    /// </summary>
    public partial class Sponsorship
    {
        /// <summary>
        /// ID
        /// </summary>
        public int SponsorshipId { get; set; }
        /// <summary>
        /// Название спонсора.
        /// Обязательное поле.
        /// </summary>
        [Required]
        public string SponsorName { get; set; }
        public int? RegistrationId { get; set; }
        /// <summary>
        /// Сумма взноса.
        /// Обязательное поле.
        /// </summary>
        [Required]
        public decimal Amount { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
