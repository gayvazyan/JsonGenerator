namespace JsonGenerator.UI
{
    partial class JsonViwerForm
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
            richJsonViewer = new RichTextBox();
            SuspendLayout();
            // 
            // richJsonViewer
            // 
            richJsonViewer.Dock = DockStyle.Fill;
            richJsonViewer.Location = new Point(0, 0);
            richJsonViewer.Name = "richJsonViewer";
            richJsonViewer.Size = new Size(800, 450);
            richJsonViewer.TabIndex = 0;
            richJsonViewer.Text = "";
            // 
            // JsonViwerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richJsonViewer);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JsonViwerForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richJsonViewer;
    }
}