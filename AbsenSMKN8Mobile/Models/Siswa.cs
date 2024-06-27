using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenSMKN8Mobile.Models
{
    public class Siswa
    {

        public int Id { get; set; }
        public string NIS{ get; set; }
        public string Nama { get; set; }
        public Gender Gender{ get; set; }
        public Kelas Kelas { get; set; }
    }



    public enum Gender
    {
        Pria, Wanita
    }
}
