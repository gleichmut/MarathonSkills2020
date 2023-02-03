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

    /// <summary>
    /// Страны.
    /// </summary>
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country(string countryCode, string countryName, byte[] countryFlag)
        {
            this.CountryCode = countryCode;
            this.CountryName = countryName;
            this.CountryFlag = countryFlag;
            /*this.Marathons = new HashSet<Marathon>();
            this.Runners = new HashSet<Runner>();
            this.Volunteers = new HashSet<Volunteer>();*/
        }

        public Country() { }

        /// <summary>
        /// Код страны.
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// Название страны.
        /// </summary>
        public string CountryName { get; set; }
        /// <summary>
        /// Флаг страны.
        /// </summary>
        public byte[] CountryFlag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marathon> Marathons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Runner> Runners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}