namespace CardSelector
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
            cmbSuits = new ComboBox();
            cmbValues = new ComboBox();
            lblSuit = new Label();
            lblValue = new Label();
            pictureBox1 = new PictureBox();
            btnDraw = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbSuits
            // 
            cmbSuits.FormattingEnabled = true;
            cmbSuits.Location = new Point(53, 29);
            cmbSuits.Name = "cmbSuits";
            cmbSuits.Size = new Size(121, 23);
            cmbSuits.TabIndex = 0;
            cmbSuits.SelectedIndexChanged += cmbSuit_SelectedIndexChanged;
            // 
            // cmbValues
            // 
            cmbValues.FormattingEnabled = true;
            cmbValues.Location = new Point(53, 76);
            cmbValues.Name = "cmbValues";
            cmbValues.Size = new Size(121, 23);
            cmbValues.TabIndex = 1;
            cmbValues.SelectedIndexChanged += cmbValue_SelectedIndexChanged;
            // 
            // lblSuit
            // 
            lblSuit.AutoSize = true;
            lblSuit.Location = new Point(12, 32);
            lblSuit.Name = "lblSuit";
            lblSuit.Size = new Size(27, 15);
            lblSuit.TabIndex = 2;
            lblSuit.Text = "Suit";
            lblSuit.Click += label1_Click;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(12, 79);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(35, 15);
            lblValue.TabIndex = 3;
            lblValue.Text = "Value";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(226, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 96);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(99, 117);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 23);
            btnDraw.TabIndex = 5;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 161);
            Controls.Add(btnDraw);
            Controls.Add(pictureBox1);
            Controls.Add(lblValue);
            Controls.Add(lblSuit);
            Controls.Add(cmbValues);
            Controls.Add(cmbSuits);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSuits;
        private ComboBox cmbValues;
        private Label lblSuit;
        private Label lblValue;
        private PictureBox pictureBox1;
        private Button btnDraw;
    }
}
