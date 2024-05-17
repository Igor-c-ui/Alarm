namespace Alarm
{
    partial class Form2
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
            button_save = new Button();
            cancel_button = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            groupBox4 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.Control;
            button_save.ForeColor = SystemColors.ControlText;
            button_save.Location = new Point(275, 26);
            button_save.Name = "button_save";
            button_save.Size = new Size(195, 35);
            button_save.TabIndex = 0;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = Color.SteelBlue;
            cancel_button.ForeColor = SystemColors.ControlText;
            cancel_button.Location = new Point(12, 26);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(109, 35);
            cancel_button.TabIndex = 1;
            cancel_button.Text = "Отменить";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 30F);
            dateTimePicker1.CalendarForeColor = SystemColors.Control;
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.Control;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.Control;
            dateTimePicker1.CustomFormat = "hh:mm";
            dateTimePicker1.Font = new Font("Times New Roman", 60F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(0, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(250, 122);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2024, 5, 12, 12, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(91, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 49);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Название:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(37, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 20);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(91, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 165);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Время:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(91, 382);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(313, 106);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Описание";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(37, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 74);
            textBox2.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Location = new Point(91, 494);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(313, 49);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Повтор";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(184, 18);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Нет";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 18);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Да";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cancel_button);
            Controls.Add(button_save);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Будильник";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_save;
        private Button cancel_button;
        private GroupBox groupBox1;
        private TextBox textBox1;
        public static DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}