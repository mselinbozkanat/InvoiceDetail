﻿namespace FaturaProje
{
    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

    public class FaturaContext : DbContext
    {
        
        public FaturaContext()
            : base("Baglanti")
        {

        }


        public virtual DbSet<FaturaMaster> FaturaMasters { get; set; }
        public virtual DbSet<FaturaDetay> FaturaDetays { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Birim> Birimler { get; set; }
        public virtual DbSet<Ilce> Ilceler { get; set; }
        public virtual DbSet<Il> Iller { get; set; }

    }

    [Table("FaturaMaster")]
    public class FaturaMaster
    {
        public FaturaMaster()
        {
            this.faturadetay = new HashSet<FaturaDetay>();
            this.FaturaTarihi = DateTime.Now;
        }
        [Key]
        public int FaturaID { get; set; }
        public int MusteriID { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int IrsaliyeNo { get; set; }
        public DateTime OdemeTarihi { get; set; }

        public virtual Musteri musteri { get; set; }
        public virtual ICollection<FaturaDetay> faturadetay {get;set;}


    }
    [Table("FaturaDetay")]
    public class FaturaDetay
    {
        public FaturaDetay()
        {
            this.Aciklama = "Vadesinden sonra ödenen faturalara %5 kanunu ceza faizi uygulanır..";
        }
        [Key] [Column(Order = 0)]
        public int FaturaID { get; set; }
        [Key] [Column(Order = 1)]
        public int UrunID { get; set; } 
        public decimal Miktar { get; set; }
        public decimal ToplamFiyat { get; set; }        
        public decimal KDV { get; set; }
        public decimal KDVliFiyat { get; set; }
        public decimal FaturaToplam { get; set; }
        public string Aciklama { get; set; }

        public virtual FaturaMaster faturamaster { get; set; }
        public virtual Urun urun { get; set; }

    }
    [Table("Musteri")]
    public class Musteri
    {
        public Musteri()
        {
            this.faturamaster = new HashSet<FaturaMaster>();
        }
        [Key]
        public int MusteriID { get; set; }
        public string MusteriUnvani { get; set; }
        public int IlceID { get; set; }
        public string MusteriAdresi { get; set; }

        public virtual Ilce ilce { get; set; }
        public virtual ICollection<FaturaMaster> faturamaster { get; set; }
    }
    [Table("Urun")]
    public class Urun
    {
        public Urun()
        {
            this.faturadetay = new HashSet<FaturaDetay>();
        }
        [Key]
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public int BirimID { get; set; }
        public decimal BirimFiyat { get; set; }
        public virtual Birim birim { get; set; }
        public virtual ICollection<FaturaDetay> faturadetay {get;set;}
    }
    [Table("Birim")]
    public class Birim
    {
        public Birim()
        {
            this.urun = new HashSet<Urun>();
        }
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set; }

        public virtual ICollection<Urun> urun { get; set; }

    }
    [Table("Ilce")]
    public class Ilce
    {
        public Ilce()
        {
            this.musteri = new HashSet<Musteri>();
        }

        [Key]
        public int IlceID { get; set; }
        public string Aciklama { get; set; }
        public int IlID { get; set; }

        public virtual Il il { get; set; } 
        public virtual ICollection<Musteri> musteri { get; set; }

    }

    [Table("Il")]
    public class Il
    {
        [Key]
        public int IlID { get; set; }
        public string Aciklama { get; set; }

        public virtual ICollection<Ilce> ilce { get; set; }
    }

}