﻿namespace Result
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NamTextBox = new System.Windows.Forms.TextBox();
            this.MiddNamTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.category_person = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.arm_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.category_godnost = new System.Windows.Forms.ComboBox();
            this.categoryGodnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.article_raspisanie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.article_trebovanie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ChairmanTextBox = new System.Windows.Forms.TextBox();
            this.result_date = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.Diagnos = new Result.EgoldsGoogleTextBox();
            this.result = new Result.EgoldsGoogleTextBox();
            this.categoryPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGodnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameTextBox.Location = new System.Drawing.Point(125, 26);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(183, 22);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // NamTextBox
            // 
            this.NamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamTextBox.Location = new System.Drawing.Point(125, 62);
            this.NamTextBox.Name = "NamTextBox";
            this.NamTextBox.Size = new System.Drawing.Size(183, 22);
            this.NamTextBox.TabIndex = 4;
            // 
            // MiddNamTextBox
            // 
            this.MiddNamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddNamTextBox.Location = new System.Drawing.Point(125, 102);
            this.MiddNamTextBox.Name = "MiddNamTextBox";
            this.MiddNamTextBox.Size = new System.Drawing.Size(183, 22);
            this.MiddNamTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(568, 460);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(154, 38);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // category_person
            // 
            this.category_person.FormattingEnabled = true;
            this.category_person.Location = new System.Drawing.Point(610, 31);
            this.category_person.Name = "category_person";
            this.category_person.Size = new System.Drawing.Size(239, 24);
            this.category_person.TabIndex = 7;
            this.category_person.SelectedIndexChanged += new System.EventHandler(this.category_person_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Категория освидетельствуемого";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Воинское звание";
            // 
            // arm_status
            // 
            this.arm_status.FormattingEnabled = true;
            this.arm_status.Location = new System.Drawing.Point(610, 79);
            this.arm_status.Name = "arm_status";
            this.arm_status.Size = new System.Drawing.Size(239, 24);
            this.arm_status.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Категория годности";
            // 
            // category_godnost
            // 
            this.category_godnost.FormattingEnabled = true;
            this.category_godnost.Location = new System.Drawing.Point(610, 129);
            this.category_godnost.Name = "category_godnost";
            this.category_godnost.Size = new System.Drawing.Size(239, 24);
            this.category_godnost.TabIndex = 11;
            // 
            // article_raspisanie
            // 
            this.article_raspisanie.Location = new System.Drawing.Point(70, 189);
            this.article_raspisanie.Name = "article_raspisanie";
            this.article_raspisanie.Size = new System.Drawing.Size(87, 22);
            this.article_raspisanie.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "статьи";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "графы";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 22);
            this.textBox2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Расписания болезней";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Требований №1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "графы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 22);
            this.textBox1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "статьи";
            // 
            // article_trebovanie
            // 
            this.article_trebovanie.Location = new System.Drawing.Point(70, 224);
            this.article_trebovanie.Name = "article_trebovanie";
            this.article_trebovanie.Size = new System.Drawing.Size(87, 22);
            this.article_trebovanie.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(742, 460);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(154, 38);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(404, 418);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "Председатель ВВК";
            // 
            // ChairmanTextBox
            // 
            this.ChairmanTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChairmanTextBox.Location = new System.Drawing.Point(558, 418);
            this.ChairmanTextBox.Name = "ChairmanTextBox";
            this.ChairmanTextBox.Size = new System.Drawing.Size(373, 22);
            this.ChairmanTextBox.TabIndex = 31;
            // 
            // result_date
            // 
            this.result_date.Location = new System.Drawing.Point(558, 389);
            this.result_date.Name = "result_date";
            this.result_date.Size = new System.Drawing.Size(373, 22);
            this.result_date.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(465, 389);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "Дата ВВК";
            // 
            // Diagnos
            // 
            this.Diagnos.BackColor = System.Drawing.Color.White;
            this.Diagnos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Diagnos.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.Diagnos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Diagnos.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Diagnos.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.Diagnos.ForeColor = System.Drawing.Color.Black;
            this.Diagnos.Location = new System.Drawing.Point(483, 283);
            this.Diagnos.MultiLine = true;
            this.Diagnos.Name = "Diagnos";
            this.Diagnos.Size = new System.Drawing.Size(448, 89);
            this.Diagnos.TabIndex = 35;
            this.Diagnos.TextInput = "Диагноз";
            this.Diagnos.TextPreview = "Диагноз";
            this.Diagnos.UseSystemPasswordChar = false;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.result.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.result.Font = new System.Drawing.Font("Arial", 11.25F);
            this.result.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(15, 283);
            this.result.Name = "result";
            this.result.MultiLine = true;
            this.result.Size = new System.Drawing.Size(432, 89);
            this.result.TabIndex = 34;
            this.result.TextInput = "Результат";
            this.result.TextPreview = "Результат";
            this.result.UseSystemPasswordChar = false;
            // 
            // categoryPersonBindingSource
            // 
            this.categoryPersonBindingSource.DataSource = typeof(Result_models.Category_Person);
            // 
            // armStatusBindingSource
            // 
            this.armStatusBindingSource.DataSource = typeof(Result_models.Arm_Status);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 510);
            this.Controls.Add(this.Diagnos);
            this.Controls.Add(this.result);
            this.Controls.Add(this.result_date);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ChairmanTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.article_trebovanie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.article_raspisanie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category_godnost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arm_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.category_person);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MiddNamTextBox);
            this.Controls.Add(this.NamTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внесение записи";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGodnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        /*Общие сведения об обследуемом*/
        protected internal System.Windows.Forms.TextBox SurnameTextBox;
        protected internal System.Windows.Forms.TextBox NamTextBox;
        protected internal System.Windows.Forms.TextBox MiddNamTextBox;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        
        /*Категории*/
        protected internal System.Windows.Forms.ComboBox category_person;
        protected internal System.Windows.Forms.ComboBox arm_status;

        /*Все что связано с диагнозом*/
        protected internal System.Windows.Forms.TextBox article_trebovanie;
        protected internal System.Windows.Forms.TextBox article_raspisanie;
        protected internal System.Windows.Forms.ComboBox category_godnost;
        
        
        protected internal System.Windows.Forms.TextBox textBox2;
        protected internal System.Windows.Forms.TextBox textBox1;


        protected internal System.Windows.Forms.Button AddButton;

        protected internal System.Windows.Forms.Button CancelButton;




        private System.Windows.Forms.BindingSource categoryPersonBindingSource;
        private System.Windows.Forms.BindingSource armStatusBindingSource;
        private System.Windows.Forms.BindingSource categoryGodnostBindingSource;
        private System.Windows.Forms.Label label16;
        protected internal System.Windows.Forms.TextBox ChairmanTextBox;
        protected internal System.Windows.Forms.DateTimePicker result_date;
        private System.Windows.Forms.Label label17;
        private EgoldsGoogleTextBox result;
        private EgoldsGoogleTextBox Diagnos;
    }
}