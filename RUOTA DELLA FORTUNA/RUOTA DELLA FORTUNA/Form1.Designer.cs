namespace RUOTA_DELLA_FORTUNA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnGira = new Button();
            lbl1 = new Label();
            pictureBoxRuota = new PictureBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            lblPremio = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuota).BeginInit();
            SuspendLayout();
            // 
            // btnGira
            // 
            btnGira.BackColor = Color.Transparent;
            btnGira.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGira.Location = new Point(567, 185);
            btnGira.Name = "btnGira";
            btnGira.Size = new Size(153, 97);
            btnGira.TabIndex = 1;
            btnGira.Text = "Gira la Ruota";
            btnGira.UseVisualStyleBackColor = false;
            btnGira.Click += button1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(31, 185);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(149, 25);
            lbl1.TabIndex = 2;
            lbl1.Text = "HAI VINTO:";
            // 
            // pictureBoxRuota
            // 
            pictureBoxRuota.AccessibleName = "ruota";
            pictureBoxRuota.Image = Properties.Resources.Drawing;
            pictureBoxRuota.Location = new Point(349, 303);
            pictureBoxRuota.Name = "pictureBoxRuota";
            pictureBoxRuota.Size = new Size(749, 521);
            pictureBoxRuota.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRuota.TabIndex = 3;
            pictureBoxRuota.TabStop = false;
            pictureBoxRuota.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(442, 91);
            label1.Name = "label1";
            label1.Size = new Size(414, 44);
            label1.TabIndex = 4;
            label1.Text = "RUOTA DELLA FORTUNA";
            label1.Click += label1_Click;
            // 
            // lblPremio
            // 
            lblPremio.AutoSize = true;
            lblPremio.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPremio.Location = new Point(31, 252);
            lblPremio.Name = "lblPremio";
            lblPremio.Size = new Size(0, 30);
            lblPremio.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 866);
            Controls.Add(lblPremio);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(btnGira);
            Controls.Add(pictureBoxRuota);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGira;
        private Label lbl1;
        private PictureBox pictureBoxRuota;
        private ToolTip toolTip1;
        private Label label1;
        private Label lblPremio;
    }
}