/****************************************************************************
**							SAKARYA ÜNİVERSİTESİ
**					BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**						BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**						NESNEYE DAYALI PROGRAMLAMA DERSİ
**	
**				ÖDEV NUMARASI…...: 1. Odev
**				ÖĞRENCİ ADI...............: Mehmet Oguz Ozkan
**				ÖĞRENCİ NUMARASI.: B201210065
**				DERS GRUBU…………: 1. Ogretim A Grubu
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollisionDetectApp
{
	// 3 boyutlu nokta
	internal class PointThreeD : Shape
	{
		// 3 boyutlu noktanin ozellikleri
		private int x;
		private int y;
		private int z;

		// getter ve setter metodlari
		public int getX() { return x; }
		public int getY() { return y; }
		public int getZ() { return z; }
		public void setX(int x) { this.x = y; }
		public void setY(int y) { this.y = y; }
		public void setZ(int z) { this.z = z; }

		// Bos kurucu fonksiyon
		public PointThreeD()
		{
			this.x = 0;
			this.y = 0;
			this.z = 0;
		}

		// Dolu kurucu fonksiyon
		public PointThreeD(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Nokta(3D)" + "\nMerkez : (" + x + "," + y + "," + z + ")";
		}

		// 3 boyutlu noktayi cizdirme
		public override void Draw(Graphics g, Pen pen, Brush brush)
		{
			float theta = (float)(Math.Cos(45));
			float zTheta = z * theta;
			float xN = 500 + x + zTheta;
			float yN = 500 - y - zTheta;
			g.DrawEllipse(pen, xN-(0.5F), yN-(0.5F), 1, 1);
			g.FillEllipse(brush, xN - (0.5F), yN - (0.5F), 1, 1);
			brush.Dispose();
		}
	}
}
