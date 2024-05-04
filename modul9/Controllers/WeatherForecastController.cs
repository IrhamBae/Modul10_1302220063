using Microsoft.AspNetCore.Mvc;

namespace modul9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mhs = new List<Mahasiswa>
        {
            new Mahasiswa ("Irham", "1302220063", ["AKA", "Basdat", "Jarkom"], 2022),
            new Mahasiswa ("carloz", "1302220063", ["AKA", "Basdat", "Jarkom"], 2022),
            new Mahasiswa ("max", "1302220063", ["AKA", "Basdat", "Jarkom"], 2022),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        [HttpPost(Name = "PostMahasiswa")]
        public void Post([FromBody] Mahasiswa value)
        {
            mhs.Add(value);
        }

        [HttpDelete(Name = "DeleteMahasiswa")]
        public void Delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}
