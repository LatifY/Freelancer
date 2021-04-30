
namespace Freelancer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listView = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.start_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.end_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.finished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.enddate_title = new System.Windows.Forms.Label();
			this.save = new System.Windows.Forms.Button();
			this.description_box = new System.Windows.Forms.TextBox();
			this.description_title = new System.Windows.Forms.Label();
			this.back_button = new System.Windows.Forms.Button();
			this.header = new System.Windows.Forms.Label();
			this.name_title = new System.Windows.Forms.Label();
			this.name_box = new System.Windows.Forms.TextBox();
			this.price_title = new System.Windows.Forms.Label();
			this.startdate_box = new System.Windows.Forms.DateTimePicker();
			this.startdate_title = new System.Windows.Forms.Label();
			this.enddate_box = new System.Windows.Forms.DateTimePicker();
			this.finished_box = new System.Windows.Forms.CheckBox();
			this.price_box = new System.Windows.Forms.NumericUpDown();
			this.panel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.price_box)).BeginInit();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(554, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "FREELANCER";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(556, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(148, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "Customer Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(556, 213);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 25);
			this.button2.TabIndex = 3;
			this.button2.Text = "Customer Update";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(556, 258);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(148, 25);
			this.button3.TabIndex = 4;
			this.button3.Text = "Customer Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(570, 413);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "© 2021 Latif Yılmaz";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(608, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "PANEL";
			// 
			// listView
			// 
			this.listView.AllowColumnReorder = true;
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.price,
            this.start_date,
            this.end_date,
            this.description,
            this.finished});
			this.listView.FullRowSelect = true;
			this.listView.GridLines = true;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(12, 12);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(520, 418);
			this.listView.TabIndex = 0;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
			// 
			// id
			// 
			this.id.Text = "Id";
			this.id.Width = 40;
			// 
			// name
			// 
			this.name.Text = "Name";
			this.name.Width = 75;
			// 
			// price
			// 
			this.price.Text = "Price";
			this.price.Width = 50;
			// 
			// start_date
			// 
			this.start_date.Text = "Start Date";
			this.start_date.Width = 70;
			// 
			// end_date
			// 
			this.end_date.Text = "End Date";
			this.end_date.Width = 69;
			// 
			// description
			// 
			this.description.Text = "Description";
			this.description.Width = 135;
			// 
			// finished
			// 
			this.finished.Text = "Finished";
			// 
			// enddate_title
			// 
			this.enddate_title.AutoSize = true;
			this.enddate_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.enddate_title.Location = new System.Drawing.Point(220, 153);
			this.enddate_title.Name = "enddate_title";
			this.enddate_title.Size = new System.Drawing.Size(72, 16);
			this.enddate_title.TabIndex = 9;
			this.enddate_title.Text = "End Date *";
			// 
			// save
			// 
			this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.save.Location = new System.Drawing.Point(18, 390);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(120, 36);
			this.save.TabIndex = 12;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// description_box
			// 
			this.description_box.Location = new System.Drawing.Point(18, 229);
			this.description_box.Multiline = true;
			this.description_box.Name = "description_box";
			this.description_box.Size = new System.Drawing.Size(375, 106);
			this.description_box.TabIndex = 10;
			// 
			// description_title
			// 
			this.description_title.AutoSize = true;
			this.description_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.description_title.Location = new System.Drawing.Point(15, 210);
			this.description_title.Name = "description_title";
			this.description_title.Size = new System.Drawing.Size(76, 16);
			this.description_title.TabIndex = 11;
			this.description_title.Text = "Description";
			// 
			// back_button
			// 
			this.back_button.Location = new System.Drawing.Point(10, 9);
			this.back_button.Name = "back_button";
			this.back_button.Size = new System.Drawing.Size(82, 25);
			this.back_button.TabIndex = 0;
			this.back_button.Text = "<-- Back";
			this.back_button.UseVisualStyleBackColor = true;
			this.back_button.Click += new System.EventHandler(this.back_Click);
			// 
			// header
			// 
			this.header.AutoSize = true;
			this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.header.Location = new System.Drawing.Point(10, 58);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(82, 25);
			this.header.TabIndex = 1;
			this.header.Text = "Header";
			// 
			// name_title
			// 
			this.name_title.AutoSize = true;
			this.name_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.name_title.Location = new System.Drawing.Point(15, 96);
			this.name_title.Name = "name_title";
			this.name_title.Size = new System.Drawing.Size(53, 16);
			this.name_title.TabIndex = 2;
			this.name_title.Text = "Name *";
			// 
			// name_box
			// 
			this.name_box.Location = new System.Drawing.Point(18, 115);
			this.name_box.Name = "name_box";
			this.name_box.Size = new System.Drawing.Size(170, 20);
			this.name_box.TabIndex = 3;
			// 
			// price_title
			// 
			this.price_title.AutoSize = true;
			this.price_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.price_title.Location = new System.Drawing.Point(220, 96);
			this.price_title.Name = "price_title";
			this.price_title.Size = new System.Drawing.Size(47, 16);
			this.price_title.TabIndex = 4;
			this.price_title.Text = "Price *";
			// 
			// startdate_box
			// 
			this.startdate_box.CustomFormat = "MM/dd/yyyy";
			this.startdate_box.Location = new System.Drawing.Point(18, 172);
			this.startdate_box.MaxDate = new System.DateTime(2499, 12, 31, 0, 0, 0, 0);
			this.startdate_box.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.startdate_box.Name = "startdate_box";
			this.startdate_box.Size = new System.Drawing.Size(170, 20);
			this.startdate_box.TabIndex = 6;
			this.startdate_box.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
			// 
			// startdate_title
			// 
			this.startdate_title.AutoSize = true;
			this.startdate_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.startdate_title.Location = new System.Drawing.Point(15, 153);
			this.startdate_title.Name = "startdate_title";
			this.startdate_title.Size = new System.Drawing.Size(75, 16);
			this.startdate_title.TabIndex = 7;
			this.startdate_title.Text = "Start Date *";
			// 
			// enddate_box
			// 
			this.enddate_box.CustomFormat = "MM/dd/yyyy";
			this.enddate_box.Location = new System.Drawing.Point(223, 172);
			this.enddate_box.MaxDate = new System.DateTime(2499, 12, 31, 0, 0, 0, 0);
			this.enddate_box.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.enddate_box.Name = "enddate_box";
			this.enddate_box.Size = new System.Drawing.Size(170, 20);
			this.enddate_box.TabIndex = 8;
			this.enddate_box.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
			// 
			// finished_box
			// 
			this.finished_box.AutoSize = true;
			this.finished_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.finished_box.Location = new System.Drawing.Point(18, 350);
			this.finished_box.Name = "finished_box";
			this.finished_box.Size = new System.Drawing.Size(78, 20);
			this.finished_box.TabIndex = 13;
			this.finished_box.Text = "Finished";
			this.finished_box.UseVisualStyleBackColor = true;
			// 
			// price_box
			// 
			this.price_box.Location = new System.Drawing.Point(223, 116);
			this.price_box.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.price_box.Name = "price_box";
			this.price_box.Size = new System.Drawing.Size(83, 20);
			this.price_box.TabIndex = 14;
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.Transparent;
			this.panel.Controls.Add(this.price_box);
			this.panel.Controls.Add(this.finished_box);
			this.panel.Controls.Add(this.enddate_box);
			this.panel.Controls.Add(this.startdate_title);
			this.panel.Controls.Add(this.startdate_box);
			this.panel.Controls.Add(this.price_title);
			this.panel.Controls.Add(this.name_box);
			this.panel.Controls.Add(this.name_title);
			this.panel.Controls.Add(this.header);
			this.panel.Controls.Add(this.back_button);
			this.panel.Controls.Add(this.description_title);
			this.panel.Controls.Add(this.description_box);
			this.panel.Controls.Add(this.save);
			this.panel.Controls.Add(this.enddate_title);
			this.panel.Location = new System.Drawing.Point(4, 3);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(546, 437);
			this.panel.TabIndex = 11;
			this.panel.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Freelancer.Properties.Resources.icon;
			this.pictureBox1.Location = new System.Drawing.Point(600, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 442);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Freelancer";
			((System.ComponentModel.ISupportInitialize)(this.price_box)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader price;
		private System.Windows.Forms.ColumnHeader start_date;
		private System.Windows.Forms.ColumnHeader end_date;
		private System.Windows.Forms.ColumnHeader description;
		private System.Windows.Forms.ColumnHeader finished;
		private System.Windows.Forms.Label enddate_title;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.TextBox description_box;
		private System.Windows.Forms.Label description_title;
		private System.Windows.Forms.Button back_button;
		private System.Windows.Forms.Label header;
		private System.Windows.Forms.Label name_title;
		private System.Windows.Forms.TextBox name_box;
		private System.Windows.Forms.Label price_title;
		private System.Windows.Forms.DateTimePicker startdate_box;
		private System.Windows.Forms.Label startdate_title;
		private System.Windows.Forms.DateTimePicker enddate_box;
		private System.Windows.Forms.CheckBox finished_box;
		private System.Windows.Forms.NumericUpDown price_box;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}//416