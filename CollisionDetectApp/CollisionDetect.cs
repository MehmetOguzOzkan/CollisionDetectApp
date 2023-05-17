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
	internal class CollisionDetect
	{
		// Bos kurucu fonksiyon
		public CollisionDetect() { }

		public string result(bool result) 
		{
			if (result) 
			{ return "Çarpışma Gerçekleşti."; }
			else { return "Çarpışma Gerçekleşmedi."; }
		}

		// 2 nokta arasindaki mesafeyi 3 boyutlu olarak bulan metod
		public double PointPointDistanceXYZ(PointThreeD point1, PointThreeD point2)
		{
			double distance = Math.Sqrt(Math.Pow((point1.getX() - point2.getX()), 2) + Math.Pow((point1.getY() - point2.getY()), 2) + Math.Pow((point1.getZ() - point2.getZ()), 2));
			return distance;
		}

		// 2 nokta arasindaki mesafeyi X ve Z duzleminde bulan metod
		public double PointPointDistanceXZ(PointThreeD point1, PointThreeD point2)
		{
			double distanceXZ = Math.Sqrt(Math.Pow((point1.getX() - point2.getX()), 2) + Math.Pow((point1.getZ() - point2.getZ()), 2));
			return distanceXZ;
		}

		// 2 nokta arasindaki mesafeyi 2 boyutlu olarak bulan metod
		public double PointPointDistance(Point point1, Point point2)
		{
			double distance = Math.Sqrt(Math.Pow((point1.getX() - point2.getX()), 2) + Math.Pow((point1.getY() - point2.getY()), 2));
			return distance;
		}

		// Nokta ve karenin carpisma metodu
		public bool PointSquareCollision(Point point, Square square)
		{
			double distanceX = Math.Abs(point.getX() - square.getCenter().getX());
			double distanceY = Math.Abs(point.getY() - square.getCenter().getY());
			if (distanceX <= square.getEdgeLength() / 2 && distanceY <= square.getEdgeLength() / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Nokta ve cemberin carpisma metodu
		public bool PointCircleCollision(Point point, Circle circle)
		{
			double distance = PointPointDistance(circle.getCenter(), point);
			if (distance > circle.getRadius())
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		// 2 cemberin carpisma metodu
		public bool CircleCircleCollision(Circle circle1, Circle circle2)
		{
			double distance = PointPointDistance(circle1.getCenter(), circle2.getCenter());
			if (distance > circle1.getRadius() + circle2.getRadius())
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		// 2 dikdortgenin carpisma metodu
		public bool RectangleRectangleCollision(Rectangle rectangle1, Rectangle rectangle2)
		{
			double distanceX = Math.Abs(rectangle1.getCenter().getX() - rectangle2.getCenter().getX());
			double distanceY = Math.Abs(rectangle1.getCenter().getY() - rectangle2.getCenter().getY());
			double totalHeight = rectangle1.getHeight() + rectangle2.getHeight();
			double totalWidth = rectangle1.getWidth() + rectangle2.getWidth();

			if (distanceX <= totalWidth / 2 && distanceY <= totalHeight / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Dikdortgen ve cemberin carpisma metodu
		public bool RectangleCircleCollision(Rectangle rectangle, Circle circle)
		{
			double distanceX = Math.Abs(rectangle.getCenter().getX() - circle.getCenter().getX());
			double distanceY = Math.Abs(rectangle.getCenter().getY() - circle.getCenter().getY());
			double distanceXY = PointPointDistance(rectangle.getCenter(),circle.getCenter());
			double totalHeight = rectangle.getHeight() + (2 * circle.getRadius());
			double totalWidth = rectangle.getWidth() + (2 * circle.getRadius());
			double totalDistance = Math.Sqrt(Math.Pow(rectangle.getHeight()/2,2) + Math.Pow(rectangle.getWidth()/2,2)) + circle.getRadius();

			if (distanceX <= totalWidth / 2 && distanceY <= totalHeight / 2 && distanceXY <= totalDistance)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Nokta ve kurenin carpisma metodu 
		public bool PointSphereCollision(PointThreeD point, Sphere sphere)
		{
			double distance = PointPointDistanceXYZ(point, sphere.getCenter());

			if (distance > sphere.getRadius())
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		// Nokta ve dikdortgen prizmanin carpisma metodu
		public bool PointQuadrangularCollision(PointThreeD point, Quadrangular quadrangular)
		{
			double distanceX = Math.Abs(point.getX() - quadrangular.getCenter().getX());
			double distanceY = Math.Abs(point.getY() - quadrangular.getCenter().getY());
			double distanceZ = Math.Abs(point.getZ() - quadrangular.getCenter().getZ());

			if (distanceX <= quadrangular.getWidth() / 2 && distanceY <= quadrangular.getHeigth() / 2 && distanceZ <= quadrangular.getLength() / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Nokta ve silindirin carpisma metodu
		public bool PointCylinderCollision(PointThreeD point, Cylinder cylinder)
		{
			double distanceXZ = PointPointDistanceXZ(point, cylinder.getCenter());
			double distanceY = Math.Abs(point.getY() - cylinder.getCenter().getY());

			if (distanceY <= cylinder.getHeigth() / 2 && distanceXZ <= cylinder.getRadius())
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// 2 silindirin carpisma metodu
		public bool CylinderCylinderCollision(Cylinder cylinder1, Cylinder cylinder2)
		{
			double distanceXZ = PointPointDistanceXZ(cylinder1.getCenter(), cylinder2.getCenter());
			double distanceY = Math.Abs(cylinder1.getCenter().getY() - cylinder2.getCenter().getY());
			double totalHeigth = cylinder1.getHeigth() + cylinder2.getHeigth();
			double totalRadius = cylinder1.getRadius() + cylinder2.getRadius();

			if (distanceXZ <= totalRadius && distanceY <= totalHeigth / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// 2 kurenin carpisma metodu
		public bool SphereSphereCollision(Sphere sphere1, Sphere sphere2)
		{
			double distance = PointPointDistanceXYZ(sphere1.getCenter(), sphere2.getCenter());
			double totalRadius = sphere1.getRadius() + sphere2.getRadius();

			if (distance <= totalRadius)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Kure ve silindirin carpisma metodu
		public bool SphereCylinderCollision(Sphere sphere, Cylinder cylinder)
		{
			double distanceXZ = PointPointDistanceXZ(sphere.getCenter(), cylinder.getCenter());
			double distanceY = Math.Abs(sphere.getCenter().getY() - cylinder.getCenter().getY());
			double totalHeigh = cylinder.getHeigth() + 2 * (sphere.getRadius());
			double totalWidth = cylinder.getRadius() + sphere.getRadius();

			if (distanceXZ <= totalWidth && distanceY <= totalHeigh / 2)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		// Kure ve dikdortgen prizmanin carpisma metodu
		public bool SphereQuadrangularCollision(Sphere sphere, Quadrangular quadrangular)
		{
			double distanceX = Math.Abs(quadrangular.getCenter().getX() - sphere.getCenter().getX());
			double distanceY = Math.Abs(quadrangular.getCenter().getY() - sphere.getCenter().getY());
			double distanceZ = Math.Abs(quadrangular.getCenter().getZ() - sphere.getCenter().getZ());
			double totalHeigth = quadrangular.getHeigth() + 2 * sphere.getRadius();
			double totalWidth = quadrangular.getWidth() + 2 * sphere.getRadius();
			double totalLength = quadrangular.getLength() + 2 * sphere.getRadius();

			if (distanceX <= totalWidth / 2 && distanceY <= totalHeigth / 2 && distanceZ <= totalLength / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// 2 dikdortgen prizmanin carpisma metodu
		public bool QuadrangularQuadrangularCollision(Quadrangular quadrangular1, Quadrangular quadrangular2)
		{
			double distanceX = Math.Abs(quadrangular1.getCenter().getX() - quadrangular2.getCenter().getX());
			double distanceY = Math.Abs(quadrangular1.getCenter().getY() - quadrangular2.getCenter().getY());
			double distanceZ = Math.Abs(quadrangular1.getCenter().getZ() - quadrangular2.getCenter().getZ());
			double totalHeigth = quadrangular1.getHeigth() + quadrangular2.getHeigth();
			double totalWidth = quadrangular1.getWidth() + quadrangular2.getWidth();
			double totalLength = quadrangular1.getLength() + quadrangular2.getLength();

			if (distanceY <= totalHeigth / 2 && distanceX <= totalWidth / 2 && distanceZ <= totalLength / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Yuzey ve kurenin carpisma metodu
		public bool SurfaceSphereCollision(Surface surface, Sphere sphere)
		{
			double distanceX = Math.Abs(surface.getCenter().getX() - sphere.getCenter().getX());
			double distanceY = Math.Abs(surface.getCenter().getY() - sphere.getCenter().getY());
			double distanceZ = Math.Abs(surface.getCenter().getZ() - sphere.getCenter().getZ());
			double totalHeigth = surface.getHeigth() + 2 * sphere.getRadius();
			double totalWidth = surface.getWidth() + 2 * sphere.getRadius();
			double totalLength = surface.getLength() + 2 * sphere.getRadius();

			if (distanceX <= totalWidth / 2 && distanceY <= totalHeigth / 2 && distanceZ <= totalLength / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Yuzey ve dikdortgen prizmanin carpisma metodu
		public bool SurfaceQuadrangularCollision(Surface surface, Quadrangular quadrangular)
		{
			double distanceX = Math.Abs(surface.getCenter().getX() - quadrangular.getCenter().getX());
			double distanceY = Math.Abs(surface.getCenter().getY() - quadrangular.getCenter().getY());
			double distanceZ = Math.Abs(surface.getCenter().getZ() - quadrangular.getCenter().getZ());
			double totalHeigth = surface.getHeigth() + quadrangular.getHeigth();
			double totalWidth = surface.getWidth() + quadrangular.getWidth();
			double totalLength = surface.getLength() + quadrangular.getLength();

			if (distanceY <= totalHeigth / 2 && distanceX <= totalWidth / 2 && distanceZ <= totalLength / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Yuzey ve silindirin carpisma metodu
		public bool SurfaceCylinderCollision(Surface surface, Cylinder cylinder)
		{
			double distanceX = Math.Abs(surface.getCenter().getX() - cylinder.getCenter().getX());
			double distanceY = Math.Abs(surface.getCenter().getY() - cylinder.getCenter().getY());
			double distanceZ = Math.Abs(surface.getCenter().getZ() - cylinder.getCenter().getZ());
			double totalHeigth = surface.getHeigth() + cylinder.getHeigth();
			double totalWidth = surface.getWidth() + 2 * cylinder.getRadius();
			double totalLength = surface.getLength() + 2 * cylinder.getRadius();

			if (distanceX <= totalWidth / 2 && distanceY <= totalHeigth / 2 && distanceZ <= totalLength / 2)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
