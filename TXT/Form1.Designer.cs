
namespace TXT
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
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(12, 43);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(599, 22);
            this.textBox_Search.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(617, 43);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(171, 33);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(617, 391);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(171, 47);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Start;
    }
}

