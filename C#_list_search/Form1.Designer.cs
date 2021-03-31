
namespace Integer_search
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.Prompt_label_1 = new System.Windows.Forms.Label();
            this.Input_box_arr = new System.Windows.Forms.TextBox();
            this.Output_button = new System.Windows.Forms.Button();
            this.Output_label = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.Prompt_label_2 = new System.Windows.Forms.Label();
            this.Input_box_int = new System.Windows.Forms.TextBox();
            this.Done_button = new System.Windows.Forms.Button();
            this.Sorted_list_text = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(648, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "New_search";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem2.Text = "Options";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "About";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "Exit";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // Prompt_label_1
            // 
            this.Prompt_label_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prompt_label_1.AutoSize = true;
            this.Prompt_label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prompt_label_1.Location = new System.Drawing.Point(23, 61);
            this.Prompt_label_1.Name = "Prompt_label_1";
            this.Prompt_label_1.Size = new System.Drawing.Size(252, 16);
            this.Prompt_label_1.TabIndex = 1;
            this.Prompt_label_1.Text = "Enter 10 integers separated by a space> ";
            this.Prompt_label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input_box_arr
            // 
            this.Input_box_arr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_box_arr.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Input_box_arr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_box_arr.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Input_box_arr.Location = new System.Drawing.Point(344, 57);
            this.Input_box_arr.Name = "Input_box_arr";
            this.Input_box_arr.Size = new System.Drawing.Size(281, 22);
            this.Input_box_arr.TabIndex = 2;
            this.Input_box_arr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Input_box_arr.TextChanged += new System.EventHandler(this.Input_box_arr_TextChanged);
            // 
            // Output_button
            // 
            this.Output_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Output_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Output_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Output_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output_button.Location = new System.Drawing.Point(189, 250);
            this.Output_button.Name = "Output_button";
            this.Output_button.Size = new System.Drawing.Size(273, 27);
            this.Output_button.TabIndex = 3;
            this.Output_button.Text = "Show the output";
            this.Output_button.UseVisualStyleBackColor = false;
            this.Output_button.Visible = false;
            this.Output_button.Click += new System.EventHandler(this.Output_button_Click);
            // 
            // Output_label
            // 
            this.Output_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Output_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Output_label.Location = new System.Drawing.Point(189, 360);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(273, 76);
            this.Output_label.TabIndex = 4;
            this.Output_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_label.Visible = false;
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(186, 331);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(221, 16);
            this.Label.TabIndex = 5;
            this.Label.Text = "The integer was located at position: ";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label.Visible = false;
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // Prompt_label_2
            // 
            this.Prompt_label_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prompt_label_2.AutoSize = true;
            this.Prompt_label_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Prompt_label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prompt_label_2.Location = new System.Drawing.Point(23, 174);
            this.Prompt_label_2.Name = "Prompt_label_2";
            this.Prompt_label_2.Size = new System.Drawing.Size(187, 16);
            this.Prompt_label_2.TabIndex = 6;
            this.Prompt_label_2.Text = "Integer you are searching for> ";
            this.Prompt_label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Prompt_label_2.Visible = false;
            // 
            // Input_box_int
            // 
            this.Input_box_int.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_box_int.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Input_box_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_box_int.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Input_box_int.Location = new System.Drawing.Point(436, 171);
            this.Input_box_int.Name = "Input_box_int";
            this.Input_box_int.Size = new System.Drawing.Size(189, 22);
            this.Input_box_int.TabIndex = 7;
            this.Input_box_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Input_box_int.Visible = false;
            // 
            // Done_button
            // 
            this.Done_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Done_button.BackColor = System.Drawing.Color.LightBlue;
            this.Done_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done_button.Location = new System.Drawing.Point(254, 128);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(138, 33);
            this.Done_button.TabIndex = 8;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = false;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // Sorted_list_text
            // 
            this.Sorted_list_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sorted_list_text.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sorted_list_text.Enabled = false;
            this.Sorted_list_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sorted_list_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sorted_list_text.Location = new System.Drawing.Point(189, 295);
            this.Sorted_list_text.Name = "Sorted_list_text";
            this.Sorted_list_text.Size = new System.Drawing.Size(273, 22);
            this.Sorted_list_text.TabIndex = 9;
            this.Sorted_list_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sorted_list_text.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(648, 469);
            this.Controls.Add(this.Sorted_list_text);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.Input_box_int);
            this.Controls.Add(this.Prompt_label_2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.Output_button);
            this.Controls.Add(this.Input_box_arr);
            this.Controls.Add(this.Prompt_label_1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Binary_search_window";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label Prompt_label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Label Prompt_label_1;
        private System.Windows.Forms.TextBox Input_box_arr;
        private System.Windows.Forms.Button Output_button;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Prompt_label_2;
        private System.Windows.Forms.TextBox Input_box_int;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.TextBox Sorted_list_text;
    }
}

