
namespace Nachklausur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texBoxVNam = new System.Windows.Forms.TextBox();
            this.texBoxNName = new System.Windows.Forms.TextBox();
            this.texBoxGDat = new System.Windows.Forms.TextBox();
            this.texBoxAddr = new System.Windows.Forms.TextBox();
            this.lisBoxStud = new System.Windows.Forms.ListBox();
            this.butStudSpeich = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comBoxNot = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.texBoxNot = new System.Windows.Forms.TextBox();
            this.lisBoxNot = new System.Windows.Forms.ListBox();
            this.butSpeichNot = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labAnz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geburtsdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse:";
            // 
            // texBoxVNam
            // 
            this.texBoxVNam.Location = new System.Drawing.Point(12, 37);
            this.texBoxVNam.Name = "texBoxVNam";
            this.texBoxVNam.Size = new System.Drawing.Size(150, 31);
            this.texBoxVNam.TabIndex = 4;
            // 
            // texBoxNName
            // 
            this.texBoxNName.Location = new System.Drawing.Point(12, 108);
            this.texBoxNName.Name = "texBoxNName";
            this.texBoxNName.Size = new System.Drawing.Size(150, 31);
            this.texBoxNName.TabIndex = 5;
            // 
            // texBoxGDat
            // 
            this.texBoxGDat.Location = new System.Drawing.Point(12, 180);
            this.texBoxGDat.Name = "texBoxGDat";
            this.texBoxGDat.Size = new System.Drawing.Size(150, 31);
            this.texBoxGDat.TabIndex = 6;
            // 
            // texBoxAddr
            // 
            this.texBoxAddr.Location = new System.Drawing.Point(12, 251);
            this.texBoxAddr.Name = "texBoxAddr";
            this.texBoxAddr.Size = new System.Drawing.Size(150, 31);
            this.texBoxAddr.TabIndex = 7;
            // 
            // lisBoxStud
            // 
            this.lisBoxStud.FormattingEnabled = true;
            this.lisBoxStud.ItemHeight = 25;
            this.lisBoxStud.Location = new System.Drawing.Point(286, 29);
            this.lisBoxStud.Name = "lisBoxStud";
            this.lisBoxStud.Size = new System.Drawing.Size(409, 254);
            this.lisBoxStud.TabIndex = 8;
            // 
            // butStudSpeich
            // 
            this.butStudSpeich.Location = new System.Drawing.Point(168, 249);
            this.butStudSpeich.Name = "butStudSpeich";
            this.butStudSpeich.Size = new System.Drawing.Size(112, 34);
            this.butStudSpeich.TabIndex = 9;
            this.butStudSpeich.Text = "Speichern";
            this.butStudSpeich.UseVisualStyleBackColor = true;
            this.butStudSpeich.Click += new System.EventHandler(this.butStudSpeich_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fach:";
            // 
            // comBoxNot
            // 
            this.comBoxNot.FormattingEnabled = true;
            this.comBoxNot.Items.AddRange(new object[] {
            "Mathe",
            "Programmieren",
            "Zeichen",
            "Logik"});
            this.comBoxNot.Location = new System.Drawing.Point(701, 68);
            this.comBoxNot.Name = "comBoxNot";
            this.comBoxNot.Size = new System.Drawing.Size(182, 33);
            this.comBoxNot.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Note:";
            // 
            // texBoxNot
            // 
            this.texBoxNot.Location = new System.Drawing.Point(701, 142);
            this.texBoxNot.Name = "texBoxNot";
            this.texBoxNot.Size = new System.Drawing.Size(150, 31);
            this.texBoxNot.TabIndex = 13;
            // 
            // lisBoxNot
            // 
            this.lisBoxNot.FormattingEnabled = true;
            this.lisBoxNot.ItemHeight = 25;
            this.lisBoxNot.Location = new System.Drawing.Point(899, 20);
            this.lisBoxNot.Name = "lisBoxNot";
            this.lisBoxNot.Size = new System.Drawing.Size(180, 254);
            this.lisBoxNot.TabIndex = 14;
            // 
            // butSpeichNot
            // 
            this.butSpeichNot.Location = new System.Drawing.Point(781, 240);
            this.butSpeichNot.Name = "butSpeichNot";
            this.butSpeichNot.Size = new System.Drawing.Size(112, 34);
            this.butSpeichNot.TabIndex = 15;
            this.butSpeichNot.Text = "Speichern";
            this.butSpeichNot.UseVisualStyleBackColor = true;
            this.butSpeichNot.Click += new System.EventHandler(this.butSpeichNot_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(824, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anzahl:";
            // 
            // labAnz
            // 
            this.labAnz.AutoSize = true;
            this.labAnz.Location = new System.Drawing.Point(899, 295);
            this.labAnz.Name = "labAnz";
            this.labAnz.Size = new System.Drawing.Size(22, 25);
            this.labAnz.TabIndex = 17;
            this.labAnz.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 344);
            this.Controls.Add(this.labAnz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butSpeichNot);
            this.Controls.Add(this.lisBoxNot);
            this.Controls.Add(this.texBoxNot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comBoxNot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butStudSpeich);
            this.Controls.Add(this.lisBoxStud);
            this.Controls.Add(this.texBoxAddr);
            this.Controls.Add(this.texBoxGDat);
            this.Controls.Add(this.texBoxNName);
            this.Controls.Add(this.texBoxVNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texBoxVNam;
        private System.Windows.Forms.TextBox texBoxNName;
        private System.Windows.Forms.TextBox texBoxGDat;
        private System.Windows.Forms.TextBox texBoxAddr;
        private System.Windows.Forms.ListBox lisBoxStud;
        private System.Windows.Forms.Button butStudSpeich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comBoxNot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texBoxNot;
        private System.Windows.Forms.ListBox lisBoxNot;
        private System.Windows.Forms.Button butSpeichNot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labAnz;
    }
}

