namespace StockPredictor
{
    partial class Input_Form
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
            this.Button_loadstock = new System.Windows.Forms.Button();
            this.DateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.openFileDialog_load = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Button_loadstock
            // 
            this.Button_loadstock.Location = new System.Drawing.Point(328, 12);
            this.Button_loadstock.Name = "Button_loadstock";
            this.Button_loadstock.Size = new System.Drawing.Size(176, 40);
            this.Button_loadstock.TabIndex = 0;
            this.Button_loadstock.Text = "Load Stock(s)";
            this.Button_loadstock.UseVisualStyleBackColor = true;
            this.Button_loadstock.Click += new System.EventHandler(this.load_button_Click);
            // 
            // DateTimePicker_end
            // 
            this.DateTimePicker_end.Location = new System.Drawing.Point(412, 58);
            this.DateTimePicker_end.Name = "DateTimePicker_end";
            this.DateTimePicker_end.Size = new System.Drawing.Size(392, 31);
            this.DateTimePicker_end.TabIndex = 1;
            this.DateTimePicker_end.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // DateTimePicker_start
            // 
            this.DateTimePicker_start.Location = new System.Drawing.Point(12, 58);
            this.DateTimePicker_start.Name = "DateTimePicker_start";
            this.DateTimePicker_start.Size = new System.Drawing.Size(394, 31);
            this.DateTimePicker_start.TabIndex = 2;
            this.DateTimePicker_start.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_start.ValueChanged += new System.EventHandler(this.starttimepicker_ValueChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(12, 12);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(110, 25);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start Time";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(700, 12);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(103, 25);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End Time";
            // 
            // openFileDialog_load
            // 
            this.openFileDialog_load.FileName = "openFileDialog_load";
            this.openFileDialog_load.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            this.openFileDialog_load.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog_load.RestoreDirectory = true;
            this.openFileDialog_load.ShowHelp = true;
            this.openFileDialog_load.Title = "File Selection";
            // 
            // Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.DateTimePicker_start);
            this.Controls.Add(this.DateTimePicker_end);
            this.Controls.Add(this.Button_loadstock);
            this.Name = "Input_Form";
            this.Text = "Load Stock";
            this.Load += new System.EventHandler(this.Input_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_loadstock;
        private System.Windows.Forms.DateTimePicker DateTimePicker_end;
        private System.Windows.Forms.DateTimePicker DateTimePicker_start;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog_load;
    }
}

