namespace MyFirstWinApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.GraficConsole = new System.Windows.Forms.RichTextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Retrieve = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Highlight = new System.Windows.Forms.Button();
            this.BlankOut = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY GRAFIC CONSOLE";
            // 
            // GraficConsole
            // 
            this.GraficConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraficConsole.BackColor = System.Drawing.SystemColors.Window;
            this.GraficConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraficConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraficConsole.Location = new System.Drawing.Point(18, 55);
            this.GraficConsole.Name = "GraficConsole";
            this.GraficConsole.Size = new System.Drawing.Size(881, 403);
            this.GraficConsole.TabIndex = 1;
            this.GraficConsole.Text = "<Type anything here>";
            this.GraficConsole.SelectionChanged += new System.EventHandler(this.GraficConsole_SelectionChanged);
            this.GraficConsole.DoubleClick += new System.EventHandler(this.GraficConsole_DoubleClick);
            this.GraficConsole.Enter += new System.EventHandler(this.GraficConsole_Enter);
            this.GraficConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraficConsole_KeyDown);
            this.GraficConsole.Leave += new System.EventHandler(this.GraficConsole_Leave);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(20, 467);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(110, 467);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Save_KeyDown);
            // 
            // Retrieve
            // 
            this.Retrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrieve.Location = new System.Drawing.Point(198, 467);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.Size = new System.Drawing.Size(75, 23);
            this.Retrieve.TabIndex = 4;
            this.Retrieve.Text = "Retrieve";
            this.Retrieve.UseVisualStyleBackColor = true;
            this.Retrieve.Click += new System.EventHandler(this.Retrieve_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(286, 465);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Highlight
            // 
            this.Highlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highlight.Location = new System.Drawing.Point(378, 465);
            this.Highlight.Name = "Highlight";
            this.Highlight.Size = new System.Drawing.Size(104, 25);
            this.Highlight.TabIndex = 6;
            this.Highlight.Text = "HIghlight";
            this.Highlight.UseVisualStyleBackColor = true;
            this.Highlight.Click += new System.EventHandler(this.Highlight_Click);
            // 
            // BlankOut
            // 
            this.BlankOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlankOut.Location = new System.Drawing.Point(516, 467);
            this.BlankOut.Name = "BlankOut";
            this.BlankOut.Size = new System.Drawing.Size(104, 23);
            this.BlankOut.TabIndex = 7;
            this.BlankOut.Text = "Blank Out";
            this.BlankOut.UseVisualStyleBackColor = true;
            this.BlankOut.Click += new System.EventHandler(this.BlankOut_Click);
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.White;
            this.End.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.ForeColor = System.Drawing.Color.Red;
            this.End.Location = new System.Drawing.Point(824, 18);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(75, 31);
            this.End.TabIndex = 8;
            this.End.Text = "End";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 498);
            this.Controls.Add(this.End);
            this.Controls.Add(this.BlankOut);
            this.Controls.Add(this.Highlight);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Retrieve);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.GraficConsole);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BAD LOOKING FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox GraficConsole;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Retrieve;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Highlight;
        private System.Windows.Forms.Button BlankOut;
        private System.Windows.Forms.Button End;
    }
}

