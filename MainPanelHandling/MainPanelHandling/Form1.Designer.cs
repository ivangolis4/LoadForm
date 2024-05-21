namespace MainPanelHandling
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCollections = new Button();
            btnDashBoard = new Button();
            btnProducts = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(btnCollections);
            panel1.Controls.Add(btnDashBoard);
            panel1.Controls.Add(btnProducts);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnCollections
            // 
            btnCollections.BackColor = SystemColors.ActiveCaptionText;
            btnCollections.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCollections.ForeColor = Color.Cornsilk;
            btnCollections.Location = new Point(0, 197);
            btnCollections.Name = "btnCollections";
            btnCollections.Size = new Size(163, 38);
            btnCollections.TabIndex = 4;
            btnCollections.Text = "Collections";
            btnCollections.UseVisualStyleBackColor = false;
            btnCollections.Click += btnCollections_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = SystemColors.ActiveCaptionText;
            btnDashBoard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashBoard.ForeColor = Color.Cornsilk;
            btnDashBoard.Location = new Point(0, 87);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(163, 38);
            btnDashBoard.TabIndex = 2;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.ActiveCaptionText;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.Cornsilk;
            btnProducts.Location = new Point(0, 144);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(163, 38);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(163, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 41);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaptionText;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Cornsilk;
            btnClose.Location = new Point(608, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(163, 41);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(637, 409);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCollections;
        private Button btnDashBoard;
        private Button btnProducts;
        private Button btnClose;
        private Panel panelContainer;
    }
}
