namespace _2DDesigner
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPickerFill = new System.Windows.Forms.ColorDialog();
            this.colorPickerBorder = new System.Windows.Forms.ColorDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolbarHolder = new System.Windows.Forms.ToolStripContainer();
            this.shapePickerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.btnHyperbole = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnShapePicker = new System.Windows.Forms.Button();
            this.fillPatternSelection = new _2DDesigner.FillPatternSelection();
            this.btnMove = new System.Windows.Forms.Button();
            this.borderSelector = new _2DDesigner.BorderSelector();
            this.lbBorderValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sliderBorderWeight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFillForePicker = new System.Windows.Forms.Button();
            this.btnBorderColorPicker = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFillBgPicker = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolbarHolder.ContentPanel.SuspendLayout();
            this.toolbarHolder.SuspendLayout();
            this.shapePickerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBorderWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.toolToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(977, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMPToolStripMenuItem,
            this.iMGToolStripMenuItem,
            this.pNGToolStripMenuItem,
            this.aIToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // bMPToolStripMenuItem
            // 
            this.bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            this.bMPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.bMPToolStripMenuItem.Text = "BMP";
            // 
            // iMGToolStripMenuItem
            // 
            this.iMGToolStripMenuItem.Name = "iMGToolStripMenuItem";
            this.iMGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.iMGToolStripMenuItem.Text = "IMG";
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pNGToolStripMenuItem.Text = "PNG";
            // 
            // aIToolStripMenuItem
            // 
            this.aIToolStripMenuItem.Name = "aIToolStripMenuItem";
            this.aIToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.aIToolStripMenuItem.Text = "AI";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolboxToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomInToolStripMenuItem1,
            this.fullScreenToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolboxToolStripMenuItem
            // 
            this.toolboxToolStripMenuItem.Name = "toolboxToolStripMenuItem";
            this.toolboxToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.toolboxToolStripMenuItem.Text = "Toolbox";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            // 
            // zoomInToolStripMenuItem1
            // 
            this.zoomInToolStripMenuItem1.Name = "zoomInToolStripMenuItem1";
            this.zoomInToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.zoomInToolStripMenuItem1.Text = "Zoom in";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.ungroupToolStripMenuItem,
            this.flipHorizontalToolStripMenuItem,
            this.flipVerticalToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.sendToForwardToolStripMenuItem,
            this.sendToBackToolStripMenuItem,
            this.sendToFrontToolStripMenuItem,
            this.sentToBackwardToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            this.toolToolStripMenuItem.Click += new System.EventHandler(this.toolToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // ungroupToolStripMenuItem
            // 
            this.ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem";
            this.ungroupToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ungroupToolStripMenuItem.Text = "Ungroup";
            this.ungroupToolStripMenuItem.Click += new System.EventHandler(this.ungroupToolStripMenuItem_Click);
            // 
            // flipHorizontalToolStripMenuItem
            // 
            this.flipHorizontalToolStripMenuItem.Name = "flipHorizontalToolStripMenuItem";
            this.flipHorizontalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.flipHorizontalToolStripMenuItem.Text = "Flip Horizontal";
            // 
            // flipVerticalToolStripMenuItem
            // 
            this.flipVerticalToolStripMenuItem.Name = "flipVerticalToolStripMenuItem";
            this.flipVerticalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.flipVerticalToolStripMenuItem.Text = "Flip Vertical";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // sendToForwardToolStripMenuItem
            // 
            this.sendToForwardToolStripMenuItem.Name = "sendToForwardToolStripMenuItem";
            this.sendToForwardToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sendToForwardToolStripMenuItem.Text = "Send to forward";
            // 
            // sendToBackToolStripMenuItem
            // 
            this.sendToBackToolStripMenuItem.Name = "sendToBackToolStripMenuItem";
            this.sendToBackToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sendToBackToolStripMenuItem.Text = "Send to back";
            // 
            // sendToFrontToolStripMenuItem
            // 
            this.sendToFrontToolStripMenuItem.Name = "sendToFrontToolStripMenuItem";
            this.sendToFrontToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sendToFrontToolStripMenuItem.Text = "Send to front";
            // 
            // sentToBackwardToolStripMenuItem
            // 
            this.sentToBackwardToolStripMenuItem.Name = "sentToBackwardToolStripMenuItem";
            this.sentToBackwardToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sentToBackwardToolStripMenuItem.Text = "Sent to backward";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // colorPickerFill
            // 
            this.colorPickerFill.AnyColor = true;
            this.colorPickerFill.Color = System.Drawing.Color.DarkRed;
            // 
            // colorPickerBorder
            // 
            this.colorPickerBorder.AnyColor = true;
            this.colorPickerBorder.Color = System.Drawing.Color.DarkRed;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(3, 142);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(784, 349);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toolbarHolder
            // 
            // 
            // toolbarHolder.ContentPanel
            // 
            this.toolbarHolder.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnFillBgPicker);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label5);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label4);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label3);
            this.toolbarHolder.ContentPanel.Controls.Add(this.shapePickerPanel);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnShapePicker);
            this.toolbarHolder.ContentPanel.Controls.Add(this.fillPatternSelection);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnMove);
            this.toolbarHolder.ContentPanel.Controls.Add(this.borderSelector);
            this.toolbarHolder.ContentPanel.Controls.Add(this.lbBorderValue);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label2);
            this.toolbarHolder.ContentPanel.Controls.Add(this.sliderBorderWeight);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label1);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnFillForePicker);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnBorderColorPicker);
            this.toolbarHolder.ContentPanel.Size = new System.Drawing.Size(784, 111);
            this.toolbarHolder.ContentPanel.Load += new System.EventHandler(this.toolbarHolder_ContentPanel_Load);
            this.toolbarHolder.ContentPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toolbarHolder_ContentPanel_MouseClick);
            this.toolbarHolder.Location = new System.Drawing.Point(3, 25);
            this.toolbarHolder.Name = "toolbarHolder";
            this.toolbarHolder.Size = new System.Drawing.Size(784, 111);
            this.toolbarHolder.TabIndex = 4;
            this.toolbarHolder.Text = "toolStripContainer1";
            this.toolbarHolder.Click += new System.EventHandler(this.toolbarHolder_Click);
            // 
            // shapePickerPanel
            // 
            this.shapePickerPanel.AutoScroll = true;
            this.shapePickerPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.shapePickerPanel.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.shapePickerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.shapePickerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapePickerPanel.Controls.Add(this.btnLine);
            this.shapePickerPanel.Controls.Add(this.btnRect);
            this.shapePickerPanel.Controls.Add(this.btnEllipse);
            this.shapePickerPanel.Controls.Add(this.btnCircle);
            this.shapePickerPanel.Controls.Add(this.btnParabola);
            this.shapePickerPanel.Controls.Add(this.btnHyperbole);
            this.shapePickerPanel.Controls.Add(this.btnSquare);
            this.shapePickerPanel.Controls.Add(this.btnTriangle);
            this.shapePickerPanel.Location = new System.Drawing.Point(77, 2);
            this.shapePickerPanel.Name = "shapePickerPanel";
            this.shapePickerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.shapePickerPanel.Size = new System.Drawing.Size(116, 65);
            this.shapePickerPanel.TabIndex = 17;
            this.shapePickerPanel.Visible = false;
            this.shapePickerPanel.Leave += new System.EventHandler(this.shapePickerPanel_Leave);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLine.Location = new System.Drawing.Point(6, 6);
            this.btnLine.Margin = new System.Windows.Forms.Padding(1);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(24, 24);
            this.btnLine.TabIndex = 18;
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRect
            // 
            this.btnRect.BackColor = System.Drawing.Color.Transparent;
            this.btnRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRect.BackgroundImage")));
            this.btnRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRect.Location = new System.Drawing.Point(32, 6);
            this.btnRect.Margin = new System.Windows.Forms.Padding(1);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(24, 24);
            this.btnRect.TabIndex = 19;
            this.btnRect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRect.UseVisualStyleBackColor = false;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.BackgroundImage")));
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEllipse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEllipse.Location = new System.Drawing.Point(58, 6);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(1);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(24, 24);
            this.btnEllipse.TabIndex = 20;
            this.btnEllipse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircle.BackgroundImage")));
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCircle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCircle.Location = new System.Drawing.Point(84, 6);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(1);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(24, 24);
            this.btnCircle.TabIndex = 24;
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnParabola
            // 
            this.btnParabola.BackColor = System.Drawing.Color.Transparent;
            this.btnParabola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnParabola.BackgroundImage")));
            this.btnParabola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnParabola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParabola.Location = new System.Drawing.Point(6, 32);
            this.btnParabola.Margin = new System.Windows.Forms.Padding(1);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Size = new System.Drawing.Size(24, 24);
            this.btnParabola.TabIndex = 22;
            this.btnParabola.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParabola.UseVisualStyleBackColor = false;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // btnHyperbole
            // 
            this.btnHyperbole.BackColor = System.Drawing.Color.Transparent;
            this.btnHyperbole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHyperbole.BackgroundImage")));
            this.btnHyperbole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHyperbole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHyperbole.Location = new System.Drawing.Point(32, 32);
            this.btnHyperbole.Margin = new System.Windows.Forms.Padding(1);
            this.btnHyperbole.Name = "btnHyperbole";
            this.btnHyperbole.Size = new System.Drawing.Size(24, 24);
            this.btnHyperbole.TabIndex = 23;
            this.btnHyperbole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHyperbole.UseVisualStyleBackColor = false;
            this.btnHyperbole.Click += new System.EventHandler(this.btnHyperbole_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Transparent;
            this.btnSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSquare.BackgroundImage")));
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSquare.Location = new System.Drawing.Point(58, 32);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(1);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(24, 24);
            this.btnSquare.TabIndex = 25;
            this.btnSquare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.Transparent;
            this.btnTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTriangle.BackgroundImage")));
            this.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTriangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTriangle.Location = new System.Drawing.Point(84, 32);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(1);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(24, 24);
            this.btnTriangle.TabIndex = 21;
            this.btnTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnShapePicker
            // 
            this.btnShapePicker.BackColor = System.Drawing.Color.Transparent;
            this.btnShapePicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShapePicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShapePicker.Location = new System.Drawing.Point(41, 2);
            this.btnShapePicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnShapePicker.Name = "btnShapePicker";
            this.btnShapePicker.Size = new System.Drawing.Size(32, 32);
            this.btnShapePicker.TabIndex = 16;
            this.btnShapePicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShapePicker.UseVisualStyleBackColor = false;
            this.btnShapePicker.Click += new System.EventHandler(this.btnShapePicker_Click);
            // 
            // fillPatternSelection
            // 
            this.fillPatternSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.fillPatternSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillPatternSelection.FormattingEnabled = true;
            this.fillPatternSelection.Items.AddRange(new object[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.fillPatternSelection.Location = new System.Drawing.Point(594, 9);
            this.fillPatternSelection.Name = "fillPatternSelection";
            this.fillPatternSelection.Size = new System.Drawing.Size(103, 21);
            this.fillPatternSelection.TabIndex = 15;
            this.fillPatternSelection.SelectedIndexChanged += new System.EventHandler(this.fillPatternSelection1_SelectedIndexChanged);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Transparent;
            this.btnMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMove.BackgroundImage")));
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMove.Location = new System.Drawing.Point(7, 2);
            this.btnMove.Margin = new System.Windows.Forms.Padding(1);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(32, 32);
            this.btnMove.TabIndex = 14;
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // borderSelector
            // 
            this.borderSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.borderSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderSelector.FormattingEnabled = true;
            this.borderSelector.Items.AddRange(new object[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7});
            this.borderSelector.Location = new System.Drawing.Point(358, 9);
            this.borderSelector.Name = "borderSelector";
            this.borderSelector.Size = new System.Drawing.Size(121, 21);
            this.borderSelector.TabIndex = 5;
            this.borderSelector.SelectedIndexChanged += new System.EventHandler(this.borderSelector_SelectedIndexChanged);
            // 
            // lbBorderValue
            // 
            this.lbBorderValue.AutoSize = true;
            this.lbBorderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbBorderValue.Location = new System.Drawing.Point(396, 35);
            this.lbBorderValue.Name = "lbBorderValue";
            this.lbBorderValue.Size = new System.Drawing.Size(27, 13);
            this.lbBorderValue.TabIndex = 13;
            this.lbBorderValue.Text = "2 px";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weight";
            // 
            // sliderBorderWeight
            // 
            this.sliderBorderWeight.LargeChange = 2;
            this.sliderBorderWeight.Location = new System.Drawing.Point(358, 41);
            this.sliderBorderWeight.Minimum = 1;
            this.sliderBorderWeight.Name = "sliderBorderWeight";
            this.sliderBorderWeight.Size = new System.Drawing.Size(114, 45);
            this.sliderBorderWeight.TabIndex = 11;
            this.sliderBorderWeight.Value = 2;
            this.sliderBorderWeight.Scroll += new System.EventHandler(this.sliderBorderWeight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Border Style";
            // 
            // btnFillForePicker
            // 
            this.btnFillForePicker.BackColor = System.Drawing.Color.Transparent;
            this.btnFillForePicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFillForePicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFillForePicker.Location = new System.Drawing.Point(594, 35);
            this.btnFillForePicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnFillForePicker.Name = "btnFillForePicker";
            this.btnFillForePicker.Size = new System.Drawing.Size(103, 24);
            this.btnFillForePicker.TabIndex = 7;
            this.btnFillForePicker.Text = " ";
            this.btnFillForePicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFillForePicker.UseVisualStyleBackColor = false;
            this.btnFillForePicker.Click += new System.EventHandler(this.pickFillColor);
            // 
            // btnBorderColorPicker
            // 
            this.btnBorderColorPicker.BackColor = System.Drawing.Color.Transparent;
            this.btnBorderColorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorderColorPicker.BackgroundImage")));
            this.btnBorderColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorderColorPicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorderColorPicker.Location = new System.Drawing.Point(291, 68);
            this.btnBorderColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnBorderColorPicker.Name = "btnBorderColorPicker";
            this.btnBorderColorPicker.Size = new System.Drawing.Size(61, 32);
            this.btnBorderColorPicker.TabIndex = 2;
            this.btnBorderColorPicker.Text = "Shape border";
            this.btnBorderColorPicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorderColorPicker.UseVisualStyleBackColor = false;
            this.btnBorderColorPicker.Click += new System.EventHandler(this.pickBorderColor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fill Pattern";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fill Foreground";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fill Background";
            // 
            // btnFillBgPicker
            // 
            this.btnFillBgPicker.BackColor = System.Drawing.Color.Transparent;
            this.btnFillBgPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFillBgPicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFillBgPicker.Location = new System.Drawing.Point(594, 62);
            this.btnFillBgPicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnFillBgPicker.Name = "btnFillBgPicker";
            this.btnFillBgPicker.Size = new System.Drawing.Size(103, 24);
            this.btnFillBgPicker.TabIndex = 21;
            this.btnFillBgPicker.Text = " ";
            this.btnFillBgPicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFillBgPicker.UseVisualStyleBackColor = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(977, 749);
            this.Controls.Add(this.toolbarHolder);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menu);
            this.Name = "Form";
            this.Text = "2D Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolbarHolder.ContentPanel.ResumeLayout(false);
            this.toolbarHolder.ContentPanel.PerformLayout();
            this.toolbarHolder.ResumeLayout(false);
            this.toolbarHolder.PerformLayout();
            this.shapePickerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sliderBorderWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ungroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentToBackwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorPickerFill;
        private System.Windows.Forms.ColorDialog colorPickerBorder;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripContainer toolbarHolder;
        private System.Windows.Forms.Button btnBorderColorPicker;
        private System.Windows.Forms.Button btnFillForePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sliderBorderWeight;
        private System.Windows.Forms.Label lbBorderValue;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BorderSelector borderSelector;
        private System.Windows.Forms.Button btnMove;
        private FillPatternSelection fillPatternSelection;
        private System.Windows.Forms.Button btnShapePicker;
        private System.Windows.Forms.FlowLayoutPanel shapePickerPanel;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnParabola;
        private System.Windows.Forms.Button btnHyperbole;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFillBgPicker;
    }
}

