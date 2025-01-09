using efcoreApp.Data;

namespace efcoreApp.Models{

    public class BootcampViewModel{
        public int BootcampId {get;set;}
        public string? Baslik {get;set;}
        public int? OgretmenId {get;set;}
        public ICollection<BootcampKayit> BootcampKayitlari {get;set;} = new List<BootcampKayit>();

    }
}