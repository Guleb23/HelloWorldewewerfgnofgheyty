//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hranitel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InformationAboutTourist
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Otchestvo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Organisation { get; set; }
        public string Comment { get; set; }
        public System.DateTime BirthDay { get; set; }
        public string SeriaPass { get; set; }
        public string NomerPass { get; set; }
        public Nullable<int> IdZayvk { get; set; }
    
        public virtual Zayavki Zayavki { get; set; }
    }
}
