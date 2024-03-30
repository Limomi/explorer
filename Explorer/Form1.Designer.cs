namespace Explorer
{
    partial class explover
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.path_box_1 = new System.Windows.Forms.TextBox();
            this.forvard_to_1 = new System.Windows.Forms.Button();
            this.back_to_1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.path_box_2 = new System.Windows.Forms.TextBox();
            this.forvard_to_2 = new System.Windows.Forms.Button();
            this.back_to_2 = new System.Windows.Forms.Button();
            this.restoke_1 = new System.Windows.Forms.Button();
            this.restoke_2 = new System.Windows.Forms.Button();
            this.search_bar_2 = new System.Windows.Forms.TextBox();
            this.search_bar_1 = new System.Windows.Forms.TextBox();
            this.search_button_1 = new System.Windows.Forms.Button();
            this.search_button_2 = new System.Windows.Forms.Button();
            this.back_list_1 = new System.Windows.Forms.ListBox();
            this.back_list_2 = new System.Windows.Forms.ListBox();
            this.forvard_list_1 = new System.Windows.Forms.ListBox();
            this.forvard_list_2 = new System.Windows.Forms.ListBox();
            this.count_1 = new System.Windows.Forms.Label();
            this.count_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(5, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 578);
            this.panel1.TabIndex = 0;
            // 
            // path_box_1
            // 
            this.path_box_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.path_box_1.Location = new System.Drawing.Point(81, 18);
            this.path_box_1.Name = "path_box_1";
            this.path_box_1.Size = new System.Drawing.Size(322, 21);
            this.path_box_1.TabIndex = 3;
            this.path_box_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.path_box_1_KeyPress);
            // 
            // forvard_to_1
            // 
            this.forvard_to_1.Enabled = false;
            this.forvard_to_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.forvard_to_1.Location = new System.Drawing.Point(55, 17);
            this.forvard_to_1.Name = "forvard_to_1";
            this.forvard_to_1.Size = new System.Drawing.Size(20, 23);
            this.forvard_to_1.TabIndex = 2;
            this.forvard_to_1.Text = ">";
            this.forvard_to_1.UseVisualStyleBackColor = true;
            this.forvard_to_1.Click += new System.EventHandler(this.forvard_to_1_Click);
            // 
            // back_to_1
            // 
            this.back_to_1.Enabled = false;
            this.back_to_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.back_to_1.Location = new System.Drawing.Point(29, 17);
            this.back_to_1.Name = "back_to_1";
            this.back_to_1.Size = new System.Drawing.Size(20, 23);
            this.back_to_1.TabIndex = 0;
            this.back_to_1.Text = "<";
            this.back_to_1.UseVisualStyleBackColor = true;
            this.back_to_1.Click += new System.EventHandler(this.back_to_1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(614, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 578);
            this.panel2.TabIndex = 1;
            // 
            // path_box_2
            // 
            this.path_box_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.path_box_2.Location = new System.Drawing.Point(684, 16);
            this.path_box_2.Name = "path_box_2";
            this.path_box_2.Size = new System.Drawing.Size(322, 21);
            this.path_box_2.TabIndex = 4;
            this.path_box_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.path_box_2_KeyPress);
            // 
            // forvard_to_2
            // 
            this.forvard_to_2.Enabled = false;
            this.forvard_to_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.forvard_to_2.Location = new System.Drawing.Point(658, 17);
            this.forvard_to_2.Name = "forvard_to_2";
            this.forvard_to_2.Size = new System.Drawing.Size(20, 23);
            this.forvard_to_2.TabIndex = 3;
            this.forvard_to_2.Text = ">";
            this.forvard_to_2.UseVisualStyleBackColor = true;
            this.forvard_to_2.Click += new System.EventHandler(this.forvard_to_2_Click);
            // 
            // back_to_2
            // 
            this.back_to_2.Enabled = false;
            this.back_to_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.back_to_2.Location = new System.Drawing.Point(632, 17);
            this.back_to_2.Name = "back_to_2";
            this.back_to_2.Size = new System.Drawing.Size(20, 23);
            this.back_to_2.TabIndex = 1;
            this.back_to_2.Text = "<";
            this.back_to_2.UseVisualStyleBackColor = true;
            this.back_to_2.Click += new System.EventHandler(this.back_to_2_Click);
            // 
            // restoke_1
            // 
            this.restoke_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.restoke_1.Location = new System.Drawing.Point(409, 17);
            this.restoke_1.Name = "restoke_1";
            this.restoke_1.Size = new System.Drawing.Size(20, 23);
            this.restoke_1.TabIndex = 4;
            this.restoke_1.UseVisualStyleBackColor = true;
            this.restoke_1.Click += new System.EventHandler(this.restoke_1_Click);
            // 
            // restoke_2
            // 
            this.restoke_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.restoke_2.Location = new System.Drawing.Point(1012, 17);
            this.restoke_2.Name = "restoke_2";
            this.restoke_2.Size = new System.Drawing.Size(20, 23);
            this.restoke_2.TabIndex = 6;
            this.restoke_2.UseVisualStyleBackColor = true;
            this.restoke_2.Click += new System.EventHandler(this.restoke_2_Click);
            // 
            // search_bar_2
            // 
            this.search_bar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.search_bar_2.Location = new System.Drawing.Point(1038, 18);
            this.search_bar_2.Name = "search_bar_2";
            this.search_bar_2.Size = new System.Drawing.Size(136, 21);
            this.search_bar_2.TabIndex = 7;
            this.search_bar_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_bar_2_KeyPress);
            // 
            // search_bar_1
            // 
            this.search_bar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.search_bar_1.Location = new System.Drawing.Point(435, 17);
            this.search_bar_1.Name = "search_bar_1";
            this.search_bar_1.Size = new System.Drawing.Size(130, 21);
            this.search_bar_1.TabIndex = 8;
            this.search_bar_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_bar_1_KeyPress);
            // 
            // search_button_1
            // 
            this.search_button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.search_button_1.Location = new System.Drawing.Point(571, 16);
            this.search_button_1.Name = "search_button_1";
            this.search_button_1.Size = new System.Drawing.Size(20, 23);
            this.search_button_1.TabIndex = 9;
            this.search_button_1.Text = "S";
            this.search_button_1.UseVisualStyleBackColor = true;
            this.search_button_1.Click += new System.EventHandler(this.search_button_1_Click);
            // 
            // search_button_2
            // 
            this.search_button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.search_button_2.Location = new System.Drawing.Point(1180, 17);
            this.search_button_2.Name = "search_button_2";
            this.search_button_2.Size = new System.Drawing.Size(20, 23);
            this.search_button_2.TabIndex = 8;
            this.search_button_2.Text = "S";
            this.search_button_2.UseVisualStyleBackColor = true;
            this.search_button_2.Click += new System.EventHandler(this.search_button_2_Click);
            // 
            // back_list_1
            // 
            this.back_list_1.Enabled = false;
            this.back_list_1.FormattingEnabled = true;
            this.back_list_1.Location = new System.Drawing.Point(-1, 2);
            this.back_list_1.Name = "back_list_1";
            this.back_list_1.Size = new System.Drawing.Size(24, 43);
            this.back_list_1.TabIndex = 0;
            this.back_list_1.TabStop = false;
            this.back_list_1.UseTabStops = false;
            this.back_list_1.Visible = false;
            // 
            // back_list_2
            // 
            this.back_list_2.FormattingEnabled = true;
            this.back_list_2.Location = new System.Drawing.Point(40, 2);
            this.back_list_2.Name = "back_list_2";
            this.back_list_2.Size = new System.Drawing.Size(72, 17);
            this.back_list_2.TabIndex = 10;
            this.back_list_2.TabStop = false;
            this.back_list_2.UseTabStops = false;
            this.back_list_2.Visible = false;
            // 
            // forvard_list_1
            // 
            this.forvard_list_1.Enabled = false;
            this.forvard_list_1.FormattingEnabled = true;
            this.forvard_list_1.Location = new System.Drawing.Point(134, 2);
            this.forvard_list_1.Name = "forvard_list_1";
            this.forvard_list_1.Size = new System.Drawing.Size(72, 17);
            this.forvard_list_1.TabIndex = 11;
            this.forvard_list_1.TabStop = false;
            this.forvard_list_1.UseTabStops = false;
            this.forvard_list_1.Visible = false;
            // 
            // forvard_list_2
            // 
            this.forvard_list_2.Enabled = false;
            this.forvard_list_2.FormattingEnabled = true;
            this.forvard_list_2.Location = new System.Drawing.Point(223, 2);
            this.forvard_list_2.Name = "forvard_list_2";
            this.forvard_list_2.Size = new System.Drawing.Size(72, 17);
            this.forvard_list_2.TabIndex = 12;
            this.forvard_list_2.TabStop = false;
            this.forvard_list_2.UseTabStops = false;
            this.forvard_list_2.Visible = false;
            // 
            // count_1
            // 
            this.count_1.AutoSize = true;
            this.count_1.Location = new System.Drawing.Point(12, 629);
            this.count_1.Name = "count_1";
            this.count_1.Size = new System.Drawing.Size(35, 13);
            this.count_1.TabIndex = 13;
            this.count_1.Text = "label1";
            this.count_1.Visible = false;
            // 
            // count_2
            // 
            this.count_2.AutoSize = true;
            this.count_2.Location = new System.Drawing.Point(611, 629);
            this.count_2.Name = "count_2";
            this.count_2.Size = new System.Drawing.Size(35, 13);
            this.count_2.TabIndex = 14;
            this.count_2.Text = "label1";
            this.count_2.Visible = false;
            // 
            // explover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 646);
            this.Controls.Add(this.count_2);
            this.Controls.Add(this.count_1);
            this.Controls.Add(this.forvard_list_2);
            this.Controls.Add(this.forvard_list_1);
            this.Controls.Add(this.back_list_2);
            this.Controls.Add(this.back_list_1);
            this.Controls.Add(this.search_button_2);
            this.Controls.Add(this.search_button_1);
            this.Controls.Add(this.search_bar_2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.restoke_2);
            this.Controls.Add(this.search_bar_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.path_box_2);
            this.Controls.Add(this.back_to_1);
            this.Controls.Add(this.forvard_to_2);
            this.Controls.Add(this.restoke_1);
            this.Controls.Add(this.back_to_2);
            this.Controls.Add(this.forvard_to_1);
            this.Controls.Add(this.path_box_1);
            this.Name = "explover";
            this.Text = "explover";
            this.Load += new System.EventHandler(this.explover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox path_box_1;
        private System.Windows.Forms.Button forvard_to_1;
        private System.Windows.Forms.Button back_to_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox path_box_2;
        private System.Windows.Forms.Button forvard_to_2;
        private System.Windows.Forms.Button back_to_2;
        private System.Windows.Forms.Button restoke_1;
        private System.Windows.Forms.Button restoke_2;
        private System.Windows.Forms.Button search_button_1;
        private System.Windows.Forms.TextBox search_bar_1;
        private System.Windows.Forms.Button search_button_2;
        private System.Windows.Forms.TextBox search_bar_2;
        private System.Windows.Forms.ListBox back_list_1;
        private System.Windows.Forms.ListBox back_list_2;
        private System.Windows.Forms.ListBox forvard_list_1;
        private System.Windows.Forms.ListBox forvard_list_2;
        private System.Windows.Forms.Label count_1;
        private System.Windows.Forms.Label count_2;
    }
}

