namespace DesignSidebar.Salles.components.smallComponents
{
    partial class ModalDeleteclass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalDeleteclass));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCloseModalDelete = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNoDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnYesDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelConfirm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icon_delay = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseModalDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.tableLayoutPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCloseModalDelete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 328);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnCloseModalDelete
            // 
            this.btnCloseModalDelete.AllowFocused = false;
            this.btnCloseModalDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseModalDelete.BorderRadius = 19;
            this.btnCloseModalDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseModalDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseModalDelete.Image")));
            this.btnCloseModalDelete.IsCircle = true;
            this.btnCloseModalDelete.Location = new System.Drawing.Point(410, 35);
            this.btnCloseModalDelete.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.btnCloseModalDelete.Name = "btnCloseModalDelete";
            this.btnCloseModalDelete.Size = new System.Drawing.Size(38, 38);
            this.btnCloseModalDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseModalDelete.TabIndex = 1;
            this.btnCloseModalDelete.TabStop = false;
            this.btnCloseModalDelete.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btnCloseModalDelete.Click += new System.EventHandler(this.btnCloseModalDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnNoDelete);
            this.panel1.Controls.Add(this.btnYesDelete);
            this.panel1.Location = new System.Drawing.Point(101, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 94);
            this.panel1.TabIndex = 1;
            // 
            // btnNoDelete
            // 
            this.btnNoDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnNoDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoDelete.BackgroundImage")));
            this.btnNoDelete.ButtonText = "NO";
            this.btnNoDelete.ButtonTextMarginLeft = 0;
            this.btnNoDelete.Cursor = System.Windows.Forms.Cursors.No;
            this.btnNoDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNoDelete.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnNoDelete.DisabledForecolor = System.Drawing.Color.White;
            this.btnNoDelete.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNoDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNoDelete.IconPadding = 10;
            this.btnNoDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNoDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(221)))), ((int)(((byte)(122)))));
            this.btnNoDelete.IdleBorderRadius = 10;
            this.btnNoDelete.IdleBorderThickness = 0;
            this.btnNoDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(221)))), ((int)(((byte)(122)))));
            this.btnNoDelete.IdleIconLeftImage = null;
            this.btnNoDelete.IdleIconRightImage = null;
            this.btnNoDelete.Location = new System.Drawing.Point(140, 29);
            this.btnNoDelete.Name = "btnNoDelete";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            stateProperties1.BorderRadius = 15;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnNoDelete.onHoverState = stateProperties1;
            this.btnNoDelete.Size = new System.Drawing.Size(55, 45);
            this.btnNoDelete.TabIndex = 1;
            this.btnNoDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNoDelete.Click += new System.EventHandler(this.btnNoDelete_Click);
            // 
            // btnYesDelete
            // 
            this.btnYesDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnYesDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYesDelete.BackgroundImage")));
            this.btnYesDelete.ButtonText = "YES";
            this.btnYesDelete.ButtonTextMarginLeft = 0;
            this.btnYesDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYesDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnYesDelete.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnYesDelete.DisabledForecolor = System.Drawing.Color.White;
            this.btnYesDelete.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnYesDelete.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYesDelete.IconPadding = 10;
            this.btnYesDelete.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYesDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.btnYesDelete.IdleBorderRadius = 10;
            this.btnYesDelete.IdleBorderThickness = 0;
            this.btnYesDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.btnYesDelete.IdleIconLeftImage = null;
            this.btnYesDelete.IdleIconRightImage = null;
            this.btnYesDelete.Location = new System.Drawing.Point(60, 29);
            this.btnYesDelete.Name = "btnYesDelete";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(221)))), ((int)(((byte)(122)))));
            stateProperties2.BorderRadius = 15;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(221)))), ((int)(((byte)(122)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnYesDelete.onHoverState = stateProperties2;
            this.btnYesDelete.Size = new System.Drawing.Size(55, 45);
            this.btnYesDelete.TabIndex = 0;
            this.btnYesDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYesDelete.Click += new System.EventHandler(this.btnYesDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.labelConfirm);
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 100);
            this.panel2.TabIndex = 2;
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.Location = new System.Drawing.Point(67, 55);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(341, 18);
            this.labelConfirm.TabIndex = 3;
            this.labelConfirm.Text = "Vous devez bien car cette action est irreversible ! ";
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(65, 18);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(326, 25);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Voulez vous vraiment supprimer ?";
            this.lblMsg.UseWaitCursor = true;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // icon_delay
            // 
            this.icon_delay.Enabled = true;
            this.icon_delay.Interval = 1;
            this.icon_delay.Tick += new System.EventHandler(this.icon_delay_Tick);
            // 
            // ModalDeleteclass
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 328);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "ModalDeleteclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete class";
            this.Load += new System.EventHandler(this.ModalDeleteclass_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseModalDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer icon_delay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsg;
        private Bunifu.UI.WinForms.BunifuPictureBox btnCloseModalDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNoDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYesDelete;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel labelConfirm;
    }
}