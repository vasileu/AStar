namespace City
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.rowCountEdit = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.startRowEdit = new System.Windows.Forms.TextBox();
            this.finishRowEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.columnCountEdit = new System.Windows.Forms.TextBox();
            this.startColumnBox1 = new System.Windows.Forms.TextBox();
            this.finishColumnEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.drawOpened = new System.Windows.Forms.CheckBox();
            this.coloringCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalWageLbl = new System.Windows.Forms.Label();
            this.KoeffEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openedCountLbl = new System.Windows.Forms.Label();
            this.heightDiffLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(818, 105);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(100, 23);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // rowCountEdit
            // 
            this.rowCountEdit.Location = new System.Drawing.Point(818, 25);
            this.rowCountEdit.Name = "rowCountEdit";
            this.rowCountEdit.Size = new System.Drawing.Size(100, 20);
            this.rowCountEdit.TabIndex = 2;
            this.rowCountEdit.Text = "20";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(813, 455);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(103, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(9, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 600);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // startRowEdit
            // 
            this.startRowEdit.Location = new System.Drawing.Point(818, 203);
            this.startRowEdit.Name = "startRowEdit";
            this.startRowEdit.Size = new System.Drawing.Size(100, 20);
            this.startRowEdit.TabIndex = 6;
            this.startRowEdit.Text = "1";
            // 
            // finishRowEdit
            // 
            this.finishRowEdit.Location = new System.Drawing.Point(818, 314);
            this.finishRowEdit.Name = "finishRowEdit";
            this.finishRowEdit.Size = new System.Drawing.Size(100, 20);
            this.finishRowEdit.TabIndex = 7;
            this.finishRowEdit.Text = "19";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество строк";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Начальный пункт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Конечный пункт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(818, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Количество столбцов";
            // 
            // columnCountEdit
            // 
            this.columnCountEdit.Location = new System.Drawing.Point(818, 55);
            this.columnCountEdit.Name = "columnCountEdit";
            this.columnCountEdit.Size = new System.Drawing.Size(100, 20);
            this.columnCountEdit.TabIndex = 13;
            this.columnCountEdit.Text = "25";
            // 
            // startColumnBox1
            // 
            this.startColumnBox1.Location = new System.Drawing.Point(818, 242);
            this.startColumnBox1.Name = "startColumnBox1";
            this.startColumnBox1.Size = new System.Drawing.Size(100, 20);
            this.startColumnBox1.TabIndex = 14;
            this.startColumnBox1.Text = "1";
            // 
            // finishColumnEdit
            // 
            this.finishColumnEdit.Location = new System.Drawing.Point(818, 353);
            this.finishColumnEdit.Name = "finishColumnEdit";
            this.finishColumnEdit.Size = new System.Drawing.Size(100, 20);
            this.finishColumnEdit.TabIndex = 15;
            this.finishColumnEdit.Text = "22";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Строка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Столбец";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(821, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Строка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(820, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Столбец";
            // 
            // drawOpened
            // 
            this.drawOpened.AutoSize = true;
            this.drawOpened.Location = new System.Drawing.Point(815, 380);
            this.drawOpened.Name = "drawOpened";
            this.drawOpened.Size = new System.Drawing.Size(125, 17);
            this.drawOpened.TabIndex = 21;
            this.drawOpened.Text = "открытые вершины";
            this.drawOpened.UseVisualStyleBackColor = true;
            // 
            // coloringCheckBox
            // 
            this.coloringCheckBox.AutoSize = true;
            this.coloringCheckBox.Location = new System.Drawing.Point(818, 82);
            this.coloringCheckBox.Name = "coloringCheckBox";
            this.coloringCheckBox.Size = new System.Drawing.Size(98, 17);
            this.coloringCheckBox.TabIndex = 22;
            this.coloringCheckBox.Text = " с раскраской";
            this.coloringCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Общая сумма ";
            // 
            // totalWageLbl
            // 
            this.totalWageLbl.AutoSize = true;
            this.totalWageLbl.Location = new System.Drawing.Point(101, 621);
            this.totalWageLbl.Name = "totalWageLbl";
            this.totalWageLbl.Size = new System.Drawing.Size(0, 13);
            this.totalWageLbl.TabIndex = 24;
            // 
            // KoeffEdit
            // 
            this.KoeffEdit.Location = new System.Drawing.Point(818, 419);
            this.KoeffEdit.Name = "KoeffEdit";
            this.KoeffEdit.Size = new System.Drawing.Size(100, 20);
            this.KoeffEdit.TabIndex = 25;
            this.KoeffEdit.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(816, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Коэфф учета эвристики";
            // 
            // openedCountLbl
            // 
            this.openedCountLbl.AutoSize = true;
            this.openedCountLbl.Location = new System.Drawing.Point(147, 621);
            this.openedCountLbl.Name = "openedCountLbl";
            this.openedCountLbl.Size = new System.Drawing.Size(0, 13);
            this.openedCountLbl.TabIndex = 27;
            // 
            // heightDiffLbl
            // 
            this.heightDiffLbl.AutoSize = true;
            this.heightDiffLbl.Location = new System.Drawing.Point(419, 621);
            this.heightDiffLbl.Name = "heightDiffLbl";
            this.heightDiffLbl.Size = new System.Drawing.Size(0, 13);
            this.heightDiffLbl.TabIndex = 28;
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(622, 620);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(0, 13);
            this.lengthLbl.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 646);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.heightDiffLbl);
            this.Controls.Add(this.openedCountLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.KoeffEdit);
            this.Controls.Add(this.totalWageLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coloringCheckBox);
            this.Controls.Add(this.drawOpened);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finishColumnEdit);
            this.Controls.Add(this.startColumnBox1);
            this.Controls.Add(this.columnCountEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishRowEdit);
            this.Controls.Add(this.startRowEdit);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.rowCountEdit);
            this.Controls.Add(this.generateBtn);
            this.Name = "Form1";
            this.Text = "Поиск кратчайшего пути";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox rowCountEdit;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox startRowEdit;
        private System.Windows.Forms.TextBox finishRowEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox columnCountEdit;
        private System.Windows.Forms.TextBox startColumnBox1;
        private System.Windows.Forms.TextBox finishColumnEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox drawOpened;
        private System.Windows.Forms.CheckBox coloringCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalWageLbl;
        private System.Windows.Forms.TextBox KoeffEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label openedCountLbl;
        private System.Windows.Forms.Label heightDiffLbl;
        private System.Windows.Forms.Label lengthLbl;
    }
}

