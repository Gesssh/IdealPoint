
namespace IdealPoint
{
    partial class ManeForm
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
            this.label_Contorls = new System.Windows.Forms.Label();
            this.label_States = new System.Windows.Forms.Label();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_OpenMatrix = new System.Windows.Forms.Button();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.panel_States = new System.Windows.Forms.Panel();
            this.numeric_Controls = new System.Windows.Forms.NumericUpDown();
            this.numeric_States = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Controls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_States)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Contorls
            // 
            this.label_Contorls.AutoSize = true;
            this.label_Contorls.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Contorls.Location = new System.Drawing.Point(12, 9);
            this.label_Contorls.Name = "label_Contorls";
            this.label_Contorls.Size = new System.Drawing.Size(151, 15);
            this.label_Contorls.TabIndex = 1;
            this.label_Contorls.Text = "Количество альтернатив";
            // 
            // label_States
            // 
            this.label_States.AutoSize = true;
            this.label_States.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_States.Location = new System.Drawing.Point(12, 38);
            this.label_States.Name = "label_States";
            this.label_States.Size = new System.Drawing.Size(142, 15);
            this.label_States.TabIndex = 3;
            this.label_States.Text = "Количество критериев";
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(296, 12);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(116, 48);
            this.button_Apply.TabIndex = 6;
            this.button_Apply.Text = "Добавить поля";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_OpenMatrix
            // 
            this.button_OpenMatrix.Location = new System.Drawing.Point(430, 12);
            this.button_OpenMatrix.Name = "button_OpenMatrix";
            this.button_OpenMatrix.Size = new System.Drawing.Size(116, 48);
            this.button_OpenMatrix.TabIndex = 7;
            this.button_OpenMatrix.Text = "Заполнить таблицу";
            this.button_OpenMatrix.UseVisualStyleBackColor = true;
            this.button_OpenMatrix.Click += new System.EventHandler(this.button_OpenMatrix_Click);
            // 
            // panel_Controls
            // 
            this.panel_Controls.AutoScroll = true;
            this.panel_Controls.Location = new System.Drawing.Point(12, 114);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(319, 212);
            this.panel_Controls.TabIndex = 10;
            // 
            // panel_States
            // 
            this.panel_States.AutoScroll = true;
            this.panel_States.Location = new System.Drawing.Point(469, 114);
            this.panel_States.Name = "panel_States";
            this.panel_States.Size = new System.Drawing.Size(361, 212);
            this.panel_States.TabIndex = 11;
            // 
            // numeric_Controls
            // 
            this.numeric_Controls.Location = new System.Drawing.Point(201, 7);
            this.numeric_Controls.Name = "numeric_Controls";
            this.numeric_Controls.Size = new System.Drawing.Size(53, 23);
            this.numeric_Controls.TabIndex = 12;
            // 
            // numeric_States
            // 
            this.numeric_States.Location = new System.Drawing.Point(201, 36);
            this.numeric_States.Name = "numeric_States";
            this.numeric_States.Size = new System.Drawing.Size(53, 23);
            this.numeric_States.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(361, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 212);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numeric_States);
            this.Controls.Add(this.numeric_Controls);
            this.Controls.Add(this.panel_States);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.button_OpenMatrix);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.label_States);
            this.Controls.Add(this.label_Contorls);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Метод идеальной точки";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Controls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_States)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Contorls;
        private System.Windows.Forms.Label label_States;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_OpenMatrix;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Panel panel_States;
        private System.Windows.Forms.NumericUpDown numeric_Controls;
        private System.Windows.Forms.NumericUpDown numeric_States;
        private System.Windows.Forms.Panel panel1;
    }
}

