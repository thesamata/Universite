using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class ToDoItem
    {
        public int id
        {get;  set;}
        public string baslik 
        { get; set; }
        private string aciklama;
        public aciliyeTuru tur
        { get; set; }
        private DateTime sonTarih;
        private bool iptalMi;

        public ToDoItem(
            string argBaslik, 
            string argAciklama,
            DateTime argSonTarih,
            aciliyeTuru argTur)
        {
            var random = new Random();
            id = random.Next(1, 10000);
            baslik = argBaslik;
            aciklama = argAciklama;
            sonTarih = argSonTarih;
            iptalMi = false;
            tur = argTur;

        }
            
    }
}
