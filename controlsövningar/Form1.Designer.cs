namespace controlsövningar
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
            tabControl1 = new TabControl();
            nameList = new TabPage();
            formatText = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(nameList);
            tabControl1.Controls.Add(formatText);
            tabControl1.Location = new Point(-3, -1);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(704, 340);
            tabControl1.TabIndex = 0;
            // 
            // nameList
            // 
            nameList.Location = new Point(4, 24);
            nameList.Margin = new Padding(3, 2, 3, 2);
            nameList.Name = "nameList";
            nameList.Padding = new Padding(3, 2, 3, 2);
            nameList.Size = new Size(696, 312);
            nameList.TabIndex = 0;
            nameList.Text = "Namnlista";
            nameList.UseVisualStyleBackColor = true;
            // 
            // formatText
            // 
            formatText.Location = new Point(4, 24);
            formatText.Margin = new Padding(3, 2, 3, 2);
            formatText.Name = "formatText";
            formatText.Padding = new Padding(3, 2, 3, 2);
            formatText.Size = new Size(696, 312);
            formatText.TabIndex = 1;
            formatText.Text = "Formattera";
            formatText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage nameList;
        private TabPage formatText;
    }
}