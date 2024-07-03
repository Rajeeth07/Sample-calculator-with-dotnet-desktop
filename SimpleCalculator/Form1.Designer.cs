namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lab = new Label();
            txtNum1 = new TextBox();
            btnDiv = new Button();
            label2 = new Label();
            btnSub = new Button();
            txtNum2 = new TextBox();
            btnMulti = new Button();
            btnSum = new Button();
            label3 = new Label();
            txtOut = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lab
            // 
            lab.BackColor = SystemColors.ActiveCaption;
            lab.Dock = DockStyle.Top;
            lab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab.Location = new Point(0, 0);
            lab.Name = "lab";
            lab.Size = new Size(352, 39);
            lab.TabIndex = 0;
            lab.Text = "Number Calculator";
            lab.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 12F);
            txtNum1.Location = new Point(167, 48);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 39);
            txtNum1.TabIndex = 1;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Arial Black", 16F, FontStyle.Bold);
            btnDiv.Location = new Point(265, 200);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(53, 52);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "%";
            btnDiv.TextAlign = ContentAlignment.TopCenter;
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(59, 106);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 0;
            label2.Text = "Number 2";
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Arial Black", 16F, FontStyle.Bold);
            btnSub.Location = new Point(212, 200);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(53, 52);
            btnSub.TabIndex = 6;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 12F);
            txtNum2.Location = new Point(167, 95);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 39);
            txtNum2.TabIndex = 2;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Arial Black", 16F, FontStyle.Bold);
            btnMulti.Location = new Point(159, 200);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(53, 52);
            btnMulti.TabIndex = 5;
            btnMulti.Text = "x";
            btnMulti.TextAlign = ContentAlignment.TopCenter;
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnSum
            // 
            btnSum.Font = new Font("Arial Black", 16F, FontStyle.Bold);
            btnSum.Location = new Point(106, 200);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(53, 52);
            btnSum.TabIndex = 4;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(59, 151);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 0;
            label3.Text = "Result";
            // 
            // txtOut
            // 
            txtOut.Font = new Font("Segoe UI", 12F);
            txtOut.Location = new Point(167, 140);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(150, 39);
            txtOut.TabIndex = 3;
            txtOut.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(2, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 5);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(59, 59);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            //labe
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 262);
            Controls.Add(groupBox1);
            Controls.Add(btnSum);
            Controls.Add(btnMulti);
            Controls.Add(btnSub);
            Controls.Add(btnDiv);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtOut);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(lab);
            Name = "Form1";
            Text = "Number Calc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab;
        private TextBox txtNum1;
        private Button btnDiv;
        private Label label2;
        private Button btnSub;
        private TextBox txtNum2;
        private Button btnMulti;
        private Button btnSum;
        private Label label3;
        private TextBox txtOut;
        private GroupBox groupBox1;
        private Label label1;
    }
}
