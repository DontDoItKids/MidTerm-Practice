namespace MidTerm_Practice
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
            this.numUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.rBtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rBtn6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLine = new System.Windows.Forms.PictureBox();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSeizure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown1
            // 
            this.numUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numUpDown1.Name = "numUpDown1";
            this.numUpDown1.Size = new System.Drawing.Size(186, 23);
            this.numUpDown1.TabIndex = 0;
            this.numUpDown1.ValueChanged += new System.EventHandler(this.numUpDown1_ValueChanged);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(6, 22);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(70, 19);
            this.rbtn1.TabIndex = 1;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Colour 1";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rBtn1_CheckedChanged);
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(106, 22);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(70, 19);
            this.rBtn2.TabIndex = 2;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "Colour 2";
            this.rBtn2.UseVisualStyleBackColor = true;
            this.rBtn2.CheckedChanged += new System.EventHandler(this.rBtn2_CheckedChanged);
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(6, 47);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(70, 19);
            this.rBtn3.TabIndex = 3;
            this.rBtn3.TabStop = true;
            this.rBtn3.Text = "Colour 3";
            this.rBtn3.UseVisualStyleBackColor = true;
            this.rBtn3.CheckedChanged += new System.EventHandler(this.rBtn3_CheckedChanged);
            // 
            // rBtn4
            // 
            this.rBtn4.AutoSize = true;
            this.rBtn4.Location = new System.Drawing.Point(106, 47);
            this.rBtn4.Name = "rBtn4";
            this.rBtn4.Size = new System.Drawing.Size(70, 19);
            this.rBtn4.TabIndex = 4;
            this.rBtn4.TabStop = true;
            this.rBtn4.Text = "Colour 4";
            this.rBtn4.UseVisualStyleBackColor = true;
            this.rBtn4.CheckedChanged += new System.EventHandler(this.rBtn4_CheckedChanged);
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Location = new System.Drawing.Point(6, 72);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(70, 19);
            this.rbtn5.TabIndex = 5;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "Colour 5";
            this.rbtn5.UseVisualStyleBackColor = true;
            this.rbtn5.CheckedChanged += new System.EventHandler(this.rbtn5_CheckedChanged);
            // 
            // rBtn6
            // 
            this.rBtn6.AutoSize = true;
            this.rBtn6.Location = new System.Drawing.Point(106, 72);
            this.rBtn6.Name = "rBtn6";
            this.rBtn6.Size = new System.Drawing.Size(70, 19);
            this.rBtn6.TabIndex = 6;
            this.rBtn6.TabStop = true;
            this.rBtn6.Text = "Colour 6";
            this.rBtn6.UseVisualStyleBackColor = true;
            this.rBtn6.CheckedChanged += new System.EventHandler(this.rBtn6_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn1);
            this.groupBox1.Controls.Add(this.rBtn6);
            this.groupBox1.Controls.Add(this.rBtn2);
            this.groupBox1.Controls.Add(this.rbtn5);
            this.groupBox1.Controls.Add(this.rBtn3);
            this.groupBox1.Controls.Add(this.rBtn4);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Back Colour";
            // 
            // picLine
            // 
            this.picLine.Image = global::MidTerm_Practice.Properties.Resources.a_line;
            this.picLine.Location = new System.Drawing.Point(12, 162);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(106, 58);
            this.picLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLine.TabIndex = 8;
            this.picLine.TabStop = false;
            // 
            // btnClickMe
            // 
            this.btnClickMe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClickMe.Location = new System.Drawing.Point(12, 226);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(106, 29);
            this.btnClickMe.TabIndex = 9;
            this.btnClickMe.Text = "Click Me!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(12, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 29);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSeizure
            // 
            this.btnSeizure.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeizure.Location = new System.Drawing.Point(682, 409);
            this.btnSeizure.Name = "btnSeizure";
            this.btnSeizure.Size = new System.Drawing.Size(106, 29);
            this.btnSeizure.TabIndex = 11;
            this.btnSeizure.Text = "Party";
            this.btnSeizure.UseVisualStyleBackColor = true;
            this.btnSeizure.Click += new System.EventHandler(this.btnSeizure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(682, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seizure Warning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeizure);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.picLine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numUpDown1;
        private RadioButton rbtn1;
        private RadioButton rBtn2;
        private RadioButton rBtn3;
        private RadioButton rBtn4;
        private RadioButton rbtn5;
        private RadioButton rBtn6;
        private GroupBox groupBox1;
        private PictureBox picLine;
        private Button btnClickMe;
        private Button btnReset;
        private Button btnSeizure;
        private Label label1;
    }
}