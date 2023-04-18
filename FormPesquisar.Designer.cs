namespace Recursos_Humanos_2
{
    partial class FormPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisar));
            lbPesquisar = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbPesquisar
            // 
            lbPesquisar.Anchor = AnchorStyles.None;
            lbPesquisar.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbPesquisar.Location = new Point(434, -4);
            lbPesquisar.Name = "lbPesquisar";
            lbPesquisar.Size = new Size(160, 46);
            lbPesquisar.TabIndex = 83;
            lbPesquisar.Text = "Pesquisar";
            lbPesquisar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-3, 50);
            label1.Name = "label1";
            label1.Size = new Size(1062, 15);
            label1.TabIndex = 84;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 642);
            Controls.Add(lbPesquisar);
            Controls.Add(label1);
            Name = "FormPesquisar";
            Text = "FormPesquisar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPesquisar;
        private Label label1;
    }
}