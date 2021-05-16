
namespace WFtextchanger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wbd = new System.Windows.Forms.RadioButton();
            this.wd = new System.Windows.Forms.RadioButton();
            this.wm = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.orange = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spogrubione = new System.Windows.Forms.CheckBox();
            this.spochylone = new System.Windows.Forms.CheckBox();
            this.spodkreslone = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wbd);
            this.groupBox1.Controls.Add(this.wd);
            this.groupBox1.Controls.Add(this.wm);
            this.groupBox1.Location = new System.Drawing.Point(58, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "wielkość";
            // 
            // wbd
            // 
            this.wbd.AutoSize = true;
            this.wbd.Location = new System.Drawing.Point(7, 74);
            this.wbd.Name = "wbd";
            this.wbd.Size = new System.Drawing.Size(89, 19);
            this.wbd.TabIndex = 2;
            this.wbd.TabStop = true;
            this.wbd.Text = "bardzo duże";
            this.wbd.UseVisualStyleBackColor = true;
            // 
            // wd
            // 
            this.wd.AutoSize = true;
            this.wd.Location = new System.Drawing.Point(7, 48);
            this.wd.Name = "wd";
            this.wd.Size = new System.Drawing.Size(50, 19);
            this.wd.TabIndex = 1;
            this.wd.TabStop = true;
            this.wd.Text = "duże";
            this.wd.UseVisualStyleBackColor = true;
            // 
            // wm
            // 
            this.wm.AutoSize = true;
            this.wm.Location = new System.Drawing.Point(7, 22);
            this.wm.Name = "wm";
            this.wm.Size = new System.Drawing.Size(51, 19);
            this.wm.TabIndex = 0;
            this.wm.TabStop = true;
            this.wm.Text = "małe";
            this.wm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.orange);
            this.groupBox3.Controls.Add(this.blue);
            this.groupBox3.Controls.Add(this.red);
            this.groupBox3.Location = new System.Drawing.Point(563, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "kolor";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // orange
            // 
            this.orange.AutoSize = true;
            this.orange.Location = new System.Drawing.Point(7, 74);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(106, 19);
            this.orange.TabIndex = 2;
            this.orange.TabStop = true;
            this.orange.Text = "pomarańczowy";
            this.orange.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(7, 48);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(71, 19);
            this.blue.TabIndex = 1;
            this.blue.TabStop = true;
            this.blue.Text = "niebieski";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(7, 22);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(75, 19);
            this.red.TabIndex = 0;
            this.red.TabStop = true;
            this.red.Text = "czerwony";
            this.red.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj tekst";
            // 
            // spogrubione
            // 
            this.spogrubione.AutoSize = true;
            this.spogrubione.Location = new System.Drawing.Point(6, 22);
            this.spogrubione.Name = "spogrubione";
            this.spogrubione.Size = new System.Drawing.Size(88, 19);
            this.spogrubione.TabIndex = 0;
            this.spogrubione.Text = "pogrubione";
            this.spogrubione.UseVisualStyleBackColor = true;
            // 
            // spochylone
            // 
            this.spochylone.AutoSize = true;
            this.spochylone.Location = new System.Drawing.Point(6, 45);
            this.spochylone.Name = "spochylone";
            this.spochylone.Size = new System.Drawing.Size(82, 19);
            this.spochylone.TabIndex = 1;
            this.spochylone.Text = "pochylone";
            this.spochylone.UseVisualStyleBackColor = true;
            // 
            // spodkreslone
            // 
            this.spodkreslone.AutoSize = true;
            this.spodkreslone.Location = new System.Drawing.Point(6, 70);
            this.spodkreslone.Name = "spodkreslone";
            this.spodkreslone.Size = new System.Drawing.Size(91, 19);
            this.spodkreslone.TabIndex = 2;
            this.spodkreslone.Text = "podkreślone";
            this.spodkreslone.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spochylone);
            this.groupBox2.Controls.Add(this.spodkreslone);
            this.groupBox2.Controls.Add(this.spogrubione);
            this.groupBox2.Location = new System.Drawing.Point(313, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton wbd;
        private System.Windows.Forms.RadioButton wd;
        private System.Windows.Forms.RadioButton wm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton orange;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox spogrubione;
        private System.Windows.Forms.CheckBox spochylone;
        private System.Windows.Forms.CheckBox spodkreslone;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

