﻿namespace Result
{
    partial class AllPerson
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleTrebovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleRaspisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGodnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultPrichinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new Result.ButtonNew();
            this.DelButton = new Result.ButtonNew();
            this.SaveButton = new Result.ButtonNew();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.categoryPersonDataGridViewTextBoxColumn,
            this.armStatusDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.articleTrebovanieDataGridViewTextBoxColumn,
            this.articleRaspisanieDataGridViewTextBoxColumn,
            this.diagnosDataGridViewTextBoxColumn,
            this.categoryGodnostDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.resultIdDataGridViewTextBoxColumn,
            this.resultDateDataGridViewTextBoxColumn,
            this.resultPrichinaDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1920, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            // 
            // categoryPersonDataGridViewTextBoxColumn
            // 
            this.categoryPersonDataGridViewTextBoxColumn.DataPropertyName = "Category_Person";
            this.categoryPersonDataGridViewTextBoxColumn.HeaderText = "Категория освидетельствуемого";
            this.categoryPersonDataGridViewTextBoxColumn.Name = "categoryPersonDataGridViewTextBoxColumn";
            // 
            // armStatusDataGridViewTextBoxColumn
            // 
            this.armStatusDataGridViewTextBoxColumn.DataPropertyName = "Arm_Status";
            this.armStatusDataGridViewTextBoxColumn.HeaderText = "Воинское звание";
            this.armStatusDataGridViewTextBoxColumn.Name = "armStatusDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.FillWeight = 70F;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // articleTrebovanieDataGridViewTextBoxColumn
            // 
            this.articleTrebovanieDataGridViewTextBoxColumn.DataPropertyName = "Article_Trebovanie";
            this.articleTrebovanieDataGridViewTextBoxColumn.HeaderText = "Статьи Требований";
            this.articleTrebovanieDataGridViewTextBoxColumn.Name = "articleTrebovanieDataGridViewTextBoxColumn";
            // 
            // articleRaspisanieDataGridViewTextBoxColumn
            // 
            this.articleRaspisanieDataGridViewTextBoxColumn.DataPropertyName = "Article_Raspisanie";
            this.articleRaspisanieDataGridViewTextBoxColumn.HeaderText = "Статьи Расписания";
            this.articleRaspisanieDataGridViewTextBoxColumn.Name = "articleRaspisanieDataGridViewTextBoxColumn";
            // 
            // diagnosDataGridViewTextBoxColumn
            // 
            this.diagnosDataGridViewTextBoxColumn.DataPropertyName = "Diagnos";
            this.diagnosDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.diagnosDataGridViewTextBoxColumn.Name = "diagnosDataGridViewTextBoxColumn";
            // 
            // categoryGodnostDataGridViewTextBoxColumn
            // 
            this.categoryGodnostDataGridViewTextBoxColumn.DataPropertyName = "Category_Godnost";
            this.categoryGodnostDataGridViewTextBoxColumn.FillWeight = 50F;
            this.categoryGodnostDataGridViewTextBoxColumn.HeaderText = "Категория годности";
            this.categoryGodnostDataGridViewTextBoxColumn.Name = "categoryGodnostDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Заключение";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // resultIdDataGridViewTextBoxColumn
            // 
            this.resultIdDataGridViewTextBoxColumn.DataPropertyName = "Result_Id";
            this.resultIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.resultIdDataGridViewTextBoxColumn.HeaderText = "Номер заключения";
            this.resultIdDataGridViewTextBoxColumn.Name = "resultIdDataGridViewTextBoxColumn";
            // 
            // resultDateDataGridViewTextBoxColumn
            // 
            this.resultDateDataGridViewTextBoxColumn.DataPropertyName = "Result_Date";
            this.resultDateDataGridViewTextBoxColumn.FillWeight = 70F;
            this.resultDateDataGridViewTextBoxColumn.HeaderText = "Дата заключения";
            this.resultDateDataGridViewTextBoxColumn.Name = "resultDateDataGridViewTextBoxColumn";
            // 
            // resultPrichinaDataGridViewTextBoxColumn
            // 
            this.resultPrichinaDataGridViewTextBoxColumn.DataPropertyName = "Result_Prichina";
            this.resultPrichinaDataGridViewTextBoxColumn.HeaderText = "Заключение о причинной связи";
            this.resultPrichinaDataGridViewTextBoxColumn.Name = "resultPrichinaDataGridViewTextBoxColumn";
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Result_models.Person);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.AddButton.BackColorGradientEnabled = false;
            this.AddButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AddButton.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AddButton.BorderColorEnabled = false;
            this.AddButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AddButton.BorderColorOnHoverEnabled = false;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(606, 371);
            this.AddButton.Name = "AddButton";
            this.AddButton.RippleColor = System.Drawing.Color.Black;
            this.AddButton.RoundingEnable = false;
            this.AddButton.Size = new System.Drawing.Size(193, 38);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.TextHover = null;
            this.AddButton.UseDownPressEffectOnClick = false;
            this.AddButton.UseRippleEffect = true;
            this.AddButton.UseZoomEffectOnHover = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DelButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.DelButton.BackColorGradientEnabled = false;
            this.DelButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.DelButton.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.DelButton.BorderColorEnabled = false;
            this.DelButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.DelButton.BorderColorOnHoverEnabled = false;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DelButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.DelButton.ForeColor = System.Drawing.Color.White;
            this.DelButton.Location = new System.Drawing.Point(834, 371);
            this.DelButton.Name = "DelButton";
            this.DelButton.RippleColor = System.Drawing.Color.Black;
            this.DelButton.RoundingEnable = false;
            this.DelButton.Size = new System.Drawing.Size(193, 38);
            this.DelButton.TabIndex = 9;
            this.DelButton.Text = "Удалить запись";
            this.DelButton.TextHover = null;
            this.DelButton.UseDownPressEffectOnClick = false;
            this.DelButton.UseRippleEffect = true;
            this.DelButton.UseZoomEffectOnHover = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.SaveButton.BackColorGradientEnabled = false;
            this.SaveButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SaveButton.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.BorderColorEnabled = false;
            this.SaveButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SaveButton.BorderColorOnHoverEnabled = false;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(1055, 371);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RippleColor = System.Drawing.Color.Black;
            this.SaveButton.RoundingEnable = false;
            this.SaveButton.Size = new System.Drawing.Size(193, 38);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.TextHover = null;
            this.SaveButton.UseDownPressEffectOnClick = false;
            this.SaveButton.UseRippleEffect = true;
            this.SaveButton.UseZoomEffectOnHover = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AllPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 421);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllPerson";
            this.Text = "Результаты ВВК";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn armStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleTrebovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleRaspisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGodnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultPrichinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ButtonNew AddButton;
        private ButtonNew DelButton;
        private ButtonNew SaveButton;
    }
}

