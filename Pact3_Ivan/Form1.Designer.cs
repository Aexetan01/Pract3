namespace Pact3_Ivan
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetResult1 = new System.Windows.Forms.Button();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetResult2 = new System.Windows.Forms.Button();
            this.nudB2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudA2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(332, 408);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetResult1);
            this.tabPage1.Controls.Add(this.nudC);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nudB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudA);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(324, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetResult1
            // 
            this.btnGetResult1.Location = new System.Drawing.Point(88, 333);
            this.btnGetResult1.Name = "btnGetResult1";
            this.btnGetResult1.Size = new System.Drawing.Size(136, 32);
            this.btnGetResult1.TabIndex = 2;
            this.btnGetResult1.Text = "Розрахувати";
            this.btnGetResult1.UseVisualStyleBackColor = true;
            this.btnGetResult1.Click += new System.EventHandler(this.btnGetResult1_Click);
            // 
            // nudC
            // 
            this.nudC.Location = new System.Drawing.Point(141, 206);
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(155, 29);
            this.nudC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "C:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(141, 158);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(155, 29);
            this.nudB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "B:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(141, 111);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(155, 29);
            this.nudA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nudB2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nudA2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnGetResult2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(324, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetResult2
            // 
            this.btnGetResult2.Location = new System.Drawing.Point(90, 333);
            this.btnGetResult2.Name = "btnGetResult2";
            this.btnGetResult2.Size = new System.Drawing.Size(136, 32);
            this.btnGetResult2.TabIndex = 7;
            this.btnGetResult2.Text = "Розрахувати";
            this.btnGetResult2.UseVisualStyleBackColor = true;
            this.btnGetResult2.Click += new System.EventHandler(this.btnGetResult2_Click);
            // 
            // nudB2
            // 
            this.nudB2.Location = new System.Drawing.Point(141, 165);
            this.nudB2.Name = "nudB2";
            this.nudB2.Size = new System.Drawing.Size(155, 29);
            this.nudB2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "B:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudA2
            // 
            this.nudA2.Location = new System.Drawing.Point(141, 118);
            this.nudA2.Name = "nudA2";
            this.nudA2.Size = new System.Drawing.Size(155, 29);
            this.nudA2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "A:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 421);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGetResult1;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nudB2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudA2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetResult2;
    }
}

