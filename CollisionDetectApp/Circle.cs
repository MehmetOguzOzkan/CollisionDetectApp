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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace CollisionDetectApp
{
	internal class Circle : Shape
	{
		// Cemberin ozellikleri
		private Point center;
		private int radius;

		// getter ve setter metodlari
		public Point getCenter() { return center; }
		public int getRadius() { return radius; }
		public void setCenter(Point center) { this.center = center; }
		public void setRadius(int radius) { this.radius = radius; }

		// Bos kurucu metod
		public Circle() 
		{
			center = new Point();
			radius = 0;
		}

		// Dolu kurucu metod
		public Circle(Point center, int radius)
		{
			this.center = center;
			this.radius = radius;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Çember"+"\nMerkez : (" + center.getX() + "," + center.getY() + ")\nYariçap : " + radius;
		}

		// Cemberi cizdirme
		public override void Draw(Graphics g,Pen pen,Brush brush)
		{
			g.DrawEllipse(pen,center.xOrigin() - radius, center.yOrigin() - radius, 2 * radius, 2 * radius);
			g.FillEllipse(brush,center.xOrigin() - radius, center.yOrigin() - radius,2 * radius, 2 * radius);
			brush.Dispose();
		}
	}
}
