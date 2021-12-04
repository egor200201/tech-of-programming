namespace myproject
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtFirstname = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLastname = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.surname = new MaterialSkin.Controls.MaterialLabel();
            this.form1mistake = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(874, 504);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(133, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "log as doctor";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstname.Depth = 0;
            this.txtFirstname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFirstname.Location = new System.Drawing.Point(491, 96);
            this.txtFirstname.MaxLength = 50;
            this.txtFirstname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(194, 50);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.Text = "";
            // 
            // txtLastname
            // 
            this.txtLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.Depth = 0;
            this.txtLastname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLastname.Location = new System.Drawing.Point(491, 197);
            this.txtLastname.MaxLength = 50;
            this.txtLastname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastname.Multiline = false;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(194, 50);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(336, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "name";
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.Red;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.ForeColor = System.Drawing.Color.Black;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(354, 504);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(122, 36);
            this.materialButton2.TabIndex = 6;
            this.materialButton2.Text = "log as admin";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // surname
            // 
            this.surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surname.AutoSize = true;
            this.surname.Depth = 0;
            this.surname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.surname.Location = new System.Drawing.Point(336, 207);
            this.surname.MouseState = MaterialSkin.MouseState.HOVER;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(63, 19);
            this.surname.TabIndex = 8;
            this.surname.Text = "surname";
            // 
            // form1mistake
            // 
            this.form1mistake.AutoSize = true;
            this.form1mistake.Depth = 0;
            this.form1mistake.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.form1mistake.Location = new System.Drawing.Point(520, 306);
            this.form1mistake.MouseState = MaterialSkin.MouseState.HOVER;
            this.form1mistake.Name = "form1mistake";
            this.form1mistake.Size = new System.Drawing.Size(107, 19);
            this.form1mistake.TabIndex = 9;
            this.form1mistake.Text = "materialLabel2";
            this.form1mistake.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 543);
            this.Controls.Add(this.form1mistake);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.materialButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox txtFirstname;
        private MaterialSkin.Controls.MaterialTextBox txtLastname;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel surname;
        private MaterialSkin.Controls.MaterialLabel form1mistake;
    }
}

