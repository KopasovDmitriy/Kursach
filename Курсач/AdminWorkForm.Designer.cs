namespace Курсач
{
    partial class AdminWorkForm
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
            this.riders_list = new System.Windows.Forms.ListBox();
            this.horses_list = new System.Windows.Forms.ListBox();
            this.races_list = new System.Windows.Forms.ListBox();
            this.bets_list = new System.Windows.Forms.ListBox();
            this.members_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_all = new System.Windows.Forms.Button();
            this.but_current = new System.Windows.Forms.Button();
            this.but_passed = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.riders_count = new System.Windows.Forms.Label();
            this.horses_count = new System.Windows.Forms.Label();
            this.races_count = new System.Windows.Forms.Label();
            this.bets_count = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clients_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // riders_list
            // 
            this.riders_list.FormattingEnabled = true;
            this.riders_list.Location = new System.Drawing.Point(482, 23);
            this.riders_list.Name = "riders_list";
            this.riders_list.Size = new System.Drawing.Size(120, 95);
            this.riders_list.TabIndex = 0;
            // 
            // horses_list
            // 
            this.horses_list.FormattingEnabled = true;
            this.horses_list.Location = new System.Drawing.Point(608, 23);
            this.horses_list.Name = "horses_list";
            this.horses_list.Size = new System.Drawing.Size(120, 95);
            this.horses_list.TabIndex = 1;
            // 
            // races_list
            // 
            this.races_list.FormattingEnabled = true;
            this.races_list.Location = new System.Drawing.Point(89, 23);
            this.races_list.Name = "races_list";
            this.races_list.Size = new System.Drawing.Size(120, 147);
            this.races_list.TabIndex = 2;
            // 
            // bets_list
            // 
            this.bets_list.FormattingEnabled = true;
            this.bets_list.Location = new System.Drawing.Point(215, 49);
            this.bets_list.Name = "bets_list";
            this.bets_list.Size = new System.Drawing.Size(109, 121);
            this.bets_list.TabIndex = 3;
            // 
            // members_list
            // 
            this.members_list.FormattingEnabled = true;
            this.members_list.Location = new System.Drawing.Point(330, 49);
            this.members_list.Name = "members_list";
            this.members_list.Size = new System.Drawing.Size(120, 121);
            this.members_list.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список наездников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список лошадей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Список заездов";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(212, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ставки на текщий заезд";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(327, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Участники текущего заезда";
            // 
            // but_all
            // 
            this.but_all.Location = new System.Drawing.Point(8, 40);
            this.but_all.Name = "but_all";
            this.but_all.Size = new System.Drawing.Size(75, 23);
            this.but_all.TabIndex = 12;
            this.but_all.Text = "Все";
            this.but_all.UseVisualStyleBackColor = true;
            // 
            // but_current
            // 
            this.but_current.Location = new System.Drawing.Point(8, 69);
            this.but_current.Name = "but_current";
            this.but_current.Size = new System.Drawing.Size(75, 23);
            this.but_current.TabIndex = 13;
            this.but_current.Text = "Текущие";
            this.but_current.UseVisualStyleBackColor = true;
            // 
            // but_passed
            // 
            this.but_passed.Location = new System.Drawing.Point(8, 98);
            this.but_passed.Name = "but_passed";
            this.but_passed.Size = new System.Drawing.Size(75, 23);
            this.but_passed.TabIndex = 14;
            this.but_passed.Text = "Прошедшие";
            this.but_passed.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Всего наездников:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Всего лошадей:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Кол-во заездов:";
            // 
            // riders_count
            // 
            this.riders_count.AutoSize = true;
            this.riders_count.Location = new System.Drawing.Point(588, 125);
            this.riders_count.Name = "riders_count";
            this.riders_count.Size = new System.Drawing.Size(13, 13);
            this.riders_count.TabIndex = 18;
            this.riders_count.Text = "0";
            // 
            // horses_count
            // 
            this.horses_count.AutoSize = true;
            this.horses_count.Location = new System.Drawing.Point(701, 125);
            this.horses_count.Name = "horses_count";
            this.horses_count.Size = new System.Drawing.Size(13, 13);
            this.horses_count.TabIndex = 19;
            this.horses_count.Text = "0";
            // 
            // races_count
            // 
            this.races_count.AutoSize = true;
            this.races_count.Location = new System.Drawing.Point(184, 173);
            this.races_count.Name = "races_count";
            this.races_count.Size = new System.Drawing.Size(13, 13);
            this.races_count.TabIndex = 20;
            this.races_count.Text = "0";
            // 
            // bets_count
            // 
            this.bets_count.AutoSize = true;
            this.bets_count.Location = new System.Drawing.Point(307, 173);
            this.bets_count.Name = "bets_count";
            this.bets_count.Size = new System.Drawing.Size(13, 13);
            this.bets_count.TabIndex = 22;
            this.bets_count.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Кол-во ставок:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Клиенты";
            // 
            // clients_list
            // 
            this.clients_list.FormattingEnabled = true;
            this.clients_list.Location = new System.Drawing.Point(8, 224);
            this.clients_list.Name = "clients_list";
            this.clients_list.Size = new System.Drawing.Size(120, 95);
            this.clients_list.TabIndex = 24;
            // 
            // AdminWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 458);
            this.Controls.Add(this.clients_list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bets_count);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.races_count);
            this.Controls.Add(this.horses_count);
            this.Controls.Add(this.riders_count);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.but_passed);
            this.Controls.Add(this.but_current);
            this.Controls.Add(this.but_all);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.members_list);
            this.Controls.Add(this.races_list);
            this.Controls.Add(this.horses_list);
            this.Controls.Add(this.riders_list);
            this.Controls.Add(this.bets_list);
            this.Name = "AdminWorkForm";
            this.Text = "AdminWorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox riders_list;
        private System.Windows.Forms.ListBox horses_list;
        private System.Windows.Forms.ListBox races_list;
        private System.Windows.Forms.ListBox bets_list;
        private System.Windows.Forms.ListBox members_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_all;
        private System.Windows.Forms.Button but_current;
        private System.Windows.Forms.Button but_passed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label riders_count;
        private System.Windows.Forms.Label horses_count;
        private System.Windows.Forms.Label races_count;
        private System.Windows.Forms.Label bets_count;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox clients_list;
    }
}