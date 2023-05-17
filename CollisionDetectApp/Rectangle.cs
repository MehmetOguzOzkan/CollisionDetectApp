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
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollisionDetectApp
{
	internal class Rectangle : Shape
	{
		// Dikdortgenin ozellikleri
		private Point center;
		private int height;
		private int width;

		// getter ve setter metodlari
		public Point getCenter() { return center; }
		public int getWidth() { return width; }
		public int getHeight() { return height; }
		public void setCenter(Point center) { this.center = center; }
		public void setWidth(int width) { this.width = width; }
		public void setHeight(int height) { this.height = height; }

		// Bos kurucu fonksiyon
		public Rectangle() 
		{
			center = new Point();
			height = 0;
			width = 0;
		}

		// Dolu kurucu fonksiyon
		public Rectangle(Point center, int height, int width)
		{
			this.center = center;
			this.height = height;
			this.width = width;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Dikdörtgen"+"\nMerkez : ("+center.getX()+","+center.getY()+")\nGenislik : "+width+"\nYükseklik : "+height;
		}

		// Dikdortgen cizdirme
		public override void Draw(Graphics g, Pen pen, Brush brush)
		{
			g.DrawRectangle(pen,center.xOrigin()-width/2,center.yOrigin()-height/2,width,height);
			g.FillRectangle(brush, center.xOrigin() - width / 2, center.yOrigin() - height / 2, width, height);
			brush.Dispose();
		}


	}
}
