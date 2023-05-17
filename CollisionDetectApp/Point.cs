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
	// 2 boyutlu nokta
	internal class Point : Shape
	{
		// Noktanin ozellikleri
		private int x;
		private int y;

		// getter ve setter metodlari
		public int getX() { return x; }
		public int getY() { return y; }
		public void setX(int x) { this.x = x; }
		public void setY(int y) { this.y = y; }

		// Bos kurucu fonksiyon
		public Point()
		{
			this.x = 0;
			this.y = 0;
		}

		// Dolu kurucu fonksiyon
		public Point(int x, int y)
		{
			this.x = x ;
			this.y = y;
		}

		// x noktasini orjine gore hizalama
		public int xOrigin() 
		{
			return 500 + x;
		}

		// y noktasini orjine gore hizalama
		public int yOrigin()
		{
			return 500 - y;
		}

		// Bilgileri ekrana yazdirma
		public override string Print()
		{
			return "Nokta(2D)" + "\nKoordinatlar : (" + x + "," + y + ")";
		}

		// Noktayi cizdirme
		public override void Draw(Graphics g, Pen pen,Brush brush)
		{
			int xN = 500 + x;
			int yN = 500 - y;

			g.DrawEllipse(pen, xN-(0.5F), yN-(0.5F),1 ,1 );
			g.FillEllipse(brush, xN - (0.5F), yN - (0.5F), 1, 1);
			brush.Dispose();
		}
	}
}
