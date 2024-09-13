namespace Project_One
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
            this.SensorAB_lstView = new System.Windows.Forms.ListView();
            this.numericUpDown_Sigma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Mu = new System.Windows.Forms.NumericUpDown();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.labelSigma = new System.Windows.Forms.Label();
            this.labelMu = new System.Windows.Forms.Label();
            this.labelSensorA = new System.Windows.Forms.Label();
            this.labelSensorB = new System.Windows.Forms.Label();
            this.IterSearchBtn = new System.Windows.Forms.Button();
            this.RecurSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BinaryIterSearch_TxtBoxA = new System.Windows.Forms.TextBox();
            this.BinaryRecurSearch_TxtBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTarget_txtBoxA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectionSort_btn = new System.Windows.Forms.Button();
            this.SelectSort_txtBoxA = new System.Windows.Forms.TextBox();
            this.InsertSort_txtBoxA = new System.Windows.Forms.TextBox();
            this.InsertSort_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertSort_txtBoxB = new System.Windows.Forms.TextBox();
            this.InsertSort_btn1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectSort_txtBoxB = new System.Windows.Forms.TextBox();
            this.SelectionSort_btn1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchTarget_txtBoxB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BinaryRecurSearch_TxtBoxB = new System.Windows.Forms.TextBox();
            this.BinaryIterSearch_TxtBoxB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RecurSearchBtn1 = new System.Windows.Forms.Button();
            this.IterSearchBtn1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lstBoxA = new System.Windows.Forms.ListBox();
            this.lstBoxB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // SensorAB_lstView
            // 
            this.SensorAB_lstView.AccessibleName = "";
            this.SensorAB_lstView.HideSelection = false;
            this.SensorAB_lstView.Location = new System.Drawing.Point(12, 95);
            this.SensorAB_lstView.Name = "SensorAB_lstView";
            this.SensorAB_lstView.Size = new System.Drawing.Size(174, 418);
            this.SensorAB_lstView.TabIndex = 2;
            this.SensorAB_lstView.UseCompatibleStateImageBehavior = false;
            // 
            // numericUpDown_Sigma
            // 
            this.numericUpDown_Sigma.Location = new System.Drawing.Point(22, 28);
            this.numericUpDown_Sigma.Name = "numericUpDown_Sigma";
            this.numericUpDown_Sigma.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_Sigma.TabIndex = 3;
            // 
            // numericUpDown_Mu
            // 
            this.numericUpDown_Mu.Location = new System.Drawing.Point(111, 28);
            this.numericUpDown_Mu.Name = "numericUpDown_Mu";
            this.numericUpDown_Mu.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_Mu.TabIndex = 4;
            // 
            // Load_Btn
            // 
            this.Load_Btn.Location = new System.Drawing.Point(30, 66);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(132, 23);
            this.Load_Btn.TabIndex = 5;
            this.Load_Btn.Text = "Load Sensor Data";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // labelSigma
            // 
            this.labelSigma.AutoSize = true;
            this.labelSigma.Location = new System.Drawing.Point(29, 12);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(36, 13);
            this.labelSigma.TabIndex = 6;
            this.labelSigma.Text = "Sigma";
            // 
            // labelMu
            // 
            this.labelMu.AutoSize = true;
            this.labelMu.Location = new System.Drawing.Point(125, 12);
            this.labelMu.Name = "labelMu";
            this.labelMu.Size = new System.Drawing.Size(22, 13);
            this.labelMu.TabIndex = 7;
            this.labelMu.Text = "Mu";
            // 
            // labelSensorA
            // 
            this.labelSensorA.AutoSize = true;
            this.labelSensorA.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensorA.Location = new System.Drawing.Point(213, 12);
            this.labelSensorA.Name = "labelSensorA";
            this.labelSensorA.Size = new System.Drawing.Size(121, 34);
            this.labelSensorA.TabIndex = 8;
            this.labelSensorA.Text = "Sensor A";
            this.labelSensorA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSensorB
            // 
            this.labelSensorB.AutoSize = true;
            this.labelSensorB.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensorB.Location = new System.Drawing.Point(515, 12);
            this.labelSensorB.Name = "labelSensorB";
            this.labelSensorB.Size = new System.Drawing.Size(122, 34);
            this.labelSensorB.TabIndex = 9;
            this.labelSensorB.Text = "Sensor B";
            this.labelSensorB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IterSearchBtn
            // 
            this.IterSearchBtn.Location = new System.Drawing.Point(223, 71);
            this.IterSearchBtn.Name = "IterSearchBtn";
            this.IterSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.IterSearchBtn.TabIndex = 10;
            this.IterSearchBtn.Text = "Search";
            this.IterSearchBtn.UseVisualStyleBackColor = true;
            // 
            // RecurSearchBtn
            // 
            this.RecurSearchBtn.Location = new System.Drawing.Point(223, 163);
            this.RecurSearchBtn.Name = "RecurSearchBtn";
            this.RecurSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.RecurSearchBtn.TabIndex = 11;
            this.RecurSearchBtn.Text = "Search";
            this.RecurSearchBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Binary Search Iterative";
            // 
            // BinaryIterSearch_TxtBoxA
            // 
            this.BinaryIterSearch_TxtBoxA.Location = new System.Drawing.Point(223, 100);
            this.BinaryIterSearch_TxtBoxA.Name = "BinaryIterSearch_TxtBoxA";
            this.BinaryIterSearch_TxtBoxA.Size = new System.Drawing.Size(100, 20);
            this.BinaryIterSearch_TxtBoxA.TabIndex = 13;
            // 
            // BinaryRecurSearch_TxtBoxA
            // 
            this.BinaryRecurSearch_TxtBoxA.Location = new System.Drawing.Point(223, 193);
            this.BinaryRecurSearch_TxtBoxA.Name = "BinaryRecurSearch_TxtBoxA";
            this.BinaryRecurSearch_TxtBoxA.Size = new System.Drawing.Size(100, 20);
            this.BinaryRecurSearch_TxtBoxA.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Binary Search Recursive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(223, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search Target";
            // 
            // SearchTarget_txtBoxA
            // 
            this.SearchTarget_txtBoxA.Location = new System.Drawing.Point(304, 240);
            this.SearchTarget_txtBoxA.Name = "SearchTarget_txtBoxA";
            this.SearchTarget_txtBoxA.Size = new System.Drawing.Size(30, 20);
            this.SearchTarget_txtBoxA.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Selection Sort";
            // 
            // SelectionSort_btn
            // 
            this.SelectionSort_btn.Location = new System.Drawing.Point(223, 310);
            this.SelectionSort_btn.Name = "SelectionSort_btn";
            this.SelectionSort_btn.Size = new System.Drawing.Size(75, 23);
            this.SelectionSort_btn.TabIndex = 19;
            this.SelectionSort_btn.Text = "Sort";
            this.SelectionSort_btn.UseVisualStyleBackColor = true;
            // 
            // SelectSort_txtBoxA
            // 
            this.SelectSort_txtBoxA.Location = new System.Drawing.Point(223, 339);
            this.SelectSort_txtBoxA.Name = "SelectSort_txtBoxA";
            this.SelectSort_txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.SelectSort_txtBoxA.TabIndex = 20;
            // 
            // InsertSort_txtBoxA
            // 
            this.InsertSort_txtBoxA.Location = new System.Drawing.Point(223, 432);
            this.InsertSort_txtBoxA.Name = "InsertSort_txtBoxA";
            this.InsertSort_txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.InsertSort_txtBoxA.TabIndex = 23;
            // 
            // InsertSort_btn
            // 
            this.InsertSort_btn.Location = new System.Drawing.Point(223, 403);
            this.InsertSort_btn.Name = "InsertSort_btn";
            this.InsertSort_btn.Size = new System.Drawing.Size(75, 23);
            this.InsertSort_btn.TabIndex = 22;
            this.InsertSort_btn.Text = "Sort";
            this.InsertSort_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Insertion Sort";
            // 
            // InsertSort_txtBoxB
            // 
            this.InsertSort_txtBoxB.Location = new System.Drawing.Point(518, 436);
            this.InsertSort_txtBoxB.Name = "InsertSort_txtBoxB";
            this.InsertSort_txtBoxB.Size = new System.Drawing.Size(100, 20);
            this.InsertSort_txtBoxB.TabIndex = 37;
            // 
            // InsertSort_btn1
            // 
            this.InsertSort_btn1.Location = new System.Drawing.Point(518, 407);
            this.InsertSort_btn1.Name = "InsertSort_btn1";
            this.InsertSort_btn1.Size = new System.Drawing.Size(75, 23);
            this.InsertSort_btn1.TabIndex = 36;
            this.InsertSort_btn1.Text = "Sort";
            this.InsertSort_btn1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Insertion Sort";
            // 
            // SelectSort_txtBoxB
            // 
            this.SelectSort_txtBoxB.Location = new System.Drawing.Point(518, 343);
            this.SelectSort_txtBoxB.Name = "SelectSort_txtBoxB";
            this.SelectSort_txtBoxB.Size = new System.Drawing.Size(100, 20);
            this.SelectSort_txtBoxB.TabIndex = 34;
            // 
            // SelectionSort_btn1
            // 
            this.SelectionSort_btn1.Location = new System.Drawing.Point(518, 314);
            this.SelectionSort_btn1.Name = "SelectionSort_btn1";
            this.SelectionSort_btn1.Size = new System.Drawing.Size(75, 23);
            this.SelectionSort_btn1.TabIndex = 33;
            this.SelectionSort_btn1.Text = "Sort";
            this.SelectionSort_btn1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Selection Sort";
            // 
            // SearchTarget_txtBoxB
            // 
            this.SearchTarget_txtBoxB.Location = new System.Drawing.Point(599, 243);
            this.SearchTarget_txtBoxB.Name = "SearchTarget_txtBoxB";
            this.SearchTarget_txtBoxB.Size = new System.Drawing.Size(30, 20);
            this.SearchTarget_txtBoxB.TabIndex = 31;
            this.SearchTarget_txtBoxB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(518, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Search Target";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Binary Search Recursive";
            // 
            // BinaryRecurSearch_TxtBoxB
            // 
            this.BinaryRecurSearch_TxtBoxB.Location = new System.Drawing.Point(518, 197);
            this.BinaryRecurSearch_TxtBoxB.Name = "BinaryRecurSearch_TxtBoxB";
            this.BinaryRecurSearch_TxtBoxB.Size = new System.Drawing.Size(100, 20);
            this.BinaryRecurSearch_TxtBoxB.TabIndex = 28;
            // 
            // BinaryIterSearch_TxtBoxB
            // 
            this.BinaryIterSearch_TxtBoxB.Location = new System.Drawing.Point(518, 104);
            this.BinaryIterSearch_TxtBoxB.Name = "BinaryIterSearch_TxtBoxB";
            this.BinaryIterSearch_TxtBoxB.Size = new System.Drawing.Size(100, 20);
            this.BinaryIterSearch_TxtBoxB.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Binary Search Iterative";
            // 
            // RecurSearchBtn1
            // 
            this.RecurSearchBtn1.Location = new System.Drawing.Point(518, 167);
            this.RecurSearchBtn1.Name = "RecurSearchBtn1";
            this.RecurSearchBtn1.Size = new System.Drawing.Size(75, 23);
            this.RecurSearchBtn1.TabIndex = 25;
            this.RecurSearchBtn1.Text = "Search";
            this.RecurSearchBtn1.UseVisualStyleBackColor = true;
            // 
            // IterSearchBtn1
            // 
            this.IterSearchBtn1.Location = new System.Drawing.Point(518, 75);
            this.IterSearchBtn1.Name = "IterSearchBtn1";
            this.IterSearchBtn1.Size = new System.Drawing.Size(75, 23);
            this.IterSearchBtn1.TabIndex = 24;
            this.IterSearchBtn1.Text = "Search";
            this.IterSearchBtn1.UseVisualStyleBackColor = true;
            // 
            // lstBoxA
            // 
            this.lstBoxA.FormattingEnabled = true;
            this.lstBoxA.Location = new System.Drawing.Point(353, 28);
            this.lstBoxA.Name = "lstBoxA";
            this.lstBoxA.Size = new System.Drawing.Size(129, 485);
            this.lstBoxA.TabIndex = 38;
            // 
            // lstBoxB
            // 
            this.lstBoxB.FormattingEnabled = true;
            this.lstBoxB.Location = new System.Drawing.Point(643, 28);
            this.lstBoxB.Name = "lstBoxB";
            this.lstBoxB.Size = new System.Drawing.Size(129, 485);
            this.lstBoxB.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.lstBoxB);
            this.Controls.Add(this.lstBoxA);
            this.Controls.Add(this.InsertSort_txtBoxB);
            this.Controls.Add(this.InsertSort_btn1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SelectSort_txtBoxB);
            this.Controls.Add(this.SelectionSort_btn1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchTarget_txtBoxB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BinaryRecurSearch_TxtBoxB);
            this.Controls.Add(this.BinaryIterSearch_TxtBoxB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RecurSearchBtn1);
            this.Controls.Add(this.IterSearchBtn1);
            this.Controls.Add(this.InsertSort_txtBoxA);
            this.Controls.Add(this.InsertSort_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectSort_txtBoxA);
            this.Controls.Add(this.SelectionSort_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchTarget_txtBoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BinaryRecurSearch_TxtBoxA);
            this.Controls.Add(this.BinaryIterSearch_TxtBoxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecurSearchBtn);
            this.Controls.Add(this.IterSearchBtn);
            this.Controls.Add(this.labelSensorB);
            this.Controls.Add(this.labelSensorA);
            this.Controls.Add(this.labelMu);
            this.Controls.Add(this.labelSigma);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.numericUpDown_Mu);
            this.Controls.Add(this.numericUpDown_Sigma);
            this.Controls.Add(this.SensorAB_lstView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView SensorAB_lstView;
        private System.Windows.Forms.NumericUpDown numericUpDown_Sigma;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mu;
        private System.Windows.Forms.Button Load_Btn;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.Label labelMu;
        private System.Windows.Forms.Label labelSensorA;
        private System.Windows.Forms.Label labelSensorB;
        private System.Windows.Forms.Button IterSearchBtn;
        private System.Windows.Forms.Button RecurSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BinaryIterSearch_TxtBoxA;
        private System.Windows.Forms.TextBox BinaryRecurSearch_TxtBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTarget_txtBoxA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectionSort_btn;
        private System.Windows.Forms.TextBox SelectSort_txtBoxA;
        private System.Windows.Forms.TextBox InsertSort_txtBoxA;
        private System.Windows.Forms.Button InsertSort_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InsertSort_txtBoxB;
        private System.Windows.Forms.Button InsertSort_btn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SelectSort_txtBoxB;
        private System.Windows.Forms.Button SelectionSort_btn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchTarget_txtBoxB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BinaryRecurSearch_TxtBoxB;
        private System.Windows.Forms.TextBox BinaryIterSearch_TxtBoxB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RecurSearchBtn1;
        private System.Windows.Forms.Button IterSearchBtn1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ListBox lstBoxA;
        private System.Windows.Forms.ListBox lstBoxB;
    }
}

