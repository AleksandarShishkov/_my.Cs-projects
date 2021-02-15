
namespace Calculator
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.ResultOupput = new System.Windows.Forms.Label();
            this.ButtonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ResultButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SubstrButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DELButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.ButtonsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserInput.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserInput.Location = new System.Drawing.Point(12, 12);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(309, 27);
            this.UserInput.TabIndex = 0;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // ResultOupput
            // 
            this.ResultOupput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultOupput.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultOupput.Location = new System.Drawing.Point(15, 54);
            this.ResultOupput.Name = "ResultOupput";
            this.ResultOupput.Size = new System.Drawing.Size(309, 35);
            this.ResultOupput.TabIndex = 1;
            this.ResultOupput.Text = "Enter an equation and press <Enter> or \'=\'";
            // 
            // ButtonsTable
            // 
            this.ButtonsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTable.ColumnCount = 4;
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTable.Controls.Add(this.ResultButton, 3, 4);
            this.ButtonsTable.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsTable.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonsTable.Controls.Add(this.AddButton, 3, 3);
            this.ButtonsTable.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsTable.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsTable.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsTable.Controls.Add(this.SubstrButton, 3, 2);
            this.ButtonsTable.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsTable.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsTable.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsTable.Controls.Add(this.MultiButton, 3, 1);
            this.ButtonsTable.Controls.Add(this.NineButton, 2, 1);
            this.ButtonsTable.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsTable.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsTable.Controls.Add(this.DELButton, 2, 0);
            this.ButtonsTable.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsTable.Controls.Add(this.PlusMinusButton, 0, 4);
            this.ButtonsTable.Controls.Add(this.DivisionButton, 3, 0);
            this.ButtonsTable.Controls.Add(this.PercentButton, 1, 0);
            this.ButtonsTable.Location = new System.Drawing.Point(15, 88);
            this.ButtonsTable.Name = "ButtonsTable";
            this.ButtonsTable.RowCount = 5;
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsTable.Size = new System.Drawing.Size(306, 362);
            this.ButtonsTable.TabIndex = 2;
            this.ButtonsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonsTable_Paint);
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.SystemColors.Control;
            this.ResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(231, 291);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(72, 68);
            this.ResultButton.TabIndex = 19;
            this.ResultButton.Text = "=";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(155, 291);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(70, 68);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(79, 291);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(70, 68);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(231, 219);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(72, 66);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(155, 219);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(70, 66);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(79, 219);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(70, 66);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(3, 219);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(70, 66);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // SubstrButton
            // 
            this.SubstrButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SubstrButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubstrButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubstrButton.Location = new System.Drawing.Point(231, 147);
            this.SubstrButton.Name = "SubstrButton";
            this.SubstrButton.Size = new System.Drawing.Size(72, 66);
            this.SubstrButton.TabIndex = 11;
            this.SubstrButton.Text = "-";
            this.SubstrButton.UseVisualStyleBackColor = false;
            this.SubstrButton.Click += new System.EventHandler(this.SubstrButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(155, 147);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(70, 66);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(79, 147);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(70, 66);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(3, 147);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(70, 66);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // MultiButton
            // 
            this.MultiButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MultiButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiButton.Location = new System.Drawing.Point(231, 75);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(72, 66);
            this.MultiButton.TabIndex = 7;
            this.MultiButton.Text = "*";
            this.MultiButton.UseVisualStyleBackColor = false;
            this.MultiButton.Click += new System.EventHandler(this.MultiButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(155, 75);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(70, 66);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(79, 75);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(70, 66);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(3, 75);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(70, 66);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // DELButton
            // 
            this.DELButton.BackColor = System.Drawing.SystemColors.Control;
            this.DELButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DELButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELButton.Location = new System.Drawing.Point(155, 3);
            this.DELButton.Name = "DELButton";
            this.DELButton.Size = new System.Drawing.Size(70, 66);
            this.DELButton.TabIndex = 2;
            this.DELButton.Text = "DEL";
            this.DELButton.UseVisualStyleBackColor = false;
            this.DELButton.Click += new System.EventHandler(this.DELButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.SystemColors.Control;
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(70, 66);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PlusMinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinusButton.Location = new System.Drawing.Point(3, 291);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(70, 68);
            this.PlusMinusButton.TabIndex = 20;
            this.PlusMinusButton.Text = "+-";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.BackColor = System.Drawing.SystemColors.Control;
            this.DivisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionButton.Location = new System.Drawing.Point(231, 3);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(72, 66);
            this.DivisionButton.TabIndex = 22;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PercentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentButton.Location = new System.Drawing.Point(79, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(70, 66);
            this.PercentButton.TabIndex = 23;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = false;
            this.PercentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ResultButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(333, 462);
            this.Controls.Add(this.ButtonsTable);
            this.Controls.Add(this.ResultOupput);
            this.Controls.Add(this.UserInput);
            this.MaximumSize = new System.Drawing.Size(357, 515);
            this.Name = "Form1";
            this.Text = "Calculator C#";
            this.ButtonsTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label ResultOupput;
        private System.Windows.Forms.TableLayoutPanel ButtonsTable;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DELButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubstrButton;
        private System.Windows.Forms.Button MultiButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button PercentButton;
    }
}

