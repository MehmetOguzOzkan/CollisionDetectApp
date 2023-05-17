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
	internal class Square : Shape
	{
		// Karenin ozellikleri
		private Point center;
		private int edgeLength;

		// getter ve setter metodlari
		public Point getCenter() { return center; }
		public int getEdgeLength() { return edgeLength; }
		public void setCenter(Point point) { this.center = point; }
		public void setEdgeLength(int edgeLength) { this.edgeLength = edgeLength; }

		// Bos kurucu fonksiyon
		public Square() 
		{
			this.center = new Point();
			this.edgeLength = 0;
		}

		// Dolu kurucu fonksiyon
		public Square(Point center, int edgeLength)
		{
			this.center = center;
			this.edgeLength = edgeLength;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Kare" + "\nMerkez : (" + center.getX() + "," + center.getY() + ")\nGenislik : " + edgeLength + "\nYükseklik : " + edgeLength;
		}

		// Kare cizdirme
		public override void Draw(Graphics g, Pen pen,Brush brush)
		{
			g.DrawRectangle(pen, center.xOrigin() - edgeLength / 2, center.yOrigin() - edgeLength / 2, edgeLength, edgeLength);
			g.FillRectangle(brush, center.xOrigin() - edgeLength / 2, center.yOrigin() - edgeLength / 2, edgeLength, edgeLength);
			brush.Dispose();
		}
	}
}
