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
	internal class Sphere : Shape
	{
		// Kurenin ozellikleri
		private PointThreeD center;
		private int radius;

		// getter ve setter metodlari
		public PointThreeD getCenter() { return center; }
		public int getRadius() { return radius; }
		public void setCenter(PointThreeD point) { this.center = point; }
		public void setRadius(int radius) { this.radius = radius; }

		// Bos kurucu fonksiyon
		public Sphere() 
		{
			this.center = new PointThreeD();
			this.radius = 0;
		}

		// Dolu kurucu fonksiyon
		public Sphere(PointThreeD center, int radius)
		{
			this.center = center;
			this.radius = radius;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Küre" + "\nMerkez : (" + center.getX() + "," + center.getY() + "," + center.getZ() + ")\nYariçap : " + radius;
		}

		// Küre cizdirme
		public override void Draw(Graphics g, Pen pen, Brush brush)
		{
			float theta = (float)(Math.Cos(45));

			float zN = center.getZ() * theta;
			float xN = 500 + center.getX() + zN;
			float yN = 500 - center.getY() - zN;

			g.DrawEllipse(pen, xN - radius, yN - radius, 2 * radius, 2 * radius);
			g.DrawEllipse(pen, xN - radius, yN - (radius * theta), 2 * radius, 2 * radius * theta);

			brush.Dispose();

		}
	}
}
