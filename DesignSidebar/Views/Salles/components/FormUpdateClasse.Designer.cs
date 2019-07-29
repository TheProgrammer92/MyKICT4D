namespace DesignSidebar.Salles.components
{
    partial class FormUpdateClasse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateClasse));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleFormUpdate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelError = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name_salle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.type_salle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Batiment_salle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Nombre_de_place_salle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Nombre_de_prises_salle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnUpdateClasse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 723);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.name_salle);
            this.flowLayoutPanel1.Controls.Add(this.type_salle);
            this.flowLayoutPanel1.Controls.Add(this.Batiment_salle);
            this.flowLayoutPanel1.Controls.Add(this.Nombre_de_place_salle);
            this.flowLayoutPanel1.Controls.Add(this.Nombre_de_prises_salle);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateClasse);
            this.flowLayoutPanel1.Controls.Add(this.bunifuButton2);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 658);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.titleFormUpdate);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 96);
            this.panel2.TabIndex = 4;
            // 
            // titleFormUpdate
            // 
            this.titleFormUpdate.AutoSize = true;
            this.titleFormUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFormUpdate.Location = new System.Drawing.Point(56, 44);
            this.titleFormUpdate.Name = "titleFormUpdate";
            this.titleFormUpdate.Size = new System.Drawing.Size(191, 25);
            this.titleFormUpdate.TabIndex = 0;
            this.titleFormUpdate.Text = "Modifier La Classe";
            this.titleFormUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleFormUpdate.Click += new System.EventHandler(this.bunifuCustomLabel1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabelError);
            this.panel3.Location = new System.Drawing.Point(3, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 27);
            this.panel3.TabIndex = 13;
            // 
            // LabelError
            // 
            this.LabelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelError.AutoSize = true;
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelError.Location = new System.Drawing.Point(49, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(151, 16);
            this.LabelError.TabIndex = 14;
            this.LabelError.Text = "Vous devez tous remplir";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelError.Visible = false;
            // 
            // name_salle
            // 
            this.name_salle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.name_salle.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.name_salle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.name_salle.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.name_salle.BorderThickness = 15;
            this.name_salle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.name_salle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_salle.ForeColor = System.Drawing.Color.Silver;
            this.name_salle.isPassword = false;
            this.name_salle.Location = new System.Drawing.Point(5, 144);
            this.name_salle.Margin = new System.Windows.Forms.Padding(5, 9, 5, 4);
            this.name_salle.MaxLength = 32767;
            this.name_salle.Name = "name_salle";
            this.name_salle.Size = new System.Drawing.Size(302, 53);
            this.name_salle.TabIndex = 0;
            this.name_salle.Text = "Nom";
            this.name_salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name_salle.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // type_salle
            // 
            this.type_salle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.type_salle.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.type_salle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.type_salle.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.type_salle.BorderThickness = 15;
            this.type_salle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.type_salle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.type_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_salle.ForeColor = System.Drawing.Color.Silver;
            this.type_salle.isPassword = false;
            this.type_salle.Location = new System.Drawing.Point(5, 210);
            this.type_salle.Margin = new System.Windows.Forms.Padding(5, 9, 5, 4);
            this.type_salle.MaxLength = 32767;
            this.type_salle.Name = "type_salle";
            this.type_salle.Size = new System.Drawing.Size(302, 53);
            this.type_salle.TabIndex = 9;
            this.type_salle.Text = "Type";
            this.type_salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Batiment_salle
            // 
            this.Batiment_salle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Batiment_salle.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Batiment_salle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Batiment_salle.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Batiment_salle.BorderThickness = 15;
            this.Batiment_salle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Batiment_salle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Batiment_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batiment_salle.ForeColor = System.Drawing.Color.Silver;
            this.Batiment_salle.isPassword = false;
            this.Batiment_salle.Location = new System.Drawing.Point(5, 276);
            this.Batiment_salle.Margin = new System.Windows.Forms.Padding(5, 9, 5, 4);
            this.Batiment_salle.MaxLength = 32767;
            this.Batiment_salle.Name = "Batiment_salle";
            this.Batiment_salle.Size = new System.Drawing.Size(302, 53);
            this.Batiment_salle.TabIndex = 10;
            this.Batiment_salle.Text = "Batiment";
            this.Batiment_salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Nombre_de_place_salle
            // 
            this.Nombre_de_place_salle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_place_salle.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_place_salle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_place_salle.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_place_salle.BorderThickness = 15;
            this.Nombre_de_place_salle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Nombre_de_place_salle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombre_de_place_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_de_place_salle.ForeColor = System.Drawing.Color.Silver;
            this.Nombre_de_place_salle.isPassword = false;
            this.Nombre_de_place_salle.Location = new System.Drawing.Point(5, 342);
            this.Nombre_de_place_salle.Margin = new System.Windows.Forms.Padding(5, 9, 5, 4);
            this.Nombre_de_place_salle.MaxLength = 32767;
            this.Nombre_de_place_salle.Name = "Nombre_de_place_salle";
            this.Nombre_de_place_salle.Size = new System.Drawing.Size(302, 53);
            this.Nombre_de_place_salle.TabIndex = 11;
            this.Nombre_de_place_salle.Text = "Nombre de place";
            this.Nombre_de_place_salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nombre_de_place_salle.OnValueChanged += new System.EventHandler(this.Nombre_de_place_salle_OnValueChanged);
            // 
            // Nombre_de_prises_salle
            // 
            this.Nombre_de_prises_salle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_prises_salle.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_prises_salle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_prises_salle.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Nombre_de_prises_salle.BorderThickness = 15;
            this.Nombre_de_prises_salle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Nombre_de_prises_salle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombre_de_prises_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_de_prises_salle.ForeColor = System.Drawing.Color.Silver;
            this.Nombre_de_prises_salle.isPassword = false;
            this.Nombre_de_prises_salle.Location = new System.Drawing.Point(5, 408);
            this.Nombre_de_prises_salle.Margin = new System.Windows.Forms.Padding(5, 9, 5, 4);
            this.Nombre_de_prises_salle.MaxLength = 32767;
            this.Nombre_de_prises_salle.Name = "Nombre_de_prises_salle";
            this.Nombre_de_prises_salle.Size = new System.Drawing.Size(302, 53);
            this.Nombre_de_prises_salle.TabIndex = 12;
            this.Nombre_de_prises_salle.Text = "Nombre de prises";
            this.Nombre_de_prises_salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nombre_de_prises_salle.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox5_OnValueChanged_1);
            // 
            // btnUpdateClasse
            // 
            this.btnUpdateClasse.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateClasse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateClasse.BackgroundImage")));
            this.btnUpdateClasse.ButtonText = "MODIFIER";
            this.btnUpdateClasse.ButtonTextMarginLeft = 0;
            this.btnUpdateClasse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnUpdateClasse.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnUpdateClasse.DisabledForecolor = System.Drawing.Color.White;
            this.btnUpdateClasse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClasse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateClasse.IconPadding = 10;
            this.btnUpdateClasse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateClasse.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.btnUpdateClasse.IdleBorderRadius = 5;
            this.btnUpdateClasse.IdleBorderThickness = 5;
            this.btnUpdateClasse.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.btnUpdateClasse.IdleIconLeftImage = null;
            this.btnUpdateClasse.IdleIconRightImage = null;
            this.btnUpdateClasse.Location = new System.Drawing.Point(3, 468);
            this.btnUpdateClasse.Name = "btnUpdateClasse";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnUpdateClasse.onHoverState = stateProperties1;
            this.btnUpdateClasse.Size = new System.Drawing.Size(304, 52);
            this.btnUpdateClasse.TabIndex = 7;
            this.btnUpdateClasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateClasse.Click += new System.EventHandler(this.btnUpdateClasse_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.ButtonText = "MODIFIER";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(142)))), ((int)(((byte)(248)))));
            this.bunifuButton2.IdleBorderRadius = 5;
            this.bunifuButton2.IdleBorderThickness = 5;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(142)))), ((int)(((byte)(248)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.Location = new System.Drawing.Point(3, 526);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties2;
            this.bunifuButton2.Size = new System.Drawing.Size(304, 52);
            this.bunifuButton2.TabIndex = 8;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUpdateClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormUpdateClasse";
            this.Size = new System.Drawing.Size(373, 761);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel titleFormUpdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox name_salle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateClasse;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.Framework.UI.BunifuMetroTextbox type_salle;
        private Bunifu.Framework.UI.BunifuMetroTextbox Batiment_salle;
        private Bunifu.Framework.UI.BunifuMetroTextbox Nombre_de_place_salle;
        private Bunifu.Framework.UI.BunifuMetroTextbox Nombre_de_prises_salle;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelError;
    }
}
