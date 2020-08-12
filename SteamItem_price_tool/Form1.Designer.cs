namespace SteamItem_price_tool
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_start = new System.Windows.Forms.Button();
            this.discount = new System.Windows.Forms.TextBox();
            this.label_Info_1 = new System.Windows.Forms.Label();
            this.label_Info_2 = new System.Windows.Forms.Label();
            this.coef_buy = new System.Windows.Forms.TextBox();
            this.dataGridView_dmarket = new System.Windows.Forms.DataGridView();
            this.dataGridView_steam = new System.Windows.Forms.DataGridView();
            this.coef_sell = new System.Windows.Forms.TextBox();
            this.label_info_3 = new System.Windows.Forms.Label();
            this.label_counter = new System.Windows.Forms.Label();
            this.dataGridView_full_info = new System.Windows.Forms.DataGridView();
            this.label_Full_info = new System.Windows.Forms.Label();
            this.dataGridView_error = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_page_counter = new System.Windows.Forms.NumericUpDown();
            this.page_counter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dmarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_steam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_full_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_page_counter)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(10, 6);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(99, 34);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discount.Location = new System.Drawing.Point(236, 10);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(60, 27);
            this.discount.TabIndex = 3;
            this.discount.Text = "0,025";
            // 
            // label_Info_1
            // 
            this.label_Info_1.AutoSize = true;
            this.label_Info_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info_1.Location = new System.Drawing.Point(126, 15);
            this.label_Info_1.Name = "label_Info_1";
            this.label_Info_1.Size = new System.Drawing.Size(92, 20);
            this.label_Info_1.TabIndex = 4;
            this.label_Info_1.Text = "% discount";
            // 
            // label_Info_2
            // 
            this.label_Info_2.AutoSize = true;
            this.label_Info_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info_2.Location = new System.Drawing.Point(327, 15);
            this.label_Info_2.Name = "label_Info_2";
            this.label_Info_2.Size = new System.Drawing.Size(76, 20);
            this.label_Info_2.TabIndex = 5;
            this.label_Info_2.Text = "coef_buy";
            // 
            // coef_buy
            // 
            this.coef_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_buy.Location = new System.Drawing.Point(425, 10);
            this.coef_buy.Name = "coef_buy";
            this.coef_buy.Size = new System.Drawing.Size(60, 27);
            this.coef_buy.TabIndex = 6;
            this.coef_buy.Text = "1,5";
            // 
            // dataGridView_dmarket
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_dmarket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_dmarket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_dmarket.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_dmarket.Location = new System.Drawing.Point(12, 44);
            this.dataGridView_dmarket.Name = "dataGridView_dmarket";
            this.dataGridView_dmarket.RowTemplate.Height = 24;
            this.dataGridView_dmarket.Size = new System.Drawing.Size(910, 260);
            this.dataGridView_dmarket.TabIndex = 8;
            // 
            // dataGridView_steam
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_steam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_steam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_steam.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_steam.Location = new System.Drawing.Point(12, 310);
            this.dataGridView_steam.Name = "dataGridView_steam";
            this.dataGridView_steam.RowTemplate.Height = 24;
            this.dataGridView_steam.Size = new System.Drawing.Size(910, 260);
            this.dataGridView_steam.TabIndex = 9;
            // 
            // coef_sell
            // 
            this.coef_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_sell.Location = new System.Drawing.Point(632, 10);
            this.coef_sell.Name = "coef_sell";
            this.coef_sell.Size = new System.Drawing.Size(60, 27);
            this.coef_sell.TabIndex = 11;
            this.coef_sell.Text = "2,085";
            // 
            // label_info_3
            // 
            this.label_info_3.AutoSize = true;
            this.label_info_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info_3.Location = new System.Drawing.Point(534, 15);
            this.label_info_3.Name = "label_info_3";
            this.label_info_3.Size = new System.Drawing.Size(76, 20);
            this.label_info_3.TabIndex = 10;
            this.label_info_3.Text = "coef_sell";
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_counter.Location = new System.Drawing.Point(1199, 11);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(0, 25);
            this.label_counter.TabIndex = 12;
            // 
            // dataGridView_full_info
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_full_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_full_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_full_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_full_info.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView_full_info.Location = new System.Drawing.Point(16, 620);
            this.dataGridView_full_info.Name = "dataGridView_full_info";
            this.dataGridView_full_info.RowTemplate.Height = 24;
            this.dataGridView_full_info.Size = new System.Drawing.Size(1234, 345);
            this.dataGridView_full_info.TabIndex = 13;
            // 
            // label_Full_info
            // 
            this.label_Full_info.AutoSize = true;
            this.label_Full_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Full_info.Location = new System.Drawing.Point(12, 582);
            this.label_Full_info.Name = "label_Full_info";
            this.label_Full_info.Size = new System.Drawing.Size(68, 20);
            this.label_Full_info.TabIndex = 14;
            this.label_Full_info.Text = "Full Info";
            // 
            // dataGridView_error
            // 
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_error.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_error.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView_error.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_error.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView_error.Location = new System.Drawing.Point(938, 44);
            this.dataGridView_error.Name = "dataGridView_error";
            this.dataGridView_error.RowTemplate.Height = 24;
            this.dataGridView_error.Size = new System.Drawing.Size(312, 260);
            this.dataGridView_error.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(934, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Error";
            // 
            // numericUpDown_page_counter
            // 
            this.numericUpDown_page_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_page_counter.Location = new System.Drawing.Point(871, 10);
            this.numericUpDown_page_counter.Name = "numericUpDown_page_counter";
            this.numericUpDown_page_counter.Size = new System.Drawing.Size(51, 27);
            this.numericUpDown_page_counter.TabIndex = 17;
            this.numericUpDown_page_counter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // page_counter
            // 
            this.page_counter.AutoSize = true;
            this.page_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.page_counter.Location = new System.Drawing.Point(728, 15);
            this.page_counter.Name = "page_counter";
            this.page_counter.Size = new System.Drawing.Size(110, 20);
            this.page_counter.TabIndex = 18;
            this.page_counter.Text = "page_counter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.page_counter);
            this.Controls.Add(this.numericUpDown_page_counter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_error);
            this.Controls.Add(this.label_Full_info);
            this.Controls.Add(this.dataGridView_full_info);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.coef_sell);
            this.Controls.Add(this.label_info_3);
            this.Controls.Add(this.dataGridView_steam);
            this.Controls.Add(this.dataGridView_dmarket);
            this.Controls.Add(this.coef_buy);
            this.Controls.Add(this.label_Info_2);
            this.Controls.Add(this.label_Info_1);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Steam_item_price_tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dmarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_steam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_full_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_page_counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label_Info_1;
        private System.Windows.Forms.Label label_Info_2;
        private System.Windows.Forms.TextBox coef_buy;
        private System.Windows.Forms.DataGridView dataGridView_dmarket;
        private System.Windows.Forms.DataGridView dataGridView_steam;
        private System.Windows.Forms.TextBox coef_sell;
        private System.Windows.Forms.Label label_info_3;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.DataGridView dataGridView_full_info;
        private System.Windows.Forms.Label label_Full_info;
        private System.Windows.Forms.DataGridView dataGridView_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_page_counter;
        private System.Windows.Forms.Label page_counter;
    }
}

