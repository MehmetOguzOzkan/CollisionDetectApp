namespace CollisionDetectApp
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.shape2 = new System.Windows.Forms.RichTextBox();
			this.shape1 = new System.Windows.Forms.RichTextBox();
			this.back = new System.Windows.Forms.Button();
			this.labelVers = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelLog = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.drawSphere = new System.Windows.Forms.Button();
			this.drawSquare = new System.Windows.Forms.Button();
			this.drawCircle = new System.Windows.Forms.Button();
			this.drawRectangle = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.drawPointThreeD = new System.Windows.Forms.Button();
			this.drawPoint = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.drawSurface = new System.Windows.Forms.Button();
			this.drawCylinder = new System.Windows.Forms.Button();
			this.drawQuadrangular = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.result = new System.Windows.Forms.RichTextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox1.Location = new System.Drawing.Point(20, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel1.Controls.Add(this.back);
			this.panel1.Controls.Add(this.labelVers);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.textBox7);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.textBox8);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox9);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox10);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox12);
			this.panel1.Controls.Add(this.textBox6);
			this.panel1.Controls.Add(this.drawSphere);
			this.panel1.Controls.Add(this.drawSquare);
			this.panel1.Controls.Add(this.drawCircle);
			this.panel1.Controls.Add(this.drawRectangle);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.drawPointThreeD);
			this.panel1.Controls.Add(this.drawPoint);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.drawSurface);
			this.panel1.Controls.Add(this.drawCylinder);
			this.panel1.Controls.Add(this.drawQuadrangular);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.textBox11);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.shape1);
			this.panel1.Controls.Add(this.shape2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.panel1.Location = new System.Drawing.Point(1324, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 1040);
			this.panel1.TabIndex = 1;
			// 
			// shape2
			// 
			this.shape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.shape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.shape2.Enabled = false;
			this.shape2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.shape2.Location = new System.Drawing.Point(50, 350);
			this.shape2.Name = "shape2";
			this.shape2.Size = new System.Drawing.Size(400, 180);
			this.shape2.TabIndex = 36;
			this.shape2.Text = "\n\n\n\n\n";
			// 
			// shape1
			// 
			this.shape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.shape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.shape1.Enabled = false;
			this.shape1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.shape1.Location = new System.Drawing.Point(50, 150);
			this.shape1.Name = "shape1";
			this.shape1.Size = new System.Drawing.Size(400, 180);
			this.shape1.TabIndex = 35;
			this.shape1.Text = "\n\n\n\n\n";
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.IndianRed;
			this.back.Location = new System.Drawing.Point(50, 850);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(400, 80);
			this.back.TabIndex = 34;
			this.back.Text = "Geri";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// labelVers
			// 
			this.labelVers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelVers.AutoSize = true;
			this.labelVers.Location = new System.Drawing.Point(230, 998);
			this.labelVers.Name = "labelVers";
			this.labelVers.Size = new System.Drawing.Size(47, 33);
			this.labelVers.TabIndex = 8;
			this.labelVers.Text = "v0.1";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(50, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(400, 80);
			this.button1.TabIndex = 7;
			this.button1.Text = "Kare";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Transparent;
			this.button7.Location = new System.Drawing.Point(50, 750);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(400, 80);
			this.button7.TabIndex = 6;
			this.button7.Text = "Yüzey";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.Location = new System.Drawing.Point(50, 650);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(400, 80);
			this.button6.TabIndex = 5;
			this.button6.Text = "Silindir";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.Location = new System.Drawing.Point(50, 450);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(400, 80);
			this.button4.TabIndex = 3;
			this.button4.Text = "Küre";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(50, 350);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(400, 80);
			this.button3.TabIndex = 2;
			this.button3.Text = "Çember";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(50, 250);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(400, 80);
			this.button2.TabIndex = 1;
			this.button2.Text = "Dikdörtgen";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.panel2.Controls.Add(this.labelLog);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(500, 100);
			this.panel2.TabIndex = 0;
			// 
			// labelLog
			// 
			this.labelLog.AutoSize = true;
			this.labelLog.BackColor = System.Drawing.Color.Transparent;
			this.labelLog.Enabled = false;
			this.labelLog.Font = new System.Drawing.Font("Corbel", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelLog.Location = new System.Drawing.Point(68, 24);
			this.labelLog.Margin = new System.Windows.Forms.Padding(0);
			this.labelLog.Name = "labelLog";
			this.labelLog.Size = new System.Drawing.Size(381, 54);
			this.labelLog.TabIndex = 0;
			this.labelLog.Text = "Çarpışma  Denetimi";
			this.labelLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Enabled = false;
			this.textBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox7.Location = new System.Drawing.Point(50, 170);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(200, 40);
			this.textBox7.TabIndex = 16;
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(250, 170);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 40);
			this.textBox1.TabIndex = 10;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Enabled = false;
			this.textBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox8.Location = new System.Drawing.Point(50, 270);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(200, 40);
			this.textBox8.TabIndex = 17;
			this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(250, 270);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 40);
			this.textBox2.TabIndex = 11;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Enabled = false;
			this.textBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox9.Location = new System.Drawing.Point(50, 370);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(200, 40);
			this.textBox9.TabIndex = 18;
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(250, 370);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 40);
			this.textBox3.TabIndex = 12;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Enabled = false;
			this.textBox10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox10.Location = new System.Drawing.Point(50, 471);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(200, 40);
			this.textBox10.TabIndex = 19;
			this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(250, 470);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 40);
			this.textBox4.TabIndex = 13;
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox12
			// 
			this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Enabled = false;
			this.textBox12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox12.Location = new System.Drawing.Point(50, 670);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(200, 40);
			this.textBox12.TabIndex = 21;
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(250, 670);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(200, 40);
			this.textBox6.TabIndex = 15;
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// drawSphere
			// 
			this.drawSphere.BackColor = System.Drawing.Color.Transparent;
			this.drawSphere.Location = new System.Drawing.Point(49, 850);
			this.drawSphere.Name = "drawSphere";
			this.drawSphere.Size = new System.Drawing.Size(400, 80);
			this.drawSphere.TabIndex = 26;
			this.drawSphere.Text = "button8";
			this.drawSphere.UseVisualStyleBackColor = false;
			this.drawSphere.Click += new System.EventHandler(this.drawSphere_Click);
			// 
			// drawSquare
			// 
			this.drawSquare.BackColor = System.Drawing.Color.Transparent;
			this.drawSquare.Location = new System.Drawing.Point(50, 850);
			this.drawSquare.Name = "drawSquare";
			this.drawSquare.Size = new System.Drawing.Size(400, 80);
			this.drawSquare.TabIndex = 25;
			this.drawSquare.Text = "button8";
			this.drawSquare.UseVisualStyleBackColor = false;
			this.drawSquare.Click += new System.EventHandler(this.drawSquare_Click);
			// 
			// drawCircle
			// 
			this.drawCircle.BackColor = System.Drawing.Color.Transparent;
			this.drawCircle.Location = new System.Drawing.Point(49, 850);
			this.drawCircle.Name = "drawCircle";
			this.drawCircle.Size = new System.Drawing.Size(400, 80);
			this.drawCircle.TabIndex = 23;
			this.drawCircle.Text = "button8";
			this.drawCircle.UseVisualStyleBackColor = false;
			this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
			// 
			// drawRectangle
			// 
			this.drawRectangle.BackColor = System.Drawing.Color.Transparent;
			this.drawRectangle.Location = new System.Drawing.Point(50, 850);
			this.drawRectangle.Name = "drawRectangle";
			this.drawRectangle.Size = new System.Drawing.Size(400, 80);
			this.drawRectangle.TabIndex = 24;
			this.drawRectangle.Text = "button8";
			this.drawRectangle.UseVisualStyleBackColor = false;
			this.drawRectangle.Click += new System.EventHandler(this.drawRectangle_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Transparent;
			this.button9.Location = new System.Drawing.Point(50, 850);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(400, 80);
			this.button9.TabIndex = 31;
			this.button9.Text = "Nokta";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// drawPointThreeD
			// 
			this.drawPointThreeD.BackColor = System.Drawing.Color.Transparent;
			this.drawPointThreeD.Location = new System.Drawing.Point(50, 850);
			this.drawPointThreeD.Name = "drawPointThreeD";
			this.drawPointThreeD.Size = new System.Drawing.Size(400, 80);
			this.drawPointThreeD.TabIndex = 30;
			this.drawPointThreeD.Text = "button8";
			this.drawPointThreeD.UseVisualStyleBackColor = false;
			this.drawPointThreeD.Click += new System.EventHandler(this.drawPointThreeD_Click);
			// 
			// drawPoint
			// 
			this.drawPoint.BackColor = System.Drawing.Color.Transparent;
			this.drawPoint.Location = new System.Drawing.Point(50, 850);
			this.drawPoint.Name = "drawPoint";
			this.drawPoint.Size = new System.Drawing.Size(400, 80);
			this.drawPoint.TabIndex = 22;
			this.drawPoint.Text = "button8";
			this.drawPoint.UseVisualStyleBackColor = false;
			this.drawPoint.Click += new System.EventHandler(this.drawPoint_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Transparent;
			this.button8.Location = new System.Drawing.Point(50, 850);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(400, 80);
			this.button8.TabIndex = 22;
			this.button8.Text = "Nokta";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// drawSurface
			// 
			this.drawSurface.BackColor = System.Drawing.Color.Transparent;
			this.drawSurface.Location = new System.Drawing.Point(49, 850);
			this.drawSurface.Name = "drawSurface";
			this.drawSurface.Size = new System.Drawing.Size(400, 80);
			this.drawSurface.TabIndex = 29;
			this.drawSurface.Text = "button8";
			this.drawSurface.UseVisualStyleBackColor = false;
			this.drawSurface.Click += new System.EventHandler(this.drawSurface_Click);
			// 
			// drawCylinder
			// 
			this.drawCylinder.BackColor = System.Drawing.Color.Transparent;
			this.drawCylinder.Location = new System.Drawing.Point(50, 850);
			this.drawCylinder.Name = "drawCylinder";
			this.drawCylinder.Size = new System.Drawing.Size(400, 80);
			this.drawCylinder.TabIndex = 28;
			this.drawCylinder.Text = "button8";
			this.drawCylinder.UseVisualStyleBackColor = false;
			this.drawCylinder.Click += new System.EventHandler(this.drawCylinder_Click);
			// 
			// drawQuadrangular
			// 
			this.drawQuadrangular.BackColor = System.Drawing.Color.Transparent;
			this.drawQuadrangular.Location = new System.Drawing.Point(49, 850);
			this.drawQuadrangular.Name = "drawQuadrangular";
			this.drawQuadrangular.Size = new System.Drawing.Size(400, 80);
			this.drawQuadrangular.TabIndex = 27;
			this.drawQuadrangular.Text = "button8";
			this.drawQuadrangular.UseVisualStyleBackColor = false;
			this.drawQuadrangular.Click += new System.EventHandler(this.drawQuadrangular_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.result);
			this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Location = new System.Drawing.Point(50, 550);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 280);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sonuç";
			// 
			// result
			// 
			this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.result.Enabled = false;
			this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.result.Location = new System.Drawing.Point(-1, 70);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(400, 200);
			this.result.TabIndex = 32;
			this.result.Text = "\n";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.Location = new System.Drawing.Point(50, 550);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(400, 80);
			this.button5.TabIndex = 4;
			this.button5.Text = "Dikdörtgen Prizma";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Enabled = false;
			this.textBox11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox11.Location = new System.Drawing.Point(50, 570);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(200, 40);
			this.textBox11.TabIndex = 20;
			this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(250, 570);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(200, 40);
			this.textBox5.TabIndex = 14;
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1040, 1040);
			this.panel3.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1824, 1040);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Collision Detect App";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelLog;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelVers;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button drawPoint;
		private System.Windows.Forms.Button drawCircle;
		private System.Windows.Forms.Button drawRectangle;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button drawSquare;
		private System.Windows.Forms.Button drawSurface;
		private System.Windows.Forms.Button drawCylinder;
		private System.Windows.Forms.Button drawQuadrangular;
		private System.Windows.Forms.Button drawSphere;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button drawPointThreeD;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox result;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.RichTextBox shape2;
		private System.Windows.Forms.RichTextBox shape1;
	}
}

