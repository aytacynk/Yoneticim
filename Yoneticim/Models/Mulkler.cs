﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yoneticim
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Mulk
    {
        public Mulk()
        {
            this.Daireler = new List<Daire>();
            this.Gorevliler = new List<Gorevli>();
            this.Kalemler = new List<Kalem>();
            this.Mulkleri = new List<Mulk>();
        }

        [Key]
        public int Id { get; set; }
        public string Adres { get; set; }
        public string Adi { get; set; }
        public Nullable<int> MulkId { get; set; }
        public int BlokSayisi { get; set; }

        public virtual ICollection<Daire> Daireler { get; set; }
        public virtual ICollection<Gorevli> Gorevliler { get; set; }
        public virtual ICollection<Kalem> Kalemler { get; set; }
        public virtual ICollection<Mulk> Mulkleri { get; set; }
        public virtual Mulk Mulku { get; set; }
    }
}
