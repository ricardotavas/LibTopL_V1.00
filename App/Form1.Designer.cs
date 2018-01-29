namespace App
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_connect = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.button_ReadDateTime = new System.Windows.Forms.Button();
            this.button_WriteDateTime = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Voltage = new System.Windows.Forms.Label();
            this.button_enable = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.button_disable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status do teclado:";
            // 
            // label_connect
            // 
            this.label_connect.AutoSize = true;
            this.label_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connect.Location = new System.Drawing.Point(156, 20);
            this.label_connect.Name = "label_connect";
            this.label_connect.Size = new System.Drawing.Size(57, 20);
            this.label_connect.TabIndex = 1;
            this.label_connect.Text = "label2";
            // 
            // dt
            // 
            this.dt.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt.Location = new System.Drawing.Point(16, 58);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(163, 20);
            this.dt.TabIndex = 1;
            // 
            // button_ReadDateTime
            // 
            this.button_ReadDateTime.Location = new System.Drawing.Point(185, 55);
            this.button_ReadDateTime.Name = "button_ReadDateTime";
            this.button_ReadDateTime.Size = new System.Drawing.Size(120, 23);
            this.button_ReadDateTime.TabIndex = 2;
            this.button_ReadDateTime.Text = "Ler Hora/Data";
            this.button_ReadDateTime.UseVisualStyleBackColor = true;
            this.button_ReadDateTime.Click += new System.EventHandler(this.button_ReadDateTime_Click);
            // 
            // button_WriteDateTime
            // 
            this.button_WriteDateTime.Location = new System.Drawing.Point(311, 55);
            this.button_WriteDateTime.Name = "button_WriteDateTime";
            this.button_WriteDateTime.Size = new System.Drawing.Size(121, 23);
            this.button_WriteDateTime.TabIndex = 3;
            this.button_WriteDateTime.Text = "Gravar Hora/Data";
            this.button_WriteDateTime.UseVisualStyleBackColor = true;
            this.button_WriteDateTime.Click += new System.EventHandler(this.button_WriteDateTime_Click);
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(16, 177);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textStatus.Size = new System.Drawing.Size(416, 222);
            this.textStatus.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Voltage
            // 
            this.label_Voltage.AutoSize = true;
            this.label_Voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Voltage.Location = new System.Drawing.Point(402, 20);
            this.label_Voltage.Name = "label_Voltage";
            this.label_Voltage.Size = new System.Drawing.Size(18, 20);
            this.label_Voltage.TabIndex = 6;
            this.label_Voltage.Text = "_";
            // 
            // button_enable
            // 
            this.button_enable.Location = new System.Drawing.Point(185, 96);
            this.button_enable.Name = "button_enable";
            this.button_enable.Size = new System.Drawing.Size(120, 23);
            this.button_enable.TabIndex = 4;
            this.button_enable.Text = "Habilitar pesquisa";
            this.button_enable.UseVisualStyleBackColor = true;
            this.button_enable.Click += new System.EventHandler(this.button_enable_Click);
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(185, 138);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(120, 23);
            this.button_download.TabIndex = 6;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // button_disable
            // 
            this.button_disable.Location = new System.Drawing.Point(311, 96);
            this.button_disable.Name = "button_disable";
            this.button_disable.Size = new System.Drawing.Size(121, 23);
            this.button_disable.TabIndex = 5;
            this.button_disable.Text = "Desabilitar pesquisa";
            this.button_disable.UseVisualStyleBackColor = true;
            this.button_disable.Click += new System.EventHandler(this.button_disable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 414);
            this.Controls.Add(this.button_disable);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.button_enable);
            this.Controls.Add(this.label_Voltage);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.button_WriteDateTime);
            this.Controls.Add(this.button_ReadDateTime);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label_connect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_connect;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Button button_ReadDateTime;
        private System.Windows.Forms.Button button_WriteDateTime;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Voltage;
        private System.Windows.Forms.Button button_enable;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Button button_disable;
    }
}

