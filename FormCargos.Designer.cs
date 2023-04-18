namespace Recursos_Humanos_2
{
    partial class FormCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargos));
            lbCargos = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbCargos
            // 
            lbCargos.Anchor = AnchorStyles.None;
            lbCargos.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCargos.Location = new Point(430, 0);
            lbCargos.Name = "lbCargos";
            lbCargos.Size = new Size(160, 46);
            lbCargos.TabIndex = 87;
            lbCargos.Text = "Cargos";
            lbCargos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-7, 50);
            label1.Name = "label1";
            label1.Size = new Size(1062, 15);
            label1.TabIndex = 88;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 642);
            Controls.Add(lbCargos);
            Controls.Add(label1);
            Name = "FormCargos";
            Text = "FormCargos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCargos;
        private Label label1;
    }
}