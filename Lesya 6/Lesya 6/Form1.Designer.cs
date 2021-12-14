namespace Lesya_6
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
            this.BusNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.bus = new System.Windows.Forms.Label();
            this.FreePlacesrichTextBox = new System.Windows.Forms.RichTextBox();
            this.places = new System.Windows.Forms.Label();
            this.bus_full = new System.Windows.Forms.CheckBox();
            this.Stop = new System.Windows.Forms.Label();
            this.passengers = new System.Windows.Forms.Label();
            this.amount_passengersTextBox = new System.Windows.Forms.RichTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.passengers_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BusNumberTextBox
            // 
            this.BusNumberTextBox.Location = new System.Drawing.Point(155, 118);
            this.BusNumberTextBox.Name = "BusNumberTextBox";
            this.BusNumberTextBox.Size = new System.Drawing.Size(67, 27);
            this.BusNumberTextBox.TabIndex = 0;
            this.BusNumberTextBox.Text = "";
            // 
            // bus
            // 
            this.bus.AutoSize = true;
            this.bus.Location = new System.Drawing.Point(78, 118);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(61, 17);
            this.bus.TabIndex = 1;
            this.bus.Text = "Автобус";
            // 
            // FreePlacesrichTextBox
            // 
            this.FreePlacesrichTextBox.Location = new System.Drawing.Point(155, 167);
            this.FreePlacesrichTextBox.Name = "FreePlacesrichTextBox";
            this.FreePlacesrichTextBox.Size = new System.Drawing.Size(67, 27);
            this.FreePlacesrichTextBox.TabIndex = 2;
            this.FreePlacesrichTextBox.Text = "";
            // 
            // places
            // 
            this.places.AutoSize = true;
            this.places.Location = new System.Drawing.Point(35, 170);
            this.places.Name = "places";
            this.places.Size = new System.Drawing.Size(115, 17);
            this.places.TabIndex = 3;
            this.places.Text = "Свободных мест";
            // 
            // bus_full
            // 
            this.bus_full.AutoSize = true;
            this.bus_full.Location = new System.Drawing.Point(81, 77);
            this.bus_full.Name = "bus_full";
            this.bus_full.Size = new System.Drawing.Size(150, 21);
            this.bus_full.TabIndex = 4;
            this.bus_full.Text = "Автобус заполнен";
            this.bus_full.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.Location = new System.Drawing.Point(417, 81);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(79, 17);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Остановка";
            // 
            // passengers
            // 
            this.passengers.AutoSize = true;
            this.passengers.Location = new System.Drawing.Point(417, 121);
            this.passengers.Name = "passengers";
            this.passengers.Size = new System.Drawing.Size(168, 17);
            this.passengers.TabIndex = 6;
            this.passengers.Text = "Количество пассажиров";
            // 
            // amount_passengersTextBox
            // 
            this.amount_passengersTextBox.Location = new System.Drawing.Point(591, 115);
            this.amount_passengersTextBox.Name = "amount_passengersTextBox";
            this.amount_passengersTextBox.Size = new System.Drawing.Size(76, 27);
            this.amount_passengersTextBox.TabIndex = 7;
            this.amount_passengersTextBox.Text = "";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(137, 30);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(85, 23);
            this.reset.TabIndex = 8;
            this.reset.Text = "обновить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // passengers_set
            // 
            this.passengers_set.Location = new System.Drawing.Point(249, 30);
            this.passengers_set.Name = "passengers_set";
            this.passengers_set.Size = new System.Drawing.Size(169, 23);
            this.passengers_set.TabIndex = 9;
            this.passengers_set.Text = "Посадка пассажиров";
            this.passengers_set.UseVisualStyleBackColor = true;
            this.passengers_set.Click += new System.EventHandler(this.passengers_set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Пассажиров не вместилось:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passengers_set);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.amount_passengersTextBox);
            this.Controls.Add(this.passengers);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.bus_full);
            this.Controls.Add(this.places);
            this.Controls.Add(this.FreePlacesrichTextBox);
            this.Controls.Add(this.bus);
            this.Controls.Add(this.BusNumberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox BusNumberTextBox;
        private System.Windows.Forms.Label bus;
        private System.Windows.Forms.RichTextBox FreePlacesrichTextBox;
        private System.Windows.Forms.Label places;
        private System.Windows.Forms.CheckBox bus_full;
        private System.Windows.Forms.Label Stop;
        private System.Windows.Forms.Label passengers;
        private System.Windows.Forms.RichTextBox amount_passengersTextBox;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button passengers_set;
        private System.Windows.Forms.Label label1;
    }
}

