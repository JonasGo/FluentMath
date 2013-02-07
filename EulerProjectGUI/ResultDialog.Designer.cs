namespace EulerProjectGUI
{
    partial class ResultDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMethodCall = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxMethodCall = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.labelNr = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCalculate);
            this.panel1.Controls.Add(this.labelNr);
            this.panel1.Controls.Add(this.textBoxNr);
            this.panel1.Controls.Add(this.labelMethodCall);
            this.panel1.Controls.Add(this.labelDuration);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.textBoxMethodCall);
            this.panel1.Controls.Add(this.textBoxDuration);
            this.panel1.Controls.Add(this.textBoxResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 118);
            this.panel1.TabIndex = 0;
            // 
            // labelMethodCall
            // 
            this.labelMethodCall.AutoSize = true;
            this.labelMethodCall.Location = new System.Drawing.Point(3, 87);
            this.labelMethodCall.Name = "labelMethodCall";
            this.labelMethodCall.Size = new System.Drawing.Size(62, 13);
            this.labelMethodCall.TabIndex = 11;
            this.labelMethodCall.Text = "Method call";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(3, 61);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 10;
            this.labelDuration.Text = "Duration";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(3, 35);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Result";
            // 
            // textBoxMethodCall
            // 
            this.textBoxMethodCall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethodCall.Location = new System.Drawing.Point(71, 84);
            this.textBoxMethodCall.Name = "textBoxMethodCall";
            this.textBoxMethodCall.Size = new System.Drawing.Size(453, 20);
            this.textBoxMethodCall.TabIndex = 8;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDuration.Location = new System.Drawing.Point(71, 58);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(453, 20);
            this.textBoxDuration.TabIndex = 7;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(71, 32);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(453, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(71, 6);
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(64, 20);
            this.textBoxNr.TabIndex = 12;
            // 
            // labelNr
            // 
            this.labelNr.AutoSize = true;
            this.labelNr.Location = new System.Drawing.Point(3, 9);
            this.labelNr.Name = "labelNr";
            this.labelNr.Size = new System.Drawing.Size(59, 13);
            this.labelNr.TabIndex = 13;
            this.labelNr.Text = "Problem Nr";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(141, 4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 118);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Project Euler GUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelNr;
        private System.Windows.Forms.TextBox textBoxNr;
        private System.Windows.Forms.Label labelMethodCall;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxMethodCall;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxResult;


    }
}

