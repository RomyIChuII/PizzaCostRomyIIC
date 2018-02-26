namespace PizzaCostRomyIIC
{
    partial class frmPizzaCost
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
            this.lblAskForDiameter = new System.Windows.Forms.Label();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.txtDiameterOfPizza = new System.Windows.Forms.TextBox();
            this.lblDeclareCost = new System.Windows.Forms.Label();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAskForDiameter
            // 
            this.lblAskForDiameter.AutoSize = true;
            this.lblAskForDiameter.Font = new System.Drawing.Font("Monospac821 BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskForDiameter.Location = new System.Drawing.Point(12, 62);
            this.lblAskForDiameter.Name = "lblAskForDiameter";
            this.lblAskForDiameter.Size = new System.Drawing.Size(303, 32);
            this.lblAskForDiameter.TabIndex = 0;
            this.lblAskForDiameter.Text = "Diameter Of Pizza:";
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(190, 120);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(125, 50);
            this.btnCalculateCost.TabIndex = 1;
            this.btnCalculateCost.Text = "Calculate";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // txtDiameterOfPizza
            // 
            this.txtDiameterOfPizza.Location = new System.Drawing.Point(337, 74);
            this.txtDiameterOfPizza.Name = "txtDiameterOfPizza";
            this.txtDiameterOfPizza.Size = new System.Drawing.Size(162, 20);
            this.txtDiameterOfPizza.TabIndex = 2;
            // 
            // lblDeclareCost
            // 
            this.lblDeclareCost.AutoSize = true;
            this.lblDeclareCost.Font = new System.Drawing.Font("Monospac821 BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeclareCost.Location = new System.Drawing.Point(12, 214);
            this.lblDeclareCost.Name = "lblDeclareCost";
            this.lblDeclareCost.Size = new System.Drawing.Size(335, 32);
            this.lblDeclareCost.TabIndex = 4;
            this.lblDeclareCost.Text = "Total Cost Of Pizza:";
            // 
            // lblPizzaCost
            // 
            this.lblPizzaCost.AutoSize = true;
            this.lblPizzaCost.Font = new System.Drawing.Font("Monospac821 BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaCost.Location = new System.Drawing.Point(381, 214);
            this.lblPizzaCost.Name = "lblPizzaCost";
            this.lblPizzaCost.Size = new System.Drawing.Size(47, 32);
            this.lblPizzaCost.TabIndex = 5;
            this.lblPizzaCost.Text = "$0";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(560, 316);
            this.Controls.Add(this.lblPizzaCost);
            this.Controls.Add(this.lblDeclareCost);
            this.Controls.Add(this.txtDiameterOfPizza);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.lblAskForDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost by RomyIIC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAskForDiameter;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.TextBox txtDiameterOfPizza;
        private System.Windows.Forms.Label lblDeclareCost;
        private System.Windows.Forms.Label lblPizzaCost;
    }
}

