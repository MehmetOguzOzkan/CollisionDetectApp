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
	internal class Surface : Shape
	{
		// Yuzeyin ozellikleri
		private PointThreeD center;
		private int width;
		private int heigth;
		private const int length = 10;

		// getter ve setter metodlari
		public PointThreeD getCenter() { return center; }
		public int getHeigth() { return heigth; }
		public int getWidth() { return width; }
		public int getLength() { return length; }
		public void setCenter(PointThreeD point) { this.center = point; }
		public void setHeigth(int heigth) { this.heigth = heigth; }
		public void setWidth(int width) { this.width = width; }

		// Bos kurucu fonksiyon
		public Surface()
		{
			this.center = new PointThreeD();
			this.heigth = 0;
			this.width = 0;
		}

		// Dolu kurucu fonksiyon
		public Surface(PointThreeD center, int width, int heigth)
		{
			this.center = center;
			this.width = width;
			this.heigth = heigth;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Yüzey" + "\nMerkez : (" + center.getX() + "," + center.getY() + "," + center.getZ() + ")\nGenislik : " + width + "\nYükseklik : " + heigth + "\nUzunluk : " + length;
		}

		// Yuzey cizdirme
		public override void Draw(Graphics g, Pen pen, Brush brush)
		{
			float theta = (float)(Math.Cos(45));

			PointThreeD topTopLeft = new PointThreeD(center.getX() - width / 2, center.getY() + heigth / 2, center.getZ() - length / 2);
			PointThreeD downTopLeft = new PointThreeD(center.getX() - width / 2, center.getY() + heigth / 2, center.getZ() + length / 2);

			float zTTL = topTopLeft.getZ() * theta;
			float xTTL = 500 + topTopLeft.getX() + zTTL;
			float yTTL = 500 - topTopLeft.getY() - zTTL;

			float zDTL = downTopLeft.getZ() * theta;
			float xDTL = 500 + downTopLeft.getX() + zDTL;
			float yDTL = 500 - downTopLeft.getY() - zDTL;

			g.DrawRectangle(pen, xTTL, yTTL, width, heigth);
			g.DrawRectangle(pen, xDTL, yDTL, width, heigth);
			g.DrawLine(pen, xTTL, yTTL, xDTL, yDTL);
			g.DrawLine(pen, xTTL + width, yTTL, xDTL + width, yDTL);
			g.DrawLine(pen, xTTL, yTTL + heigth, xDTL, yDTL + heigth);
			g.DrawLine(pen, xTTL + width, yTTL + heigth, xDTL + width, yDTL + heigth);

			brush.Dispose();

		}
	}
}
