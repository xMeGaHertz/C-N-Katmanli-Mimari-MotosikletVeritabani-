﻿namespace MotoBikeDealer
{
    partial class Markalar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Markalar));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Orgovan Brush", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 118);
            label1.Name = "label1";
            label1.Size = new Size(100, 18);
            label1.TabIndex = 0;
            label1.Text = "Marka Adı :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(127, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 21);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Orgovan Brush", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(72, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Tamam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Tamam;
            // 
            // button2
            // 
            button2.Font = new Font("Orgovan Brush", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(153, 224);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += İptal;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Orgovan Brush", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(4, 39);
            label2.Name = "label2";
            label2.Size = new Size(232, 23);
            label2.TabIndex = 4;
            label2.Text = "MARKA ADINI EKLEYİNİZ";
            // 
            // Markalar
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            CancelButton = button2;
            ClientSize = new Size(240, 259);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Markalar";
            Text = "Marka Ekle";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProvider1;
        private Label label2;
    }
}