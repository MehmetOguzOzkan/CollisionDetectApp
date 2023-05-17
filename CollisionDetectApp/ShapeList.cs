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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollisionDetectApp
{
	// Generic sinif yapisi
	internal class ShapeList<T> where T : Shape
	{
		private List<T> list = new List<T>();
		private int firstShape = 0;

		public int getFirstShape() { return firstShape; }
		public void setFirstShape(int firstShape) { this.firstShape = firstShape; }


		public void add(T item) { list.Add(item); }
		public T getItem(int index) { return list[index]; }
		public List<T> getList() { return list; }
		public int getListLength() { return list.Count; }
		public void removeAll() 
		{
			list.RemoveAt(1);
			list.RemoveAt(0);
			firstShape = 0;
		}
	}
}
