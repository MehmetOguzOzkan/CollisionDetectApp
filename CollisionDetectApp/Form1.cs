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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Media.Media3D;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace CollisionDetectApp
{
	public partial class Form1 : Form
	{
		// Kullanilacak yapilar
		List<Button> buttonList;
		List<TextBox> inputTextBoxList;
		List<TextBox> labelTextBoxList;
		List<Button> drawButtonList;
		List<RichTextBox> richTextBoxList;
		Random r = new Random();
		Graphics graphics;
        Pen pen = new Pen(Color.MidnightBlue, 3);
        Pen penCoord = new Pen(Color.DarkSlateBlue);
		ShapeList<Shape> shapeList = new ShapeList<Shape>();
		CollisionDetect cd = new CollisionDetect();

		public Form1()
		{
			InitializeComponent();
			this.Width = 1840;
			this.Height = 1079;

			buttonList = new List<Button>{button1,button2,button3,button4,button5,button6,button7,button8,button9};
			drawButtonList = new List<Button>{drawPoint,drawCircle,drawRectangle,drawSquare,drawSphere,drawQuadrangular,drawCylinder,drawSurface,drawPointThreeD};
			inputTextBoxList = new List<TextBox>{textBox1,textBox2,textBox3,textBox4,textBox5,textBox6};
			labelTextBoxList = new List<TextBox>{textBox7,textBox8,textBox9,textBox10,textBox11,textBox12};
			richTextBoxList = new List<RichTextBox> { shape1, shape2 };

			graphics = pictureBox1.CreateGraphics();
		}

		// Ana menuye donme
		public void backToMenu()
		{
			foreach (TextBox tb in inputTextBoxList) { tb.Visible = false; }
			foreach (TextBox tb in labelTextBoxList) { tb.Visible = false; }
			foreach (Button b in buttonList) { b.Visible = true; }
			foreach(Button b in drawButtonList) { b.Visible = false; }
			foreach (RichTextBox rtb in richTextBoxList) { rtb.Visible = false; }
			groupBox1.Visible = false;
			result.Visible = false;
			back.Visible = false;
		}

		// Sonuc ekranina gitme
		public void resultScreen()
		{
			foreach (TextBox tb in inputTextBoxList) { tb.Visible = false; }
			foreach (TextBox tb in labelTextBoxList) { tb.Visible = false; }
			foreach (Button b in buttonList) { b.Visible = false; }
			foreach (Button b in drawButtonList) { b.Visible = false; }
			foreach (RichTextBox rtb in richTextBoxList) { rtb.Visible = true; }
			groupBox1.Visible = true;
			result.Visible = true;
			result.Enabled = false;
			back.Visible = true;
		}

		// Yazilari ortalama
		public void printRichTextBox(string s1, string s2)
		{
			result.SelectAll();
			result.SelectionAlignment = HorizontalAlignment.Center;
			result.DeselectAll();

			shape1.Text = s1;
			shape1.SelectAll();
			shape1.SelectionAlignment = HorizontalAlignment.Center;
			shape1.DeselectAll();

			shape2.Text = s2;
			shape2.SelectAll();
			shape2.SelectionAlignment = HorizontalAlignment.Center;
			shape2.DeselectAll();
		}

		// X-Y Koordinat sistemi olsuturma
		public void createXYCoordinateSystem(Graphics g)
		{
			g.DrawLine(penCoord, 0,500,1000,500);
			g.DrawLine(penCoord, 500,0,500,1000);
		}

		// X-Y-Z Koordinat sistemi olsuturma
		public void createXYZCoordinateSystem(Graphics g)
		{
			g.DrawLine(penCoord, 500, 500, 1000, 500);
			g.DrawLine(penCoord, 500, 500, 500, 0);
			g.DrawLine(penCoord, 0, 1000, 500, 500);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (TextBox tb in inputTextBoxList) { tb.Visible = false; }
			foreach (TextBox tb in labelTextBoxList) { tb.Visible = false; }
			foreach (Button b in drawButtonList) { b.Visible = false; }
			foreach (RichTextBox rtb in richTextBoxList) { rtb.Visible = false; }
			button8.Visible = false;
			button9.Visible = false;
			result.Visible = false;
			groupBox1.Visible = false;
			back.Visible = false;
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			panel3.Width = 1040;
			pictureBox1.Width = 1000;
			pictureBox1.Height = 1000;
			Graphics g = e.Graphics;
		}

		// Kare secildiginde
		private void button1_Click(object sender, EventArgs e)
		{
			createXYCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox7.Text = "Merkezin X";
			textBox8.Text = "Merkezin Y";
			textBox9.Text = "Kenar Uzunlugu";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			drawSquare.Visible = true;
			drawSquare.Text = "Çiz";
		}

		// Kare cizdirme
		private void drawSquare_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int edgeLength = Convert.ToInt32(textBox3.Text);
			Point center = new Point(x, y);
			Square square = new Square(center, edgeLength);
			
			shapeList.add(square);

			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

			square.Draw(graphics, pen, brush);

			if (shapeList.getListLength() < 2)
			{
				backToMenu();

				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				button5.Enabled = false;
				button6.Enabled = false;
				button7.Enabled = false;
				button9.Visible = false;
			}
		}

		// Dikdortgen secildiginde
		private void button2_Click(object sender, EventArgs e)
		{
			createXYCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox4.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox7.Text = "Merkezin X";
			textBox8.Text = "Merkezin Y";
			textBox9.Text = "Genislik";
			textBox10.Text = "Yükseklik";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			drawRectangle.Visible = true;
			drawRectangle.Text = "Çiz";
		}

		// Dikdortgen cizdirme
		private void drawRectangle_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int width = Convert.ToInt32(textBox3.Text);
			int height = Convert.ToInt32(textBox4.Text);
			Point center = new Point(x, y);
			Rectangle rectangle = new Rectangle(center, height, width);

			shapeList.add(rectangle);

			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

			rectangle.Draw(graphics, pen, brush);

			if (shapeList.getListLength() < 2)
			{
				shapeList.setFirstShape(2);
				backToMenu();

				button1.Enabled = false;
				button4.Enabled = false;
				button5.Enabled = false;
				button6.Enabled = false;
				button7.Enabled = false;
				button8.Enabled = false;
				button9.Visible = false;
			}
			else
			{
				resultScreen();
				if (shapeList.getFirstShape() == 2)
				{
					result.Text = cd.result(cd.RectangleRectangleCollision( (Rectangle)shapeList.getItem(0), (Rectangle)shapeList.getItem(1) ));
					printRichTextBox(((Rectangle)shapeList.getItem(0)).Print(),((Rectangle)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 3){
					result.Text = cd.result(cd.RectangleCircleCollision((Rectangle)shapeList.getItem(1),(Circle)shapeList.getItem(0)));
					printRichTextBox(((Rectangle)shapeList.getItem(1)).Print(), ((Circle)shapeList.getItem(0)).Print());
				}
			}
		}

		// Cember secildiginde
		private void button3_Click(object sender, EventArgs e)
		{
			createXYCoordinateSystem(graphics);
			foreach(Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox7.Text = "Merkezin X";
			textBox8.Text = "Merkezin Y";
			textBox9.Text = "Yarıçap";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			drawCircle.Visible = true;
			drawCircle.Text = "Çiz";
		}

		// Cember cizdirme
		public void drawCircle_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int radius = Convert.ToInt32(textBox3.Text);
			Point center = new Point(x, y);
			Circle circle = new Circle(center, radius);
			shapeList.add(circle);

			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

			circle.Draw(graphics, pen, brush);

			if (shapeList.getListLength() < 2)
			{
				shapeList.setFirstShape(3);
				backToMenu();

				button1.Enabled = false;
				button4.Enabled = false;
				button5.Enabled = false;
				button6.Enabled = false;
				button7.Enabled = false;
				button9.Visible = false;
			}
			else
			{
				resultScreen();
				if (shapeList.getFirstShape() == 3)
				{
					result.Text = cd.result(cd.CircleCircleCollision((Circle)shapeList.getItem(0), (Circle)shapeList.getItem(1)));
					printRichTextBox(((Circle)shapeList.getItem(0)).Print(), ((Circle)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 2)
				{
					result.Text = cd.result(cd.RectangleCircleCollision((Rectangle)shapeList.getItem(0), (Circle)shapeList.getItem(1)));
					printRichTextBox(((Rectangle)shapeList.getItem(0)).Print(), ((Circle)shapeList.getItem(1)).Print());
				}
			}
		}

		// Kure secildiginde
		private void button4_Click(object sender, EventArgs e)
		{
			createXYZCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox4.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox7.Text = "Merkezin X";
			textBox8.Text = "Merkezin Y";
			textBox9.Text = "Merkezin Z";
			textBox10.Text = "Yariçap";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			drawSphere.Visible = true;
			drawSphere.Text = "Çiz";
		}

		// Kure cizdirme
		private void drawSphere_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int z = Convert.ToInt32(textBox3.Text);
			int radius = Convert.ToInt32(textBox4.Text);
			PointThreeD center = new PointThreeD(x, y, z);
			Sphere sphere = new Sphere(center, radius);
			shapeList.add(sphere);

			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

			sphere.Draw(graphics, pen, brush);

			if (shapeList.getListLength() < 2)
			{
				shapeList.setFirstShape(4);
				backToMenu();

				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button8.Visible = false;
			}
			else
			{
				resultScreen();
				if (shapeList.getFirstShape() == 4)
				{
					result.Text = cd.result(cd.SphereSphereCollision((Sphere)shapeList.getItem(0), (Sphere)shapeList.getItem(1)));
					printRichTextBox(((Sphere)shapeList.getItem(0)).Print(), ((Sphere)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 5)
				{
					result.Text = cd.result(cd.SphereQuadrangularCollision((Sphere)shapeList.getItem(1), (Quadrangular)shapeList.getItem(0)));
					printRichTextBox(((Quadrangular)shapeList.getItem(0)).Print(), ((Sphere)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 6)
				{
					result.Text = cd.result(cd.SphereCylinderCollision((Sphere)shapeList.getItem(1), (Cylinder)shapeList.getItem(0)));
					printRichTextBox(((Cylinder)shapeList.getItem(0)).Print(), ((Sphere)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 7)
				{
					result.Text = cd.result(cd.SurfaceSphereCollision((Surface)shapeList.getItem(0), (Sphere)shapeList.getItem(1)));
					printRichTextBox(((Surface)shapeList.getItem(0)).Print(), ((Sphere)shapeList.getItem(1)).Print());
				}
			}
		}

		// Dikdortgen prizma secildiginde
		private void button5_Click(object sender, EventArgs e)
		{
			createXYZCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox4.Visible = true;
			textBox5.Visible = true;
			textBox6.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox11.Visible = true;
			textBox12.Visible = true;
			textBox7.Text = "Merkezin X";
			textBox8.Text = "Merkezin Y";
			textBox9.Text = "Merkezin Z";
			textBox10.Text = "Genislik (X)";
			textBox11.Text = "Yükseklik (Y)";
			textBox12.Text = "Uzunluk (Z)";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			textBox5.Text = "0";
			textBox6.Text = "0";
			drawQuadrangular.Visible = true;
			drawQuadrangular.Text = "Çiz";
		}

		// Dikdortgen prizma cizdirme
		private void drawQuadrangular_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int z = Convert.ToInt32(textBox3.Text);
			int width = Convert.ToInt32(textBox4.Text);
			int heigth = Convert.ToInt32(textBox5.Text);
			int length = Convert.ToInt32(textBox6.Text);
			PointThreeD center = new PointThreeD(x, y, z);
			Quadrangular quadrangular = new Quadrangular(center, width, heigth, length);
			shapeList.add(quadrangular);

			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

			quadrangular.Draw(graphics, pen, brush);

			if (shapeList.getListLength() < 2)
			{
				shapeList.setFirstShape(5);
				backToMenu();

				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button6.Enabled = false;
				button8.Visible = false;
			}
			else
			{
				resultScreen();
				if (shapeList.getFirstShape() == 4)
				{
					result.Text = cd.result(cd.SphereQuadrangularCollision((Sphere)shapeList.getItem(0), (Quadrangular)shapeList.getItem(1)));
					printRichTextBox(((Sphere)shapeList.getItem(0)).Print(), ((Quadrangular)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 5)
				{
					result.Text = cd.result(cd.QuadrangularQuadrangularCollision((Quadrangular)shapeList.getItem(0), (Quadrangular)shapeList.getItem(1)));
					printRichTextBox(((Quadrangular)shapeList.getItem(0)).Print(), ((Quadrangular)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 7)
				{
					result.Text = cd.result(cd.SurfaceQuadrangularCollision((Surface)shapeList.getItem(0), (Quadrangular)shapeList.getItem(1)));
					printRichTextBox(((Surface)shapeList.getItem(0)).Print(), ((Quadrangular)shapeList.getItem(1)).Print());
				}
			}
		}

		// Silindir secildiginde
		private void button6_Click(object sender, EventArgs e)
		{
			createXYZCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox4.Visible = true;
			textBox5.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox11.Visible = true;
			textBox7.Text = "Merkezin X";
			textBox8.Text = "Merkezin Y";
			textBox9.Text = "Merkezin Z";
			textBox10.Text = "Yariçap";
			textBox11.Text = "Yükseklik (Y)";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			textBox5.Text = "0";
			drawCylinder.Visible = true;
			drawCylinder.Text = "Çiz";
		}

		// Silindir cizdirme
		private void drawCylinder_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int z = Convert.ToInt32(textBox3.Text);
			int radius = Convert.ToInt32(textBox4.Text);
			int heigth = Convert.ToInt32(textBox5.Text);
			PointThreeD center = new PointThreeD(x, y, z);
			Cylinder cylinder = new Cylinder(center, heigth, radius);
			shapeList.add(cylinder);

			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

			cylinder.Draw(graphics, pen, brush);

			if (shapeList.getListLength() < 2)
			{
				shapeList.setFirstShape(6);
				backToMenu();

				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button5.Enabled = false;
				button8.Visible = false;
			}
			else
			{
				resultScreen();
				if (shapeList.getFirstShape() == 4)
				{
					result.Text = cd.result(cd.SphereCylinderCollision((Sphere)shapeList.getItem(0), (Cylinder)shapeList.getItem(1)));
					printRichTextBox(((Sphere)shapeList.getItem(0)).Print(), ((Cylinder)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 6)
				{
					result.Text = cd.result(cd.CylinderCylinderCollision((Cylinder)shapeList.getItem(0), (Cylinder)shapeList.getItem(1)));
					printRichTextBox(((Cylinder)shapeList.getItem(0)).Print(), ((Cylinder)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 7)
				{
					result.Text = cd.result(cd.SurfaceCylinderCollision((Surface)shapeList.getItem(0), (Cylinder)shapeList.getItem(1)));
					printRichTextBox(((Surface)shapeList.getItem(0)).Print(), ((Cylinder)shapeList.getItem(1)).Print());
				}
			}
		}

		// Yuzey secildiginde
		private void button7_Click(object sender, EventArgs e)
		{
			createXYZCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox4.Visible = true;
			textBox5.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox11.Visible = true;
			textBox7.Text = "Merkezin X";
			textBox8.Text = "Merkezin Y";
			textBox9.Text = "Merkezin Z";
			textBox10.Text = "Genislik (X)";
			textBox11.Text = "Yükseklik (Y)";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			textBox5.Text = "0";
			drawSurface.Visible = true;
			drawSurface.Text = "Çiz";
		}

		// Yuzey cizildiginde
		private void drawSurface_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int z = Convert.ToInt32(textBox3.Text);
			int width = Convert.ToInt32(textBox4.Text);
			int heigth = Convert.ToInt32(textBox5.Text);
			PointThreeD center = new PointThreeD(x, y, z);
			Surface surface = new Surface(center, width, heigth);
			shapeList.add(surface);

			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));

			surface.Draw(graphics, pen, brush);

			if (shapeList.getListLength() < 2)
			{
				shapeList.setFirstShape(7);
				backToMenu();

				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button7.Enabled = false;
				button9.Enabled = false;
				button8.Visible = false;
			}
			else
			{
				resultScreen();
				if (shapeList.getFirstShape() == 4)
				{
					result.Text = cd.result(cd.SurfaceSphereCollision((Surface)shapeList.getItem(1), (Sphere)shapeList.getItem(0)));
					printRichTextBox(((Sphere)shapeList.getItem(0)).Print(), ((Surface)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 5)
				{
					result.Text = cd.result(cd.SurfaceQuadrangularCollision((Surface)shapeList.getItem(1), (Quadrangular)shapeList.getItem(0)));
					printRichTextBox(((Quadrangular)shapeList.getItem(0)).Print(), ((Surface)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 6)
				{
					result.Text = cd.result(cd.SurfaceCylinderCollision((Surface)shapeList.getItem(1), (Cylinder)shapeList.getItem(0)));
					printRichTextBox(((Surface)shapeList.getItem(1)).Print(), ((Cylinder)shapeList.getItem(0)).Print());
				}
			}
		}
		
		// 3D Nokta secildiginde
		private void button9_Click(object sender, EventArgs e)
		{
			createXYZCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox7.Text = "X";
			textBox8.Text = "Y";
			textBox9.Text = "Z";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			drawPointThreeD.Visible = true;
			drawPointThreeD.Text = "Çiz";
		}

		// 3D Nokta cizdirme
		private void drawPointThreeD_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			int z = Convert.ToInt32(textBox3.Text);
			PointThreeD point = new PointThreeD(x,y,z);
			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
			shapeList.add(point);

			point.Draw(graphics, pen, brush);

			if (shapeList.getListLength() >= 2)
			{
				resultScreen();
				if (shapeList.getFirstShape() == 4)
				{
					result.Text = cd.result(cd.PointSphereCollision((PointThreeD)shapeList.getItem(1), (Sphere)shapeList.getItem(0)));
					printRichTextBox(((Sphere)shapeList.getItem(0)).Print(), ((PointThreeD)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 5)
				{
					result.Text = cd.result(cd.PointQuadrangularCollision((PointThreeD)shapeList.getItem(1), (Quadrangular)shapeList.getItem(0)));
					printRichTextBox(((Quadrangular)shapeList.getItem(0)).Print(), ((PointThreeD)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 6)
				{
					result.Text = cd.result(cd.PointCylinderCollision((PointThreeD)shapeList.getItem(1), (Cylinder)shapeList.getItem(0)));
					printRichTextBox(((Cylinder)shapeList.getItem(0)).Print(), ((PointThreeD)shapeList.getItem(1)).Print());
				}
			}
		}

		// 2D Nokta secildiginde
		private void button8_Click(object sender, EventArgs e)
		{
			createXYCoordinateSystem(graphics);
			foreach (Button b in buttonList)
			{
				b.Visible = false;
			}
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox7.Text = "X";
			textBox8.Text = "Y";
			textBox1.Text = "0";
			textBox2.Text = "0";
			drawPoint.Visible = true;
			drawPoint.Text = "Çiz";
		}

		// 2D Nokta cizdirme
		private void drawPoint_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(textBox1.Text);
			int y = Convert.ToInt32(textBox2.Text);
			Point point = new Point(x, y);
			Brush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
			shapeList.add(point);

			point.Draw(graphics, pen, brush);

			if (shapeList.getListLength() >= 2)
			{
				resultScreen();
				if (shapeList.getFirstShape() == 1)
				{
					result.Text = cd.result(cd.PointSquareCollision((Point)shapeList.getItem(1), (Square)shapeList.getItem(0)));
					printRichTextBox(((Square)shapeList.getItem(0)).Print(), ((Point)shapeList.getItem(1)).Print());
				}
				else if (shapeList.getFirstShape() == 3)
				{
					result.Text = cd.result(cd.PointCircleCollision((Point)shapeList.getItem(1), (Circle)shapeList.getItem(0)));
					printRichTextBox(((Circle)shapeList.getItem(0)).Print(), ((Point)shapeList.getItem(1)).Print());
				}
			}
		}

		// Baslangic ekranina donme tusu
		private void back_Click(object sender, EventArgs e)
		{
			backToMenu();
			foreach (Button b in buttonList) { b.Enabled = true; }
			button8.Visible = false;
			button9.Visible = false;
			pictureBox1.Refresh();
			shapeList.removeAll();
		}
	}
}
