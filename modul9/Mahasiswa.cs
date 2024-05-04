
namespace modul9
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set;}

        public Mahasiswa(string name, string nim, List<string> course, int year)
        {
            this.Name = name;
            this.Nim = nim;
            this.Course = course;
            this.Year = year;
        }

    }
}

