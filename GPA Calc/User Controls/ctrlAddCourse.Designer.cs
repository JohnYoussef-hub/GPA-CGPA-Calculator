﻿namespace GPA_Calc.User_Controls
{
    partial class ctrlAddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddCourse));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drpHours = new Bunifu.UI.WinForms.BunifuDropdown();
            this.drpGrade = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.drpSemester = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtCourseName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.lblMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMain.Font = new System.Drawing.Font("Couture", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.lblMain.Location = new System.Drawing.Point(312, 23);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(213, 29);
            this.lblMain.TabIndex = 4;
            this.lblMain.Text = "Add Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Cocogoose ProTrial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(241, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Cocogoose ProTrial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(352, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course Hours:";
            // 
            // drpHours
            // 
            this.drpHours.BackColor = System.Drawing.Color.Transparent;
            this.drpHours.BackgroundColor = System.Drawing.Color.White;
            this.drpHours.BorderColor = System.Drawing.Color.Silver;
            this.drpHours.BorderRadius = 1;
            this.drpHours.Color = System.Drawing.Color.Silver;
            this.drpHours.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpHours.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpHours.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drpHours.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpHours.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drpHours.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drpHours.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpHours.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drpHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpHours.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpHours.FillDropDown = true;
            this.drpHours.FillIndicator = false;
            this.drpHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpHours.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.drpHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.drpHours.FormattingEnabled = true;
            this.drpHours.Icon = null;
            this.drpHours.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpHours.IndicatorColor = System.Drawing.Color.Gray;
            this.drpHours.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpHours.ItemBackColor = System.Drawing.Color.White;
            this.drpHours.ItemBorderColor = System.Drawing.Color.White;
            this.drpHours.ItemForeColor = System.Drawing.Color.Black;
            this.drpHours.ItemHeight = 26;
            this.drpHours.ItemHighLightColor = System.Drawing.Color.SlateGray;
            this.drpHours.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drpHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.drpHours.ItemTopMargin = 3;
            this.drpHours.Location = new System.Drawing.Point(535, 167);
            this.drpHours.Name = "drpHours";
            this.drpHours.Size = new System.Drawing.Size(81, 32);
            this.drpHours.TabIndex = 3;
            this.drpHours.Text = null;
            this.drpHours.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpHours.TextLeftMargin = 5;
            // 
            // drpGrade
            // 
            this.drpGrade.BackColor = System.Drawing.Color.Transparent;
            this.drpGrade.BackgroundColor = System.Drawing.Color.White;
            this.drpGrade.BorderColor = System.Drawing.Color.Silver;
            this.drpGrade.BorderRadius = 1;
            this.drpGrade.Color = System.Drawing.Color.Silver;
            this.drpGrade.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpGrade.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpGrade.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drpGrade.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpGrade.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drpGrade.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drpGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpGrade.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drpGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpGrade.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpGrade.FillDropDown = true;
            this.drpGrade.FillIndicator = false;
            this.drpGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpGrade.Font = new System.Drawing.Font("CocogooseProTrial Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.drpGrade.FormattingEnabled = true;
            this.drpGrade.Icon = null;
            this.drpGrade.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpGrade.IndicatorColor = System.Drawing.Color.Gray;
            this.drpGrade.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpGrade.ItemBackColor = System.Drawing.Color.White;
            this.drpGrade.ItemBorderColor = System.Drawing.Color.White;
            this.drpGrade.ItemForeColor = System.Drawing.Color.Black;
            this.drpGrade.ItemHeight = 26;
            this.drpGrade.ItemHighLightColor = System.Drawing.Color.SlateGray;
            this.drpGrade.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drpGrade.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "F"});
            this.drpGrade.ItemTopMargin = 3;
            this.drpGrade.Location = new System.Drawing.Point(733, 167);
            this.drpGrade.Name = "drpGrade";
            this.drpGrade.Size = new System.Drawing.Size(81, 32);
            this.drpGrade.TabIndex = 4;
            this.drpGrade.Text = null;
            this.drpGrade.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpGrade.TextLeftMargin = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Cocogoose ProTrial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(639, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grade:";
            // 
            // drpSemester
            // 
            this.drpSemester.BackColor = System.Drawing.Color.Transparent;
            this.drpSemester.BackgroundColor = System.Drawing.Color.White;
            this.drpSemester.BorderColor = System.Drawing.Color.Silver;
            this.drpSemester.BorderRadius = 1;
            this.drpSemester.Color = System.Drawing.Color.Silver;
            this.drpSemester.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drpSemester.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpSemester.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drpSemester.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drpSemester.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drpSemester.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drpSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drpSemester.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drpSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpSemester.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpSemester.FillDropDown = true;
            this.drpSemester.FillIndicator = false;
            this.drpSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpSemester.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.drpSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.drpSemester.FormattingEnabled = true;
            this.drpSemester.Icon = null;
            this.drpSemester.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpSemester.IndicatorColor = System.Drawing.Color.Gray;
            this.drpSemester.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drpSemester.ItemBackColor = System.Drawing.Color.White;
            this.drpSemester.ItemBorderColor = System.Drawing.Color.White;
            this.drpSemester.ItemForeColor = System.Drawing.Color.Black;
            this.drpSemester.ItemHeight = 26;
            this.drpSemester.ItemHighLightColor = System.Drawing.Color.SlateGray;
            this.drpSemester.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drpSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.drpSemester.ItemTopMargin = 3;
            this.drpSemester.Location = new System.Drawing.Point(246, 167);
            this.drpSemester.Name = "drpSemester";
            this.drpSemester.Size = new System.Drawing.Size(81, 32);
            this.drpSemester.TabIndex = 2;
            this.drpSemester.Text = null;
            this.drpSemester.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drpSemester.TextLeftMargin = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Cocogoose ProTrial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course Semester:";
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("CocogooseProTrial Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnAdd.IdleBorderRadius = 1;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(357, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 1;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnAdd.onHoverState.BorderRadius = 1;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnAdd.OnIdleState.BorderRadius = 1;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.btnAdd.OnPressedState.BorderRadius = 1;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(119, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Tag = "3";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.AcceptsReturn = false;
            this.txtCourseName.AcceptsTab = false;
            this.txtCourseName.AnimationSpeed = 200;
            this.txtCourseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCourseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCourseName.BackColor = System.Drawing.Color.Transparent;
            this.txtCourseName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCourseName.BackgroundImage")));
            this.txtCourseName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCourseName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCourseName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCourseName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCourseName.BorderRadius = 1;
            this.txtCourseName.BorderThickness = 1;
            this.txtCourseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCourseName.DefaultText = "";
            this.txtCourseName.FillColor = System.Drawing.Color.White;
            this.txtCourseName.HideSelection = true;
            this.txtCourseName.IconLeft = null;
            this.txtCourseName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseName.IconPadding = 10;
            this.txtCourseName.IconRight = null;
            this.txtCourseName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseName.Lines = new string[0];
            this.txtCourseName.Location = new System.Drawing.Point(428, 102);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCourseName.Modified = false;
            this.txtCourseName.Multiline = false;
            this.txtCourseName.Name = "txtCourseName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCourseName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCourseName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCourseName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCourseName.OnIdleState = stateProperties4;
            this.txtCourseName.Padding = new System.Windows.Forms.Padding(3);
            this.txtCourseName.PasswordChar = '\0';
            this.txtCourseName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCourseName.PlaceholderText = "Enter text";
            this.txtCourseName.ReadOnly = false;
            this.txtCourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseName.SelectedText = "";
            this.txtCourseName.SelectionLength = 0;
            this.txtCourseName.SelectionStart = 0;
            this.txtCourseName.ShortcutsEnabled = true;
            this.txtCourseName.Size = new System.Drawing.Size(158, 28);
            this.txtCourseName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCourseName.TabIndex = 1;
            this.txtCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseName.TextMarginBottom = 0;
            this.txtCourseName.TextMarginLeft = 3;
            this.txtCourseName.TextMarginTop = 0;
            this.txtCourseName.TextPlaceholder = "Enter text";
            this.txtCourseName.UseSystemPasswordChar = false;
            this.txtCourseName.WordWrap = true;
            // 
            // ctrlAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drpSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.drpGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drpHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ctrlAddCourse";
            this.Size = new System.Drawing.Size(854, 340);
            this.Load += new System.EventHandler(this.ctrlAddCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txtCourseName;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown drpHours;
        private Bunifu.UI.WinForms.BunifuDropdown drpGrade;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuDropdown drpSemester;
        private System.Windows.Forms.Label label5;
    }
}
