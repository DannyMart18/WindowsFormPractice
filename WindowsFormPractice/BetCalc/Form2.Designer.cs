namespace BetCalc
{
    partial class Form2
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
            this.lblFctorial = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblFibionicci = new System.Windows.Forms.Label();
            this.lblTBC = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFctorial
            // 
            this.lblFctorial.AutoSize = true;
            this.lblFctorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFctorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFctorial.Location = new System.Drawing.Point(43, 141);
            this.lblFctorial.Name = "lblFctorial";
            this.lblFctorial.Size = new System.Drawing.Size(127, 34);
            this.lblFctorial.TabIndex = 0;
            this.lblFctorial.Text = "Factorial";
            this.lblFctorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(299, 35);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(173, 32);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MAIN MENU";
            // 
            // lblFibionicci
            // 
            this.lblFibionicci.AutoSize = true;
            this.lblFibionicci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFibionicci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFibionicci.Location = new System.Drawing.Point(222, 141);
            this.lblFibionicci.Name = "lblFibionicci";
            this.lblFibionicci.Size = new System.Drawing.Size(284, 34);
            this.lblFibionicci.TabIndex = 2;
            this.lblFibionicci.Text = "Leap Year Calculator";
            this.lblFibionicci.Click += new System.EventHandler(this.lblFibionicci_Click);
            // 
            // lblTBC
            // 
            this.lblTBC.AutoSize = true;
            this.lblTBC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBC.Location = new System.Drawing.Point(544, 141);
            this.lblTBC.Name = "lblTBC";
            this.lblTBC.Size = new System.Drawing.Size(227, 34);
            this.lblTBC.TabIndex = 3;
            this.lblTBC.Text = "Wage Calculator";
            this.lblTBC.Click += new System.EventHandler(this.lblTBC_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(305, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTBC);
            this.Controls.Add(this.lblFibionicci);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblFctorial);
            this.Name = "Form2";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFctorial;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblFibionicci;
        private System.Windows.Forms.Label lblTBC;
        private System.Windows.Forms.Button btnClose;
    }
}