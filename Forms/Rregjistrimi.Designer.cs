namespace ResManagerAdmin.Forms
{
    partial class Rregjistrimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerial2 = new VisionInfoSolutionLibrary.TextBox();
            this.txtSerial4 = new VisionInfoSolutionLibrary.TextBox();
            this.txtSerial3 = new VisionInfoSolutionLibrary.TextBox();
            this.txtSerial1 = new VisionInfoSolutionLibrary.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ju lutemi fusni numrin e aktivizimit te cilin e keni marre nga kompania VisionInf" +
                "oSolution";
            // 
            // txtSerial2
            // 
            this.txtSerial2.DefaultErrorMessage = "";
            this.txtSerial2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial2.IsValid = true;
            this.txtSerial2.Location = new System.Drawing.Point(99, 67);
            this.txtSerial2.MaxLength = 5;
            this.txtSerial2.Name = "txtSerial2";
            this.txtSerial2.Required = false;
            this.txtSerial2.Size = new System.Drawing.Size(60, 22);
            this.txtSerial2.TabIndex = 1;
            this.txtSerial2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
            this.txtSerial2.TextChanged += new System.EventHandler(this.SerialTextChanged);
            // 
            // txtSerial4
            // 
            this.txtSerial4.DefaultErrorMessage = "";
            this.txtSerial4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial4.IsValid = true;
            this.txtSerial4.Location = new System.Drawing.Point(243, 67);
            this.txtSerial4.MaxLength = 5;
            this.txtSerial4.Name = "txtSerial4";
            this.txtSerial4.Required = false;
            this.txtSerial4.Size = new System.Drawing.Size(60, 22);
            this.txtSerial4.TabIndex = 3;
            this.txtSerial4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
            this.txtSerial4.TextChanged += new System.EventHandler(this.SerialTextChanged);
            // 
            // txtSerial3
            // 
            this.txtSerial3.DefaultErrorMessage = "";
            this.txtSerial3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial3.IsValid = true;
            this.txtSerial3.Location = new System.Drawing.Point(171, 67);
            this.txtSerial3.MaxLength = 5;
            this.txtSerial3.Name = "txtSerial3";
            this.txtSerial3.Required = false;
            this.txtSerial3.Size = new System.Drawing.Size(60, 22);
            this.txtSerial3.TabIndex = 2;
            this.txtSerial3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
            this.txtSerial3.TextChanged += new System.EventHandler(this.SerialTextChanged);
            // 
            // txtSerial1
            // 
            this.txtSerial1.DefaultErrorMessage = "";
            this.txtSerial1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial1.IsValid = true;
            this.txtSerial1.Location = new System.Drawing.Point(27, 67);
            this.txtSerial1.MaxLength = 5;
            this.txtSerial1.Name = "txtSerial1";
            this.txtSerial1.Required = false;
            this.txtSerial1.Size = new System.Drawing.Size(60, 22);
            this.txtSerial1.TabIndex = 0;
            this.txtSerial1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SerialKeyUp);
            this.txtSerial1.TextChanged += new System.EventHandler(this.SerialTextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(53, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnullo
            // 
            this.btnAnullo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAnullo.Location = new System.Drawing.Point(191, 120);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(88, 23);
            this.btnAnullo.TabIndex = 9;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // Rregjistrimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 167);
            this.Controls.Add(this.btnAnullo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSerial2);
            this.Controls.Add(this.txtSerial4);
            this.Controls.Add(this.txtSerial3);
            this.Controls.Add(this.txtSerial1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rregjistrimi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rregjistrimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private VisionInfoSolutionLibrary.TextBox txtSerial2;
        private VisionInfoSolutionLibrary.TextBox txtSerial4;
        private VisionInfoSolutionLibrary.TextBox txtSerial3;
        private VisionInfoSolutionLibrary.TextBox txtSerial1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnullo;
    }
}