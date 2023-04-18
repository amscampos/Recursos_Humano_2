namespace Recursos_Humanos_2
{
    partial class FormCalculoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculoPagamento));
            lbCalculoPagamento = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbCalculoPagamento
            // 
            lbCalculoPagamento.Anchor = AnchorStyles.None;
            lbCalculoPagamento.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCalculoPagamento.Location = new Point(339, 0);
            lbCalculoPagamento.Name = "lbCalculoPagamento";
            lbCalculoPagamento.Size = new Size(392, 46);
            lbCalculoPagamento.TabIndex = 87;
            lbCalculoPagamento.Text = "Cálculos de Pagamentos";
            lbCalculoPagamento.TextAlign = ContentAlignment.MiddleCenter;
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
            // FormCalculoPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 642);
            Controls.Add(lbCalculoPagamento);
            Controls.Add(label1);
            Name = "FormCalculoPagamento";
            Text = "FormCalculoPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCalculoPagamento;
        private Label label1;
    }
}