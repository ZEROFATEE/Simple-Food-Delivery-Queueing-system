namespace QueueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ADD = new Button();
            REMOVE = new Button();
            ORLIST = new ListBox();
            Input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ADD
            // 
            ADD.Location = new Point(38, 405);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 0;
            ADD.Text = "Add";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // REMOVE
            // 
            REMOVE.Location = new Point(157, 405);
            REMOVE.Name = "REMOVE";
            REMOVE.Size = new Size(75, 23);
            REMOVE.TabIndex = 1;
            REMOVE.Text = "Remove";
            REMOVE.UseVisualStyleBackColor = true;
            REMOVE.Click += REMOVE_Click;
            // 
            // ORLIST
            // 
            ORLIST.FormattingEnabled = true;
            ORLIST.ItemHeight = 15;
            ORLIST.Location = new Point(38, 165);
            ORLIST.Name = "ORLIST";
            ORLIST.Size = new Size(194, 214);
            ORLIST.TabIndex = 2;
            // 
            // Input
            // 
            Input.Location = new Point(38, 111);
            Input.Name = "Input";
            Input.Size = new Size(194, 23);
            Input.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 147);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Order:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 93);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter order:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 47);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(127, 11);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 8;
            label4.Text = "FOOD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 37);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 9;
            label3.Text = "DELIVERY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Input);
            Controls.Add(ORLIST);
            Controls.Add(REMOVE);
            Controls.Add(ADD);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ADD;
        private Button REMOVE;
        private ListBox ORLIST;
        private TextBox Input;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
    }
}
