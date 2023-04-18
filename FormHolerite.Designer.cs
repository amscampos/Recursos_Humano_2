namespace Recursos_Humanos_2
{
    partial class FormHolerite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHolerite));
            lbHolerite = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbHolerite
            // 
            lbHolerite.Anchor = AnchorStyles.None;
            lbHolerite.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbHolerite.Location = new Point(433, -1);
            lbHolerite.Name = "lbHolerite";
            lbHolerite.Size = new Size(160, 46);
            lbHolerite.TabIndex = 85;
            lbHolerite.Text = "Holerite";
            lbHolerite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-7, 50);
            label1.Name = "label1";
            label1.Size = new Size(1062, 15);
            label1.TabIndex = 86;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormHolerite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 642);
            Controls.Add(lbHolerite);
            Controls.Add(label1);
            Name = "FormHolerite";
            Text = "FormHolerite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHolerite;
        private Label label1;
    }
}