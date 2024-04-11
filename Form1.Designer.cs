namespace PrimeNumberFinder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button = new Button();
            listView = new ListView();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(388, 57);
            button.Name = "button";
            button.Size = new Size(122, 31);
            button.TabIndex = 0;
            button.Text = "Generate Prime";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // listView
            // 
            listView.Location = new Point(58, 12);
            listView.Name = "listView";
            listView.Size = new Size(249, 274);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 334);
            Controls.Add(listView);
            Controls.Add(button);
            Name = "Form1";
            Text = "Prime Number Finder";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListView listView;
    }
}