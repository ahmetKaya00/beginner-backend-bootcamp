namespace basics.Models{

    public class Repository{

        private static readonly List<Bootcamp> _bootcamps = new();

        static Repository(){
            _bootcamps = new List<Bootcamp>(){
                new Bootcamp() {id = 1,Title = "Beginner Back-end Bootcamp", Description = "2 Ocak'ta başiladık. 20 kişi ile başladık.", Image = "1.png"},
                new Bootcamp() {id = 2,Title = "Full Stack Bootcamp", Description = "2 Ocak'ta başiladık. 20 kişi ile başladık.", Image = "2.png"},
                new Bootcamp() {id = 3,Title = "Game Bootcamp", Description = "2 Ocak'ta başiladık. 20 kişi ile başladık.", Image = "3.jpg"},
            };
        }

        public static List<Bootcamp> Bootcamps{
            get{
                return _bootcamps;
            }
        }

        public static Bootcamp? GetById(int id){
            return _bootcamps.FirstOrDefault(b=>b.id == id);
        }
    }
}