namespace Sorter2
{
    partial class GUI
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
            this.Sortbtn = new System.Windows.Forms.Button();
            this.lengthlbl = new System.Windows.Forms.Label();
            this.Lengthtxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxSorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sortbtn
            // 
            this.Sortbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortbtn.Location = new System.Drawing.Point(15, 184);
            this.Sortbtn.Name = "Sortbtn";
            this.Sortbtn.Size = new System.Drawing.Size(151, 63);
            this.Sortbtn.TabIndex = 4;
            this.Sortbtn.Text = "Sort";
            this.Sortbtn.UseVisualStyleBackColor = true;
            this.Sortbtn.Click += new System.EventHandler(this.Sortbtn_Click);
            // 
            // lengthlbl
            // 
            this.lengthlbl.AutoSize = true;
            this.lengthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthlbl.Location = new System.Drawing.Point(34, 123);
            this.lengthlbl.Name = "lengthlbl";
            this.lengthlbl.Size = new System.Drawing.Size(115, 16);
            this.lengthlbl.TabIndex = 5;
            this.lengthlbl.Text = "Length of array:";
            // 
            // Lengthtxt
            // 
            this.Lengthtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lengthtxt.Location = new System.Drawing.Point(15, 142);
            this.Lengthtxt.Name = "Lengthtxt";
            this.Lengthtxt.Size = new System.Drawing.Size(151, 21);
            this.Lengthtxt.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(100, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 21);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // CBoxSorts
            // 
            this.CBoxSorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxSorts.FormattingEnabled = true;
            this.CBoxSorts.Location = new System.Drawing.Point(14, 22);
            this.CBoxSorts.Name = "CBoxSorts";
            this.CBoxSorts.Size = new System.Drawing.Size(151, 24);
            this.CBoxSorts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Integer interval";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxSorts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lengthtxt);
            this.Controls.Add(this.lengthlbl);
            this.Controls.Add(this.Sortbtn);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sortbtn;
        private System.Windows.Forms.Label lengthlbl;
        private System.Windows.Forms.TextBox Lengthtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxSorts;
        private System.Windows.Forms.Label label2;
    }
}

