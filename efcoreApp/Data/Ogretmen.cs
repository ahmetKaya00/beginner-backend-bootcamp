using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data{

    public class Ogretmen{
        [Key]
        public int OgretmenId {get;set;}
        public string? Ad {get;set;}
        public string? Soyad {get;set;}

        public string AdSoyad{
            get{
                return this.Ad + " " + this.Soyad;
            }
        }
        public string? Eposta {get;set;}
        public string? Telefon {get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode = false)]
        public DateTime BaslamaTarihi {get;set;}
        public ICollection<Bootcamp> Bootcamp {get;set;} = new List<Bootcamp>();
    }
}