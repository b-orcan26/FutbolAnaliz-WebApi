using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApi.ViewModels
{
    public class PuanDurumuVeDetay
    {
        public List<PuanDurumu> puanDurumu { get; set; }
        public LigDetay ligDetay { get; set; }

        public PuanDurumuVeDetay(List<PuanDurumu> liste,LigDetay detay)
        {
            this.puanDurumu = liste;
            this.ligDetay = detay;
        }

    }
}