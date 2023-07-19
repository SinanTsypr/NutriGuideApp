using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NutriGuide.Entity.Data
{
    public class Diyetler
    {
        public int Id { get; set; }
        public string? DiyetAdi { get; set; }
        public DateTime DiyetBaslama { get; set; }
        public DateTime DiyetBitis { get; set; }
        public List<Kullanici> Kullanicilar { get; set; } = new();
        public List<Food> Foods { get; set; } = new();

        public override string ToString()
        {
            return $"{DiyetAdi}";
        }
    }
}
