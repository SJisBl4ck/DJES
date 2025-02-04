namespace DJES
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            frmEntradas = new ToolStripButton();
            frmSalidas = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1279, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Thistle;
            toolStrip1.Font = new Font("Calibri", 9F);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { frmEntradas, frmSalidas, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1279, 70);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // frmEntradas
            // 
            frmEntradas.AutoSize = false;
            frmEntradas.Image = (Image)resources.GetObject("frmEntradas.Image");
            frmEntradas.ImageTransparentColor = Color.Magenta;
            frmEntradas.Margin = new Padding(2, 2, 4, 4);
            frmEntradas.Name = "frmEntradas";
            frmEntradas.Padding = new Padding(1);
            frmEntradas.Size = new Size(59, 67);
            frmEntradas.Text = "Entradas";
            frmEntradas.TextImageRelation = TextImageRelation.ImageAboveText;
            frmEntradas.Click += frmEntradas_Click;
            // 
            // frmSalidas
            // 
            frmSalidas.AutoSize = false;
            frmSalidas.Image = (Image)resources.GetObject("frmSalidas.Image");
            frmSalidas.ImageTransparentColor = Color.Magenta;
            frmSalidas.Margin = new Padding(2, 2, 4, 4);
            frmSalidas.Name = "frmSalidas";
            frmSalidas.Padding = new Padding(1);
            frmSalidas.Size = new Size(52, 67);
            frmSalidas.Text = "Salidas";
            frmSalidas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.AutoSize = false;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Margin = new Padding(2, 2, 4, 4);
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Padding = new Padding(1);
            toolStripDropDownButton1.Size = new Size(52, 67);
            toolStripDropDownButton1.Text = "Cerrar";
            toolStripDropDownButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(99, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1279, 512);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton frmEntradas;
        private ToolStripButton frmSalidas;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
