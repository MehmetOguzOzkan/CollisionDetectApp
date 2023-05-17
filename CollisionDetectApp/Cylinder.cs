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
using System.Windows.Media.Media3D;

namespace CollisionDetectApp
{
	internal class Cylinder : Shape
	{
		// Silindirin ozellikleri
		private PointThreeD center;
		private int heigth;
		private int radius;

		// getter ve setter metodlari
		public PointThreeD getCenter() { return center; }
		public int getHeigth() { return heigth; }
		public int getRadius() { return radius; }
		public void setCenter(PointThreeD point) { this.center = point; }
		public void setHeigth(int heigth) { this.heigth = heigth; }
		public void setRadius(int radius) { this.radius = radius; }

		// Bos kurucu fonksiyon
		public Cylinder() 
		{
			this.center = new PointThreeD();
			this.heigth = 0;
			this.radius = 0;
		}

		// Dolu kurucu fonksiyon
		public Cylinder(PointThreeD center, int heigth, int radius)
		{
			this.center = center;
			this.heigth = heigth;
			this.radius = radius;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Silindir" + "\nMerkez : (" + center.getX() + "," + center.getY() + "," + center.getZ() + ")\nYariçap : " + radius + "\nYükseklik : " + heigth;
		}

		// Silindiri cizdirme
		public override void Draw(Graphics g, Pen pen, Brush brush)
		{
			float theta = (float)(Math.Cos(45));

			PointThreeD top = new PointThreeD(center.getX(), center.getY() - heigth/2, center.getZ());
			PointThreeD down = new PointThreeD(center.getX(), center.getY() + heigth/2, center.getZ());

			float zTTL = top.getZ() * theta;
			float xTTL = 500 + top.getX() + zTTL;
			float yTTL = 500 - top.getY() - zTTL;

			float zDTL = down.getZ() * theta;
			float xDTL = 500 + down.getX() + zDTL;
			float yDTL = 500 - down.getY() - zDTL;

			g.DrawEllipse(pen, xTTL - radius, yTTL - radius*theta, (2*radius), 2*radius*theta);
			g.DrawEllipse(pen, xDTL - radius, yDTL - radius*theta, (2*radius), 2*radius*theta);
			g.DrawLine(pen, xTTL - radius, yTTL, xDTL - radius, yDTL);
			g.DrawLine(pen, xTTL, yTTL - radius*theta, xDTL, yDTL - radius*theta);
			g.DrawLine(pen, xTTL, yTTL + radius*theta, xDTL, yDTL + radius*theta);
			g.DrawLine(pen, xTTL + radius, yTTL, xDTL + radius, yDTL);

			brush.Dispose();
		}
	}
}
