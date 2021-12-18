namespace myproject
{
    partial class Formnewobsl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formnewobsl));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPatientname = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.presureCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.tempCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.moisturerCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ElCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.rateCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPatientsurname = new MaterialSkin.Controls.MaterialTextBox();
            this.inmistake = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 142);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "patient name";
            // 
            // txtPatientname
            // 
            this.txtPatientname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientname.Depth = 0;
            this.txtPatientname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPatientname.Location = new System.Drawing.Point(209, 129);
            this.txtPatientname.MaxLength = 50;
            this.txtPatientname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPatientname.Multiline = false;
            this.txtPatientname.Name = "txtPatientname";
            this.txtPatientname.Size = new System.Drawing.Size(196, 50);
            this.txtPatientname.TabIndex = 1;
            this.txtPatientname.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(837, 142);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "sensors";
            // 
            // materialRadioButton4
            // 
            this.materialRadioButton4.AutoSize = true;
            this.materialRadioButton4.Depth = 0;
            this.materialRadioButton4.Location = new System.Drawing.Point(688, 192);
            this.materialRadioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton4.Name = "materialRadioButton4";
            this.materialRadioButton4.Ripple = true;
            this.materialRadioButton4.Size = new System.Drawing.Size(68, 37);
            this.materialRadioButton4.TabIndex = 6;
            this.materialRadioButton4.TabStop = true;
            this.materialRadioButton4.Text = "walk";
            this.materialRadioButton4.UseVisualStyleBackColor = true;
            this.materialRadioButton4.CheckedChanged += new System.EventHandler(this.materialRadioButton4_CheckedChanged);
            // 
            // materialRadioButton5
            // 
            this.materialRadioButton5.AutoSize = true;
            this.materialRadioButton5.Depth = 0;
            this.materialRadioButton5.Location = new System.Drawing.Point(688, 142);
            this.materialRadioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton5.Name = "materialRadioButton5";
            this.materialRadioButton5.Ripple = true;
            this.materialRadioButton5.Size = new System.Drawing.Size(58, 37);
            this.materialRadioButton5.TabIndex = 7;
            this.materialRadioButton5.TabStop = true;
            this.materialRadioButton5.Text = "run";
            this.materialRadioButton5.UseVisualStyleBackColor = true;
            this.materialRadioButton5.CheckedChanged += new System.EventHandler(this.materialRadioButton5_CheckedChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(437, 142);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(168, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "type of physical activity";
            // 
            // presureCheckbox
            // 
            this.presureCheckbox.AutoSize = true;
            this.presureCheckbox.Depth = 0;
            this.presureCheckbox.Location = new System.Drawing.Point(952, 142);
            this.presureCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.presureCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.presureCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.presureCheckbox.Name = "presureCheckbox";
            this.presureCheckbox.Ripple = true;
            this.presureCheckbox.Size = new System.Drawing.Size(190, 37);
            this.presureCheckbox.TabIndex = 9;
            this.presureCheckbox.Text = "blood pressure sensor";
            this.presureCheckbox.UseVisualStyleBackColor = true;
            this.presureCheckbox.CheckedChanged += new System.EventHandler(this.presureCheckbox_CheckedChanged);
            // 
            // tempCheckbox
            // 
            this.tempCheckbox.AutoSize = true;
            this.tempCheckbox.Depth = 0;
            this.tempCheckbox.Location = new System.Drawing.Point(952, 192);
            this.tempCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.tempCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tempCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempCheckbox.Name = "tempCheckbox";
            this.tempCheckbox.Ripple = true;
            this.tempCheckbox.Size = new System.Drawing.Size(204, 37);
            this.tempCheckbox.TabIndex = 10;
            this.tempCheckbox.Text = "skin temperature sensor";
            this.tempCheckbox.UseVisualStyleBackColor = true;
            this.tempCheckbox.CheckedChanged += new System.EventHandler(this.tempCheckbox_CheckedChanged);
            // 
            // moisturerCheckbox
            // 
            this.moisturerCheckbox.AutoSize = true;
            this.moisturerCheckbox.Depth = 0;
            this.moisturerCheckbox.Location = new System.Drawing.Point(952, 241);
            this.moisturerCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.moisturerCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.moisturerCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.moisturerCheckbox.Name = "moisturerCheckbox";
            this.moisturerCheckbox.Ripple = true;
            this.moisturerCheckbox.Size = new System.Drawing.Size(181, 37);
            this.moisturerCheckbox.TabIndex = 11;
            this.moisturerCheckbox.Text = "skin moisture sensor";
            this.moisturerCheckbox.UseVisualStyleBackColor = true;
            this.moisturerCheckbox.CheckedChanged += new System.EventHandler(this.moisturerCheckbox_CheckedChanged);
            // 
            // ElCheckbox
            // 
            this.ElCheckbox.AutoSize = true;
            this.ElCheckbox.Depth = 0;
            this.ElCheckbox.Location = new System.Drawing.Point(952, 292);
            this.ElCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.ElCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ElCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ElCheckbox.Name = "ElCheckbox";
            this.ElCheckbox.Ripple = true;
            this.ElCheckbox.Size = new System.Drawing.Size(272, 37);
            this.ElCheckbox.TabIndex = 12;
            this.ElCheckbox.Text = "skin electrical conductivity sensor";
            this.ElCheckbox.UseVisualStyleBackColor = true;
            this.ElCheckbox.CheckedChanged += new System.EventHandler(this.ElCheckbox_CheckedChanged);
            // 
            // rateCheckbox
            // 
            this.rateCheckbox.AutoSize = true;
            this.rateCheckbox.Depth = 0;
            this.rateCheckbox.Location = new System.Drawing.Point(952, 343);
            this.rateCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.rateCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rateCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rateCheckbox.Name = "rateCheckbox";
            this.rateCheckbox.Ripple = true;
            this.rateCheckbox.Size = new System.Drawing.Size(153, 37);
            this.rateCheckbox.TabIndex = 13;
            this.rateCheckbox.Text = "heart rate sensor";
            this.rateCheckbox.UseVisualStyleBackColor = true;
            this.rateCheckbox.CheckedChanged += new System.EventHandler(this.rateCheckbox_CheckedChanged);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(688, 254);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(84, 37);
            this.materialRadioButton1.TabIndex = 14;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "bicycle";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(978, 420);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(174, 36);
            this.materialButton1.TabIndex = 15;
            this.materialButton1.Text = "sensor calibration";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(12, 229);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(116, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "patient surname";
            // 
            // txtPatientsurname
            // 
            this.txtPatientsurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientsurname.Depth = 0;
            this.txtPatientsurname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPatientsurname.Location = new System.Drawing.Point(209, 219);
            this.txtPatientsurname.MaxLength = 50;
            this.txtPatientsurname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPatientsurname.Multiline = false;
            this.txtPatientsurname.Name = "txtPatientsurname";
            this.txtPatientsurname.Size = new System.Drawing.Size(196, 50);
            this.txtPatientsurname.TabIndex = 17;
            this.txtPatientsurname.Text = "";
            // 
            // inmistake
            // 
            this.inmistake.AutoSize = true;
            this.inmistake.Depth = 0;
            this.inmistake.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inmistake.Location = new System.Drawing.Point(477, 343);
            this.inmistake.MouseState = MaterialSkin.MouseState.HOVER;
            this.inmistake.Name = "inmistake";
            this.inmistake.Size = new System.Drawing.Size(107, 19);
            this.inmistake.TabIndex = 20;
            this.inmistake.Text = "materialLabel6";
            this.inmistake.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "age";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 303);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Formnewobsl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1236, 482);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inmistake);
            this.Controls.Add(this.txtPatientsurname);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.rateCheckbox);
            this.Controls.Add(this.ElCheckbox);
            this.Controls.Add(this.moisturerCheckbox);
            this.Controls.Add(this.tempCheckbox);
            this.Controls.Add(this.presureCheckbox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialRadioButton5);
            this.Controls.Add(this.materialRadioButton4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtPatientname);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Formnewobsl";
            this.Text = "Formnewobsl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formnewobsl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtPatientname;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckbox presureCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox tempCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox moisturerCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox ElCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox rateCheckbox;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtPatientsurname;
        private MaterialSkin.Controls.MaterialLabel inmistake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}