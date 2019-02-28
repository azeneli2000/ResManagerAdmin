namespace ResManagerAdmin.Forms
{
    partial class frmRezervime
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
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.barBottomDockSite = new DevComponents.DotNetBar.DockSite();
            this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
            this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
            this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
            this.dockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.lnSkaduara = new System.Windows.Forms.LinkLabel();
            this.lnFshi = new System.Windows.Forms.LinkLabel();
            this.lnModifiko = new System.Windows.Forms.LinkLabel();
            this.lnShtoREzervim = new System.Windows.Forms.LinkLabel();
            this.calendar = new Janus.Windows.Schedule.Calendar();
            this.scheduleRezervimet = new Janus.Windows.Schedule.Schedule();
            this.cmShtoRezervim = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripShto = new System.Windows.Forms.ToolStripMenuItem();
            this.modifikoRezerviminEZgjedhurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshiRezerviminEZgjedhurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervimetJashtëAfatitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleRezervimet)).BeginInit();
            this.cmShtoRezervim.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "tabItem1";
            // 
            // tabItem2
            // 
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "tabItem2";
            // 
            // dotNetBarManager1
            // 
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager1.BottomDockSite = this.barBottomDockSite;
            this.dotNetBarManager1.DefinitionName = "";
            this.dotNetBarManager1.EnableFullSizeDock = false;
            this.dotNetBarManager1.LeftDockSite = this.barLeftDockSite;
            this.dotNetBarManager1.ParentForm = this;
            this.dotNetBarManager1.RightDockSite = this.barRightDockSite;
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dotNetBarManager1.ThemeAware = false;
            this.dotNetBarManager1.TopDockSite = this.barTopDockSite;
            // 
            // barBottomDockSite
            // 
            this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barBottomDockSite.Location = new System.Drawing.Point(0, 614);
            this.barBottomDockSite.Name = "barBottomDockSite";
            this.barBottomDockSite.NeedsLayout = false;
            this.barBottomDockSite.Size = new System.Drawing.Size(1020, 0);
            this.barBottomDockSite.TabIndex = 4;
            this.barBottomDockSite.TabStop = false;
            // 
            // barLeftDockSite
            // 
            this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
            this.barLeftDockSite.Location = new System.Drawing.Point(0, 0);
            this.barLeftDockSite.Name = "barLeftDockSite";
            this.barLeftDockSite.NeedsLayout = false;
            this.barLeftDockSite.Size = new System.Drawing.Size(0, 614);
            this.barLeftDockSite.TabIndex = 1;
            this.barLeftDockSite.TabStop = false;
            // 
            // barRightDockSite
            // 
            this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
            this.barRightDockSite.Location = new System.Drawing.Point(1020, 0);
            this.barRightDockSite.Name = "barRightDockSite";
            this.barRightDockSite.NeedsLayout = false;
            this.barRightDockSite.Size = new System.Drawing.Size(0, 614);
            this.barRightDockSite.TabIndex = 2;
            this.barRightDockSite.TabStop = false;
            // 
            // barTopDockSite
            // 
            this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
            this.barTopDockSite.Location = new System.Drawing.Point(0, 0);
            this.barTopDockSite.Name = "barTopDockSite";
            this.barTopDockSite.NeedsLayout = false;
            this.barTopDockSite.Size = new System.Drawing.Size(1020, 0);
            this.barTopDockSite.TabIndex = 3;
            this.barTopDockSite.TabStop = false;
            // 
            // dockContainerItem2
            // 
            this.dockContainerItem2.Name = "dockContainerItem2";
            this.dockContainerItem2.Text = "dockContainerItem2";
            // 
            // panelDockContainer2
            // 
            this.panelDockContainer2.Location = new System.Drawing.Point(3, 39);
            this.panelDockContainer2.Name = "panelDockContainer2";
            this.panelDockContainer2.Size = new System.Drawing.Size(32, 32);
            this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer2.Style.GradientAngle = 90;
            this.panelDockContainer2.TabIndex = 2;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.lnSkaduara);
            this.expandablePanel1.Controls.Add(this.lnFshi);
            this.expandablePanel1.Controls.Add(this.lnModifiko);
            this.expandablePanel1.Controls.Add(this.lnShtoREzervim);
            this.expandablePanel1.Controls.Add(this.calendar);
            this.expandablePanel1.Controls.Add(this.scheduleRezervimet);
            this.expandablePanel1.Controls.Add(this.panelEx1);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1020, 614);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 5;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Rezervimet";
            // 
            // lnSkaduara
            // 
            this.lnSkaduara.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lnSkaduara.Image = global::ResManagerAdmin.Properties.Resources.rezervimetjashteafatit;
            this.lnSkaduara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnSkaduara.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lnSkaduara.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lnSkaduara.Location = new System.Drawing.Point(12, 330);
            this.lnSkaduara.Name = "lnSkaduara";
            this.lnSkaduara.Size = new System.Drawing.Size(138, 23);
            this.lnSkaduara.TabIndex = 8;
            this.lnSkaduara.TabStop = true;
            this.lnSkaduara.Text = "Rezervimet jashtë afatit";
            this.lnSkaduara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnSkaduara.VisitedLinkColor = System.Drawing.Color.SandyBrown;
            this.lnSkaduara.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnSkaduara_LinkClicked);
            // 
            // lnFshi
            // 
            this.lnFshi.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lnFshi.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.lnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnFshi.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lnFshi.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lnFshi.Location = new System.Drawing.Point(12, 289);
            this.lnFshi.Name = "lnFshi";
            this.lnFshi.Size = new System.Drawing.Size(150, 23);
            this.lnFshi.TabIndex = 7;
            this.lnFshi.TabStop = true;
            this.lnFshi.Text = "Fshi rezervimin e zgjedhur";
            this.lnFshi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnFshi.VisitedLinkColor = System.Drawing.Color.SandyBrown;
            this.lnFshi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnFshi_LinkClicked);
            // 
            // lnModifiko
            // 
            this.lnModifiko.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lnModifiko.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.lnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnModifiko.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lnModifiko.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lnModifiko.Location = new System.Drawing.Point(12, 248);
            this.lnModifiko.Name = "lnModifiko";
            this.lnModifiko.Size = new System.Drawing.Size(170, 23);
            this.lnModifiko.TabIndex = 6;
            this.lnModifiko.TabStop = true;
            this.lnModifiko.Text = "Modifiko rezervimin e zgjedhur";
            this.lnModifiko.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnModifiko.VisitedLinkColor = System.Drawing.Color.SandyBrown;
            this.lnModifiko.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnModifiko_LinkClicked);
            // 
            // lnShtoREzervim
            // 
            this.lnShtoREzervim.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.lnShtoREzervim.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.lnShtoREzervim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnShtoREzervim.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lnShtoREzervim.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lnShtoREzervim.Location = new System.Drawing.Point(12, 211);
            this.lnShtoREzervim.Name = "lnShtoREzervim";
            this.lnShtoREzervim.Size = new System.Drawing.Size(91, 23);
            this.lnShtoREzervim.TabIndex = 5;
            this.lnShtoREzervim.TabStop = true;
            this.lnShtoREzervim.Text = "Shto rezervim";
            this.lnShtoREzervim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnShtoREzervim.VisitedLinkColor = System.Drawing.Color.SandyBrown;
            this.lnShtoREzervim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnShtoREzervim_LinkClicked);
            // 
            // calendar
            // 
            this.calendar.CurrentDate = new System.DateTime(2006, 9, 29, 0, 0, 0, 0);
            this.calendar.DaysFormatStyle.FontItalic = Janus.Windows.Schedule.TriState.False;
            this.calendar.DaysHeadersFormatStyle.FontBold = Janus.Windows.Schedule.TriState.True;
            this.calendar.DaysHeadersFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.calendar.FirstDayOfWeek = Janus.Windows.Schedule.CalendarDayOfWeek.Monday;
            this.calendar.FirstMonth = new System.DateTime(2006, 9, 1, 0, 0, 0, 0);
            this.calendar.HeadersFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.calendar.Location = new System.Drawing.Point(12, 36);
            this.calendar.MonthBackgroundStyle.BackColor = System.Drawing.Color.White;
            this.calendar.MonthBackgroundStyle.BackColorAlphaMode = Janus.Windows.Schedule.AlphaMode.UseAlpha;
            this.calendar.MonthBackgroundStyle.BackColorGradient = System.Drawing.SystemColors.InactiveCaptionText;
            this.calendar.MonthBackgroundStyle.BackgroundGradientMode = Janus.Windows.Schedule.BackgroundGradientMode.Horizontal;
            this.calendar.MonthBackgroundStyle.ForeColor = System.Drawing.Color.Navy;
            this.calendar.Name = "calendar";
            this.calendar.SelectedDates = new System.DateTime[0];
            this.calendar.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calendar.Size = new System.Drawing.Size(150, 134);
            this.calendar.TabIndex = 3;
            this.calendar.Text = "Calendar";
            this.calendar.SelectionChanged += new System.EventHandler(this.calendar_SelectionChanged);
            // 
            // scheduleRezervimet
            // 
            this.scheduleRezervimet.AddNewMode = Janus.Windows.Schedule.AddNewMode.Manual;
            this.scheduleRezervimet.AllDayAreaBackgroundStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.scheduleRezervimet.AllDayAreaBackgroundStyle.BackColorAlphaMode = Janus.Windows.Schedule.AlphaMode.UseAlpha;
            this.scheduleRezervimet.AllDayAreaBackgroundStyle.BackColorGradient = System.Drawing.Color.WhiteSmoke;
            this.scheduleRezervimet.AllDayAreaBackgroundStyle.BackgroundGradientMode = Janus.Windows.Schedule.BackgroundGradientMode.Horizontal;
            this.scheduleRezervimet.AllowAppointmentDrag = Janus.Windows.Schedule.AllowAppointmentDrag.None;
            this.scheduleRezervimet.AllowEdit = false;
            this.scheduleRezervimet.AppointmentOutLineColor = System.Drawing.Color.Empty;
            this.scheduleRezervimet.AppointmentsFormatStyle.BackgroundGradientMode = Janus.Windows.Schedule.BackgroundGradientMode.Solid;
            this.scheduleRezervimet.AppointmentsFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.scheduleRezervimet.BorderStyle = Janus.Windows.Schedule.BorderStyle.None;
            this.scheduleRezervimet.ContextMenuStrip = this.cmShtoRezervim;
            this.scheduleRezervimet.Date = new System.DateTime(2006, 9, 28, 0, 0, 0, 0);
            this.scheduleRezervimet.DefaultBackColorAlphaMode = Janus.Windows.Schedule.AlphaMode.UseAlpha;
            this.scheduleRezervimet.Dock = System.Windows.Forms.DockStyle.Right;
            this.scheduleRezervimet.FirstDayOfWeek = Janus.Windows.Schedule.ScheduleDayOfWeek.Monday;
            this.scheduleRezervimet.HiddenAppointmentMode = Janus.Windows.Schedule.HiddenAppointmentMode.Manual;
            this.scheduleRezervimet.HourBackgroundStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.scheduleRezervimet.LayoutData = "<ScheduleLayoutData><MultiOwner>True</MultiOwner></ScheduleLayoutData>";
            this.scheduleRezervimet.Location = new System.Drawing.Point(205, 26);
            this.scheduleRezervimet.MultiOwner = true;
            this.scheduleRezervimet.MultiSelect = false;
            this.scheduleRezervimet.Name = "scheduleRezervimet";
            this.scheduleRezervimet.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.Schedule.AlphaMode.UseAlpha;
            this.scheduleRezervimet.SelectedFormatStyle.BackColorGradient = System.Drawing.Color.AliceBlue;
            this.scheduleRezervimet.Size = new System.Drawing.Size(815, 588);
            this.scheduleRezervimet.TabIndex = 2;
            this.scheduleRezervimet.TimeFormat = Janus.Windows.Schedule.TimeFormat.TwentyFourHours;
            this.scheduleRezervimet.WorkEndTime = System.TimeSpan.Parse("23:59:59");
            this.scheduleRezervimet.WorkingHourBackgroundStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.scheduleRezervimet.WorkStartTime = System.TimeSpan.Parse("00:00:00");
            this.scheduleRezervimet.WorkWeek = ((Janus.Windows.Schedule.ScheduleDayOfWeek)(((((((Janus.Windows.Schedule.ScheduleDayOfWeek.Sunday | Janus.Windows.Schedule.ScheduleDayOfWeek.Monday)
                        | Janus.Windows.Schedule.ScheduleDayOfWeek.Tuesday)
                        | Janus.Windows.Schedule.ScheduleDayOfWeek.Wednesday)
                        | Janus.Windows.Schedule.ScheduleDayOfWeek.Thursday)
                        | Janus.Windows.Schedule.ScheduleDayOfWeek.Friday)
                        | Janus.Windows.Schedule.ScheduleDayOfWeek.Saturday)));
            this.scheduleRezervimet.AppointmentDoubleClick += new Janus.Windows.Schedule.AppointmentEventHandler(this.scheduleRezervimet_AppointmentDoubleClick);
            // 
            // cmShtoRezervim
            // 
            this.cmShtoRezervim.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripShto,
            this.modifikoRezerviminEZgjedhurToolStripMenuItem,
            this.fshiRezerviminEZgjedhurToolStripMenuItem,
            this.rezervimetJashtëAfatitToolStripMenuItem});
            this.cmShtoRezervim.Name = "cmShtoRezervim";
            this.cmShtoRezervim.Size = new System.Drawing.Size(231, 92);
            // 
            // toolStripShto
            // 
            this.toolStripShto.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.toolStripShto.Name = "toolStripShto";
            this.toolStripShto.Size = new System.Drawing.Size(230, 22);
            this.toolStripShto.Tag = "";
            this.toolStripShto.Text = "Shto rezervim";
            this.toolStripShto.Click += new System.EventHandler(this.toolStripShto_Click);
            // 
            // modifikoRezerviminEZgjedhurToolStripMenuItem
            // 
            this.modifikoRezerviminEZgjedhurToolStripMenuItem.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.modifikoRezerviminEZgjedhurToolStripMenuItem.Name = "modifikoRezerviminEZgjedhurToolStripMenuItem";
            this.modifikoRezerviminEZgjedhurToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.modifikoRezerviminEZgjedhurToolStripMenuItem.Text = "Modifiko rezervimin e zgjedhur";
            this.modifikoRezerviminEZgjedhurToolStripMenuItem.Click += new System.EventHandler(this.modifikoRezerviminEZgjedhurToolStripMenuItem_Click);
            // 
            // fshiRezerviminEZgjedhurToolStripMenuItem
            // 
            this.fshiRezerviminEZgjedhurToolStripMenuItem.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.fshiRezerviminEZgjedhurToolStripMenuItem.Name = "fshiRezerviminEZgjedhurToolStripMenuItem";
            this.fshiRezerviminEZgjedhurToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.fshiRezerviminEZgjedhurToolStripMenuItem.Text = "Fshi rezervimin e zgjedhur";
            this.fshiRezerviminEZgjedhurToolStripMenuItem.Click += new System.EventHandler(this.fshiRezerviminEZgjedhurToolStripMenuItem_Click);
            // 
            // rezervimetJashtëAfatitToolStripMenuItem
            // 
            this.rezervimetJashtëAfatitToolStripMenuItem.Image = global::ResManagerAdmin.Properties.Resources.day_f21;
            this.rezervimetJashtëAfatitToolStripMenuItem.Name = "rezervimetJashtëAfatitToolStripMenuItem";
            this.rezervimetJashtëAfatitToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.rezervimetJashtëAfatitToolStripMenuItem.Text = "Rezervimet jashtë afatit";
            this.rezervimetJashtëAfatitToolStripMenuItem.Click += new System.EventHandler(this.rezervimetJashtëAfatitToolStripMenuItem_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.button1);
            this.panelEx1.Location = new System.Drawing.Point(12, 133);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(150, 60);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sot";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 17);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRezervime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.barLeftDockSite);
            this.Controls.Add(this.barRightDockSite);
            this.Controls.Add(this.barTopDockSite);
            this.Controls.Add(this.barBottomDockSite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rezervimet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRezervime_Load);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleRezervimet)).EndInit();
            this.cmShtoRezervim.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
        private DevComponents.DotNetBar.DockSite barBottomDockSite;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
        private DevComponents.DotNetBar.DockSite barLeftDockSite;
        private DevComponents.DotNetBar.DockSite barRightDockSite;
        private DevComponents.DotNetBar.DockSite barTopDockSite;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.Schedule.Schedule scheduleRezervimet;
        private Janus.Windows.Schedule.Calendar calendar;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmShtoRezervim;
        private System.Windows.Forms.ToolStripMenuItem toolStripShto;
        private System.Windows.Forms.ToolStripMenuItem modifikoRezerviminEZgjedhurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshiRezerviminEZgjedhurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervimetJashtëAfatitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnShtoREzervim;
        private System.Windows.Forms.LinkLabel lnModifiko;
        private System.Windows.Forms.LinkLabel lnFshi;
        private System.Windows.Forms.LinkLabel lnSkaduara;
    }
}