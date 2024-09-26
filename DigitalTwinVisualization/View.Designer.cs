namespace DigitalTwinVisualization
{
    partial class View
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
            this.lblView = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblView
            // 
            this.lblView.BackColor = System.Drawing.Color.LightCoral;
            this.lblView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblView.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(0, 0);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(800, 56);
            this.lblView.TabIndex = 2;
            this.lblView.Text = "View Page";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.ItemHeight = 16;
            this.lstView.Location = new System.Drawing.Point(209, 127);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(383, 196);
            this.lstView.TabIndex = 3;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.lblView);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.ListBox lstView;
    }
}