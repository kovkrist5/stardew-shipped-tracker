
namespace stardew
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
            this.listbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.CheckOnClick = true;
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(15, 34);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(186, 199);
            this.listbox.TabIndex = 0;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(15, 248);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(186, 23);
            this.savebutton.TabIndex = 2;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 282);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savebutton;
    }
}

