using System.Drawing;
using System.Windows.Forms;

namespace DesignSidebar
{
    partial class Form1 : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 




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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation3 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.drawer = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGoToHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGoToSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.content = new System.Windows.Forms.Panel();
            this.tableLayoutContainerHome = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanelHome = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.tshow = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.thide = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.b_animate_sidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.b_fade_transition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.drawer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.content.SuspendLayout();
            this.tableLayoutContainerHome.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.tableLayoutPanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.BackColor = System.Drawing.Color.White;
            this.drawer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawer.BackgroundImage")));
            this.drawer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawer.Controls.Add(this.bunifuFlatButton1);
            this.drawer.Controls.Add(this.panel2);
            this.drawer.Controls.Add(this.bunifuFlatButton3);
            this.drawer.Controls.Add(this.btnGoToHome);
            this.drawer.Controls.Add(this.btnGoToSearch);
            this.drawer.Controls.Add(this.bunifuFlatButton2);
            this.tshow.SetDecoration(this.drawer, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.drawer, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.drawer, BunifuAnimatorNS.DecorationType.None);
            this.drawer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawer.Location = new System.Drawing.Point(3, 3);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(244, 794);
            this.drawer.TabIndex = 1;
            this.drawer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Etudiant";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.thide.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 50;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 30D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 357);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(242, 56);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Tag = "";
            this.bunifuFlatButton1.Text = "     Etudiant";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(40, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 55);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.b_animate_sidebar.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.thide.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tshow.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(168, 38);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "MyKICT4D";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "     Etudiant";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.thide.SetDecoration(this.bunifuFlatButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 50;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 30D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(-1, 307);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(242, 56);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.Tag = "";
            this.bunifuFlatButton3.Text = "     Etudiant";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.Active = false;
            this.btnGoToHome.Activecolor = System.Drawing.Color.Transparent;
            this.btnGoToHome.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToHome.BorderRadius = 0;
            this.btnGoToHome.ButtonText = "      Accueil";
            this.btnGoToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnGoToHome, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.btnGoToHome, BunifuAnimatorNS.DecorationType.None);
            this.thide.SetDecoration(this.btnGoToHome, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnGoToHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnGoToHome.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoToHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGoToHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGoToHome.Iconimage")));
            this.btnGoToHome.Iconimage_right = null;
            this.btnGoToHome.Iconimage_right_Selected = null;
            this.btnGoToHome.Iconimage_Selected = null;
            this.btnGoToHome.IconMarginLeft = 50;
            this.btnGoToHome.IconMarginRight = 0;
            this.btnGoToHome.IconRightVisible = true;
            this.btnGoToHome.IconRightZoom = 0D;
            this.btnGoToHome.IconVisible = true;
            this.btnGoToHome.IconZoom = 30D;
            this.btnGoToHome.IsTab = true;
            this.btnGoToHome.Location = new System.Drawing.Point(-3, 132);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGoToHome.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGoToHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(248)))));
            this.btnGoToHome.selected = false;
            this.btnGoToHome.Size = new System.Drawing.Size(247, 56);
            this.btnGoToHome.TabIndex = 5;
            this.btnGoToHome.Tag = "";
            this.btnGoToHome.Text = "      Accueil";
            this.btnGoToHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToHome.Textcolor = System.Drawing.Color.White;
            this.btnGoToHome.TextFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // btnGoToSearch
            // 
            this.btnGoToSearch.Active = false;
            this.btnGoToSearch.Activecolor = System.Drawing.Color.Transparent;
            this.btnGoToSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToSearch.BorderRadius = 0;
            this.btnGoToSearch.ButtonText = "      Rechercher ";
            this.btnGoToSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.btnGoToSearch, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.btnGoToSearch, BunifuAnimatorNS.DecorationType.None);
            this.thide.SetDecoration(this.btnGoToSearch, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnGoToSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnGoToSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGoToSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGoToSearch.Iconimage")));
            this.btnGoToSearch.Iconimage_right = null;
            this.btnGoToSearch.Iconimage_right_Selected = null;
            this.btnGoToSearch.Iconimage_Selected = null;
            this.btnGoToSearch.IconMarginLeft = 50;
            this.btnGoToSearch.IconMarginRight = 0;
            this.btnGoToSearch.IconRightVisible = true;
            this.btnGoToSearch.IconRightZoom = 0D;
            this.btnGoToSearch.IconVisible = true;
            this.btnGoToSearch.IconZoom = 30D;
            this.btnGoToSearch.IsTab = true;
            this.btnGoToSearch.Location = new System.Drawing.Point(-3, 192);
            this.btnGoToSearch.Name = "btnGoToSearch";
            this.btnGoToSearch.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGoToSearch.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGoToSearch.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(248)))));
            this.btnGoToSearch.selected = false;
            this.btnGoToSearch.Size = new System.Drawing.Size(240, 56);
            this.btnGoToSearch.TabIndex = 4;
            this.btnGoToSearch.Tag = "";
            this.btnGoToSearch.Text = "      Rechercher ";
            this.btnGoToSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToSearch.Textcolor = System.Drawing.Color.White;
            this.btnGoToSearch.TextFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnGoToSearch.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Details";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tshow.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.thide.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 50;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 30D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 254);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(239)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(240, 56);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Tag = "";
            this.bunifuFlatButton2.Text = "     Details";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            // 
            // content
            // 
            this.content.Controls.Add(this.tableLayoutContainerHome);
            this.tshow.SetDecoration(this.content, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.content, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1300, 800);
            this.content.TabIndex = 2;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // tableLayoutContainerHome
            // 
            this.tableLayoutContainerHome.ColumnCount = 2;
            this.tableLayoutContainerHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutContainerHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutContainerHome.Controls.Add(this.drawer, 0, 0);
            this.tableLayoutContainerHome.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tshow.SetDecoration(this.tableLayoutContainerHome, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.tableLayoutContainerHome, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.tableLayoutContainerHome, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutContainerHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutContainerHome.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutContainerHome.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutContainerHome.Name = "tableLayoutContainerHome";
            this.tableLayoutContainerHome.RowCount = 1;
            this.tableLayoutContainerHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutContainerHome.Size = new System.Drawing.Size(1300, 800);
            this.tableLayoutContainerHome.TabIndex = 3;
            this.tableLayoutContainerHome.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.header, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanelHome, 0, 1);
            this.thide.SetDecoration(this.tableLayoutPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tshow.SetDecoration(this.tableLayoutPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(250, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1050, 800);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.bunifuPictureBox1);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.menuButton);
            this.tshow.SetDecoration(this.header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Location = new System.Drawing.Point(3, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1044, 34);
            this.header.TabIndex = 1;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuPictureBox1.BorderRadius = 12;
            this.tshow.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.bunifuPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(972, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            this.tshow.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1015, 4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(23, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // menuButton
            // 
            this.tshow.SetDecoration(this.menuButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.menuButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(26, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(34, 29);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // tableLayoutPanelHome
            // 
            this.tableLayoutPanelHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelHome.ColumnCount = 1;
            this.tableLayoutPanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHome.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanelHome.Controls.Add(this.panel4, 0, 0);
            this.thide.SetDecoration(this.tableLayoutPanelHome, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.tableLayoutPanelHome, BunifuAnimatorNS.DecorationType.None);
            this.tshow.SetDecoration(this.tableLayoutPanelHome, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tableLayoutPanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHome.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanelHome.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelHome.Name = "tableLayoutPanelHome";
            this.tableLayoutPanelHome.RowCount = 2;
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHome.Size = new System.Drawing.Size(1050, 760);
            this.tableLayoutPanelHome.TabIndex = 2;
            this.tableLayoutPanelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelHome_Paint);
            // 
            // panel1
            // 
            this.tshow.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 740);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 20);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tshow.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thide.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 661);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 79);
            this.panel4.TabIndex = 0;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // tshow
            // 
            this.tshow.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.tshow.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tshow.DefaultAnimation = animation1;
            // 
            // thide
            // 
            this.thide.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.thide.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.thide.DefaultAnimation = animation3;
            // 
            // b_animate_sidebar
            // 
            this.b_animate_sidebar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.b_animate_sidebar.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.b_animate_sidebar.DefaultAnimation = animation2;
            this.b_animate_sidebar.TimeStep = 0.08F;
            // 
            // b_fade_transition
            // 
            this.b_fade_transition.Delay = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.content);
            this.thide.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tshow.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.b_animate_sidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.drawer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.content.ResumeLayout(false);
            this.tableLayoutContainerHome.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.tableLayoutPanelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private void fullScreen()
        {
            /*  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
             this.Name = "Form1";
             this.Text = "Form1";
             this.TopMost = true;
             this.WindowState = System.Windows.Forms.FormWindowState.Maximized;*/

        }
        #endregion
        private System.Windows.Forms.Panel drawer;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private Bunifu.Framework.UI.BunifuFlatButton btnGoToSearch;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGoToHome;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.UI.WinForms.BunifuTransition thide;
        private Bunifu.UI.WinForms.BunifuTransition tshow;
        private Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel MyKICT4D;
        private Panel panel4;
        private TableLayoutPanel tableLayoutContainerHome;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanelHome;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private BunifuAnimatorNS.BunifuTransition b_animate_sidebar;
        private Bunifu.Framework.UI.BunifuFormFadeTransition b_fade_transition;
    }
}

