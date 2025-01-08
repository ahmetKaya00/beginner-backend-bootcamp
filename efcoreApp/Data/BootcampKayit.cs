using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data{

    public class BootcampKayit{
        [Key]
        public int KayitId {get;set;}
        public int OgrenciId {get;set;}
        public int BootcampId {get;set;}
        public DateTime KayitTarihi {get;set;}
    }
}