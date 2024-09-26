namespace DigitalTwinVisualization
{
    partial class frmDigitalTwinCreationPage
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
            this.lblDigitalTwinCreation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDigitalTwinCreation
            // 
            this.lblDigitalTwinCreation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDigitalTwinCreation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDigitalTwinCreation.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalTwinCreation.Location = new System.Drawing.Point(0, 0);
            this.lblDigitalTwinCreation.Name = "lblDigitalTwinCreation";
            this.lblDigitalTwinCreation.Size = new System.Drawing.Size(1300, 51);
            this.lblDigitalTwinCreation.TabIndex = 0;
            this.lblDigitalTwinCreation.Text = "Digital Twin  Creation";
            this.lblDigitalTwinCreation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmDigitalTwinCreationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.lblDigitalTwinCreation);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDigitalTwinCreationPage";
            this.Text = "DigitalTwinCreationPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDigitalTwinCreationPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDigitalTwinCreation;
    }
}