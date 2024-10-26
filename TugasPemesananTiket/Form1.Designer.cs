namespace TugasPemesananTiket
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonVip = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelAdditionalServices = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxFood = new System.Windows.Forms.CheckBox();
            this.checkBoxDrink = new System.Windows.Forms.CheckBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanelSeat.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanelAdditionalServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.buttonOrder);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(418, 366);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nama";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(400, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.comboBoxFilm);
            this.groupBox2.Location = new System.Drawing.Point(3, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipe Film";
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.AutoCompleteCustomSource.AddRange(new string[] { "Action", "Komedi", "Drama" });
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Items.AddRange(new object[] { "Action", "Komedi", "Drama" });
            this.comboBoxFilm.Location = new System.Drawing.Point(6, 19);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(400, 21);
            this.comboBoxFilm.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.flowLayoutPanelSeat);
            this.groupBox3.Location = new System.Drawing.Point(3, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipe Kursi";
            // 
            // flowLayoutPanelSeat
            // 
            this.flowLayoutPanelSeat.AutoScroll = true;
            this.flowLayoutPanelSeat.AutoSize = true;
            this.flowLayoutPanelSeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelSeat.Controls.Add(this.radioButtonRegular);
            this.flowLayoutPanelSeat.Controls.Add(this.radioButtonVip);
            this.flowLayoutPanelSeat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSeat.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanelSeat.Name = "flowLayoutPanelSeat";
            this.flowLayoutPanelSeat.Size = new System.Drawing.Size(110, 60);
            this.flowLayoutPanelSeat.TabIndex = 2;
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.Location = new System.Drawing.Point(3, 3);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(104, 24);
            this.radioButtonRegular.TabIndex = 3;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "Regular";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonVip
            // 
            this.radioButtonVip.Location = new System.Drawing.Point(3, 33);
            this.radioButtonVip.Name = "radioButtonVip";
            this.radioButtonVip.Size = new System.Drawing.Size(104, 24);
            this.radioButtonVip.TabIndex = 4;
            this.radioButtonVip.TabStop = true;
            this.radioButtonVip.Text = "VIP";
            this.radioButtonVip.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.flowLayoutPanelAdditionalServices);
            this.groupBox4.Location = new System.Drawing.Point(3, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(122, 98);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Layanan Tambahan";
            // 
            // flowLayoutPanelAdditionalServices
            // 
            this.flowLayoutPanelAdditionalServices.AutoSize = true;
            this.flowLayoutPanelAdditionalServices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAdditionalServices.Controls.Add(this.checkBoxFood);
            this.flowLayoutPanelAdditionalServices.Controls.Add(this.checkBoxDrink);
            this.flowLayoutPanelAdditionalServices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAdditionalServices.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanelAdditionalServices.Name = "flowLayoutPanelAdditionalServices";
            this.flowLayoutPanelAdditionalServices.Size = new System.Drawing.Size(110, 60);
            this.flowLayoutPanelAdditionalServices.TabIndex = 3;
            // 
            // checkBoxFood
            // 
            this.checkBoxFood.Location = new System.Drawing.Point(3, 3);
            this.checkBoxFood.Name = "checkBoxFood";
            this.checkBoxFood.Size = new System.Drawing.Size(104, 24);
            this.checkBoxFood.TabIndex = 2;
            this.checkBoxFood.Text = "Makanan";
            this.checkBoxFood.UseVisualStyleBackColor = true;
            // 
            // checkBoxDrink
            // 
            this.checkBoxDrink.Location = new System.Drawing.Point(3, 33);
            this.checkBoxDrink.Name = "checkBoxDrink";
            this.checkBoxDrink.Size = new System.Drawing.Size(104, 24);
            this.checkBoxDrink.TabIndex = 4;
            this.checkBoxDrink.Text = "Minuman";
            this.checkBoxDrink.UseVisualStyleBackColor = true;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrder.AutoSize = true;
            this.buttonOrder.Location = new System.Drawing.Point(3, 340);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(412, 23);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Pesan";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 392);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(460, 431);
            this.Name = "Form1";
            this.Text = "Pemesanan Tiket";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanelSeat.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanelAdditionalServices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonOrder;

        private System.Windows.Forms.CheckBox checkBoxFood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAdditionalServices;
        private System.Windows.Forms.CheckBox checkBoxDrink;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSeat;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonVip;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.ComboBox comboBoxFilm;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox2;

        #endregion
    }
}