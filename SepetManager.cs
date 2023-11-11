using System;
using System.Text;
using System.Collections.Generic;

namespace Metotlar
{
	class SepetManager
	{
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Tebrikler! Sepete eklendi:" + urun.Adi);
		}

		public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
		{
			Console.WriteLine("Tebrikler! Sepete eklendi:" + urunAdi);
        }
		}
	}
	
}

