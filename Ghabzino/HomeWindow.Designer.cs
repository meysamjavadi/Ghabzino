namespace Ghabzino
{
    partial class HomeWindow
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
            btnStart = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtPrice = new TextBox();
            txtCriteria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtToken = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(168, 251);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start...";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(73, 22);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(267, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtCriteria
            // 
            txtCriteria.Location = new Point(73, 51);
            txtCriteria.Name = "txtCriteria";
            txtCriteria.Size = new Size(267, 23);
            txtCriteria.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Price <";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 59);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Criteria";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtToken);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCriteria);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 225);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conditions";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(73, 79);
            txtToken.Multiline = true;
            txtToken.Name = "txtToken";
            txtToken.ScrollBars = ScrollBars.Vertical;
            txtToken.Size = new Size(267, 124);
            txtToken.TabIndex = 6;
            txtToken.Text = "Bearer eyJ0..................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 79);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Token";
            // 
            // HomeWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 282);
            Controls.Add(groupBox1);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HomeWindow";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtPrice;
        private TextBox txtCriteria;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtToken;
    }
}