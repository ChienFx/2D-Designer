using System;

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
            this.gifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolbarHolder = new System.Windows.Forms.ToolStripContainer();
            this.lbBorderValue = new System.Windows.Forms.Label();
            this.layerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSendForward = new System.Windows.Forms.Button();
            this.btnSendFront = new System.Windows.Forms.Button();
            this.btnSendBackward = new System.Windows.Forms.Button();
            this.btnSendBack = new System.Windows.Forms.Button();
            this.shapePickerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.btnHyperbole = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbMouseHover = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.btnHandView = new System.Windows.Forms.Button();
            this.btnLayer = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnFillBgPicker = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShapePicker = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.sliderBorderWeight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFillForePicker = new System.Windows.Forms.Button();
            this.btnBorderColorPicker = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLayerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringFowardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToBackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportShape = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportShapeToBMP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportToJPG = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gIFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImgDialog = new System.Windows.Forms.SaveFileDialog();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillPatternSelection = new _2DDesigner.FillPatternSelection();
            this.borderSelector = new _2DDesigner.BorderSelector();
            this.menu.SuspendLayout();
            this.toolbarHolder.ContentPanel.SuspendLayout();
            this.toolbarHolder.SuspendLayout();
            this.layerPanel.SuspendLayout();
            this.shapePickerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBorderWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.rightClickMenu.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(804, 24);
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
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newProjectToolStripMenuItem.Text = "&New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openProjectToolStripMenuItem.Text = "&Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMPToolStripMenuItem,
            this.iMGToolStripMenuItem,
            this.pNGToolStripMenuItem,
            this.gifToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // bMPToolStripMenuItem
            // 
            this.bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            this.bMPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.bMPToolStripMenuItem.Text = "BMP";
            this.bMPToolStripMenuItem.Click += new System.EventHandler(this.bMPToolStripMenuItem_Click);
            // 
            // iMGToolStripMenuItem
            // 
            this.iMGToolStripMenuItem.Name = "iMGToolStripMenuItem";
            this.iMGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.iMGToolStripMenuItem.Text = "JPEG";
            this.iMGToolStripMenuItem.Click += new System.EventHandler(this.iMGToolStripMenuItem_Click);
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // gifToolStripMenuItem
            // 
            this.gifToolStripMenuItem.Name = "gifToolStripMenuItem";
            this.gifToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.gifToolStripMenuItem.Text = "GIF";
            this.gifToolStripMenuItem.Click += new System.EventHandler(this.gifToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importToolStripMenuItem.Text = "&Import";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeProjectToolStripMenuItem.Text = "&Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
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
            // toolbarHolder
            // 
            // 
            // toolbarHolder.ContentPanel
            // 
            this.toolbarHolder.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolbarHolder.ContentPanel.Controls.Add(this.lbBorderValue);
            this.toolbarHolder.ContentPanel.Controls.Add(this.layerPanel);
            this.toolbarHolder.ContentPanel.Controls.Add(this.shapePickerPanel);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnDel);
            this.toolbarHolder.ContentPanel.Controls.Add(this.lbMouseHover);
            this.toolbarHolder.ContentPanel.Controls.Add(this.zoomLabel);
            this.toolbarHolder.ContentPanel.Controls.Add(this.zoomSlider);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnHandView);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnLayer);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnSaveAs);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnSave);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnOpenProject);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnNewProject);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnRotate);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnScale);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnRedo);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label6);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnUndo);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnFillBgPicker);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label5);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label4);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label3);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnShapePicker);
            this.toolbarHolder.ContentPanel.Controls.Add(this.fillPatternSelection);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnMove);
            this.toolbarHolder.ContentPanel.Controls.Add(this.borderSelector);
            this.toolbarHolder.ContentPanel.Controls.Add(this.sliderBorderWeight);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label1);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnFillForePicker);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnBorderColorPicker);
            this.toolbarHolder.ContentPanel.Controls.Add(this.btnZoom);
            this.toolbarHolder.ContentPanel.Controls.Add(this.label2);
            this.toolbarHolder.ContentPanel.Size = new System.Drawing.Size(804, 75);
            this.toolbarHolder.ContentPanel.Load += new System.EventHandler(this.toolbarHolder_ContentPanel_Load);
            this.toolbarHolder.ContentPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toolbarHolder_ContentPanel_MouseClick);
            this.toolbarHolder.ContentPanel.MouseLeave += new System.EventHandler(this.setMouseToMainBoard);
            this.toolbarHolder.ContentPanel.MouseHover += new System.EventHandler(this.setMouseToToolbar);
            this.toolbarHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarHolder.Location = new System.Drawing.Point(0, 24);
            this.toolbarHolder.Name = "toolbarHolder";
            this.toolbarHolder.Size = new System.Drawing.Size(804, 100);
            this.toolbarHolder.TabIndex = 4;
            this.toolbarHolder.Text = "toolStripContainer1";
            this.toolbarHolder.Click += new System.EventHandler(this.toolbarHolder_Click);
            this.toolbarHolder.MouseLeave += new System.EventHandler(this.setMouseToMainBoard);
            this.toolbarHolder.MouseHover += new System.EventHandler(this.setMouseToToolbar);
            // 
            // lbBorderValue
            // 
            this.lbBorderValue.AutoSize = true;
            this.lbBorderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbBorderValue.Location = new System.Drawing.Point(464, 62);
            this.lbBorderValue.Name = "lbBorderValue";
            this.lbBorderValue.Size = new System.Drawing.Size(27, 13);
            this.lbBorderValue.TabIndex = 13;
            this.lbBorderValue.Text = "2 px";
            // 
            // layerPanel
            // 
            this.layerPanel.AutoScroll = true;
            this.layerPanel.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.layerPanel.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.layerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.layerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layerPanel.Controls.Add(this.btnSendForward);
            this.layerPanel.Controls.Add(this.btnSendFront);
            this.layerPanel.Controls.Add(this.btnSendBackward);
            this.layerPanel.Controls.Add(this.btnSendBack);
            this.layerPanel.Location = new System.Drawing.Point(262, 0);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.layerPanel.Size = new System.Drawing.Size(132, 113);
            this.layerPanel.TabIndex = 26;
            this.layerPanel.Visible = false;
            this.layerPanel.Leave += new System.EventHandler(this.layerPanel_Leave);
            // 
            // btnSendForward
            // 
            this.btnSendForward.BackColor = System.Drawing.Color.Transparent;
            this.btnSendForward.BackgroundImage = global::_2DDesigner.Properties.Resources.send_to_froward;
            this.btnSendForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendForward.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendForward.Location = new System.Drawing.Point(3, 3);
            this.btnSendForward.Margin = new System.Windows.Forms.Padding(1);
            this.btnSendForward.Name = "btnSendForward";
            this.btnSendForward.Size = new System.Drawing.Size(118, 24);
            this.btnSendForward.TabIndex = 18;
            this.btnSendForward.Text = "      Bring To Forward";
            this.btnSendForward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendForward.UseVisualStyleBackColor = false;
            this.btnSendForward.Click += new System.EventHandler(this.btnSendForward_Click);
            // 
            // btnSendFront
            // 
            this.btnSendFront.BackColor = System.Drawing.Color.Transparent;
            this.btnSendFront.BackgroundImage = global::_2DDesigner.Properties.Resources.send_to_front;
            this.btnSendFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendFront.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendFront.Location = new System.Drawing.Point(3, 29);
            this.btnSendFront.Margin = new System.Windows.Forms.Padding(1);
            this.btnSendFront.Name = "btnSendFront";
            this.btnSendFront.Size = new System.Drawing.Size(118, 24);
            this.btnSendFront.TabIndex = 22;
            this.btnSendFront.Text = "      Bring To Front";
            this.btnSendFront.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendFront.UseVisualStyleBackColor = false;
            this.btnSendFront.Click += new System.EventHandler(this.btnSendFront_Click);
            // 
            // btnSendBackward
            // 
            this.btnSendBackward.BackColor = System.Drawing.Color.Transparent;
            this.btnSendBackward.BackgroundImage = global::_2DDesigner.Properties.Resources.send_backward;
            this.btnSendBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendBackward.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendBackward.Location = new System.Drawing.Point(3, 55);
            this.btnSendBackward.Margin = new System.Windows.Forms.Padding(1);
            this.btnSendBackward.Name = "btnSendBackward";
            this.btnSendBackward.Size = new System.Drawing.Size(118, 24);
            this.btnSendBackward.TabIndex = 23;
            this.btnSendBackward.Text = "      Send Backward";
            this.btnSendBackward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendBackward.UseVisualStyleBackColor = false;
            this.btnSendBackward.Click += new System.EventHandler(this.btnSendBackward_Click);
            // 
            // btnSendBack
            // 
            this.btnSendBack.BackColor = System.Drawing.Color.Transparent;
            this.btnSendBack.BackgroundImage = global::_2DDesigner.Properties.Resources.send_to_back;
            this.btnSendBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendBack.Location = new System.Drawing.Point(3, 81);
            this.btnSendBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnSendBack.Name = "btnSendBack";
            this.btnSendBack.Size = new System.Drawing.Size(118, 24);
            this.btnSendBack.TabIndex = 25;
            this.btnSendBack.Text = "      Send To Back";
            this.btnSendBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendBack.UseVisualStyleBackColor = false;
            this.btnSendBack.Click += new System.EventHandler(this.btnSendBack_Click);
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
            this.shapePickerPanel.Location = new System.Drawing.Point(115, 9);
            this.shapePickerPanel.Name = "shapePickerPanel";
            this.shapePickerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.shapePickerPanel.Size = new System.Drawing.Size(121, 65);
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
            this.btnLine.MouseHover += new System.EventHandler(this.btnLine_MouseHover);
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
            // btnDel
            // 
            this.btnDel.BackgroundImage = global::_2DDesigner.Properties.Resources.trash_bold;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDel.Location = new System.Drawing.Point(186, 38);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(32, 32);
            this.btnDel.TabIndex = 36;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbMouseHover
            // 
            this.lbMouseHover.AutoSize = true;
            this.lbMouseHover.Location = new System.Drawing.Point(9, 79);
            this.lbMouseHover.Name = "lbMouseHover";
            this.lbMouseHover.Size = new System.Drawing.Size(35, 13);
            this.lbMouseHover.TabIndex = 29;
            this.lbMouseHover.Text = "label7";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
            this.zoomLabel.Location = new System.Drawing.Point(301, 85);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(33, 13);
            this.zoomLabel.TabIndex = 35;
            this.zoomLabel.Text = "100%";
            // 
            // zoomSlider
            // 
            this.zoomSlider.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zoomSlider.LargeChange = 2;
            this.zoomSlider.Location = new System.Drawing.Point(300, 0);
            this.zoomSlider.Maximum = 20;
            this.zoomSlider.Minimum = 1;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomSlider.Size = new System.Drawing.Size(45, 92);
            this.zoomSlider.TabIndex = 34;
            this.zoomSlider.Value = 10;
            this.zoomSlider.Scroll += new System.EventHandler(this.zoomSlider_Scroll);
            this.zoomSlider.Leave += new System.EventHandler(this.zoomSlider_Leave);
            // 
            // btnHandView
            // 
            this.btnHandView.BackColor = System.Drawing.Color.Transparent;
            this.btnHandView.BackgroundImage = global::_2DDesigner.Properties.Resources.hand;
            this.btnHandView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHandView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHandView.Location = new System.Drawing.Point(9, 38);
            this.btnHandView.Margin = new System.Windows.Forms.Padding(1);
            this.btnHandView.Name = "btnHandView";
            this.btnHandView.Size = new System.Drawing.Size(32, 32);
            this.btnHandView.TabIndex = 33;
            this.btnHandView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHandView.UseVisualStyleBackColor = false;
            this.btnHandView.Click += new System.EventHandler(this.btnHandView_Click);
            this.btnHandView.MouseHover += new System.EventHandler(this.btnHandView_MouseHover);
            // 
            // btnLayer
            // 
            this.btnLayer.BackgroundImage = global::_2DDesigner.Properties.Resources.layer;
            this.btnLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLayer.Location = new System.Drawing.Point(224, 3);
            this.btnLayer.Name = "btnLayer";
            this.btnLayer.Size = new System.Drawing.Size(32, 32);
            this.btnLayer.TabIndex = 30;
            this.btnLayer.UseVisualStyleBackColor = true;
            this.btnLayer.Click += new System.EventHandler(this.btnLayer_Click);
            this.btnLayer.MouseHover += new System.EventHandler(this.btnLayer_MouseHover);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAs.BackgroundImage = global::_2DDesigner.Properties.Resources.icon_save_as;
            this.btnSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveAs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveAs.Location = new System.Drawing.Point(113, 2);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(32, 32);
            this.btnSaveAs.TabIndex = 29;
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            this.btnSaveAs.MouseHover += new System.EventHandler(this.btnSaveAs_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::_2DDesigner.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(79, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 28;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenProject.BackgroundImage = global::_2DDesigner.Properties.Resources.folder;
            this.btnOpenProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenProject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenProject.Location = new System.Drawing.Point(43, 2);
            this.btnOpenProject.Margin = new System.Windows.Forms.Padding(1);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(32, 32);
            this.btnOpenProject.TabIndex = 27;
            this.btnOpenProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenProject.UseVisualStyleBackColor = false;
            this.btnOpenProject.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            this.btnOpenProject.MouseHover += new System.EventHandler(this.btnOpenProject_MouseHover);
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.Transparent;
            this.btnNewProject.BackgroundImage = global::_2DDesigner.Properties.Resources.newFile;
            this.btnNewProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewProject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewProject.Location = new System.Drawing.Point(9, 2);
            this.btnNewProject.Margin = new System.Windows.Forms.Padding(1);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(32, 32);
            this.btnNewProject.TabIndex = 26;
            this.btnNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            this.btnNewProject.MouseHover += new System.EventHandler(this.btnNewProject_MouseHover);
            // 
            // btnRotate
            // 
            this.btnRotate.BackgroundImage = global::_2DDesigner.Properties.Resources.rotate;
            this.btnRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRotate.Location = new System.Drawing.Point(113, 38);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(32, 32);
            this.btnRotate.TabIndex = 25;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            this.btnRotate.MouseHover += new System.EventHandler(this.btnRotate_MouseHover);
            // 
            // btnScale
            // 
            this.btnScale.BackgroundImage = global::_2DDesigner.Properties.Resources.scale;
            this.btnScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScale.Location = new System.Drawing.Point(148, 38);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(32, 32);
            this.btnScale.TabIndex = 24;
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            this.btnScale.MouseHover += new System.EventHandler(this.btnScale_MouseHover);
            // 
            // btnRedo
            // 
            this.btnRedo.BackgroundImage = global::_2DDesigner.Properties.Resources.redo;
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRedo.Location = new System.Drawing.Point(186, 2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(32, 32);
            this.btnRedo.TabIndex = 23;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            this.btnRedo.MouseHover += new System.EventHandler(this.btnRedo_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Border Color";
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = global::_2DDesigner.Properties.Resources.undo;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUndo.Location = new System.Drawing.Point(148, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(32, 32);
            this.btnUndo.TabIndex = 22;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            this.btnUndo.MouseHover += new System.EventHandler(this.btnUndo_MouseHover);
            // 
            // btnFillBgPicker
            // 
            this.btnFillBgPicker.BackColor = System.Drawing.Color.Transparent;
            this.btnFillBgPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFillBgPicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFillBgPicker.Location = new System.Drawing.Point(659, 62);
            this.btnFillBgPicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnFillBgPicker.Name = "btnFillBgPicker";
            this.btnFillBgPicker.Size = new System.Drawing.Size(103, 24);
            this.btnFillBgPicker.TabIndex = 21;
            this.btnFillBgPicker.Text = " ";
            this.btnFillBgPicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFillBgPicker.UseVisualStyleBackColor = false;
            this.btnFillBgPicker.Click += new System.EventHandler(this.pickFillBgColor);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fill Background";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fill Foreground";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fill Pattern";
            // 
            // btnShapePicker
            // 
            this.btnShapePicker.BackColor = System.Drawing.Color.Transparent;
            this.btnShapePicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShapePicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShapePicker.Location = new System.Drawing.Point(79, 38);
            this.btnShapePicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnShapePicker.Name = "btnShapePicker";
            this.btnShapePicker.Size = new System.Drawing.Size(32, 32);
            this.btnShapePicker.TabIndex = 16;
            this.btnShapePicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShapePicker.UseVisualStyleBackColor = false;
            this.btnShapePicker.Click += new System.EventHandler(this.btnShapePicker_Click);
            this.btnShapePicker.MouseHover += new System.EventHandler(this.btnShapePicker_MouseHover);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Transparent;
            this.btnMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMove.BackgroundImage")));
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMove.Location = new System.Drawing.Point(43, 38);
            this.btnMove.Margin = new System.Windows.Forms.Padding(1);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(32, 32);
            this.btnMove.TabIndex = 14;
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            this.btnMove.MouseHover += new System.EventHandler(this.btnMove_MouseHover);
            // 
            // sliderBorderWeight
            // 
            this.sliderBorderWeight.LargeChange = 2;
            this.sliderBorderWeight.Location = new System.Drawing.Point(423, 68);
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
            this.label1.Location = new System.Drawing.Point(353, 12);
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
            this.btnFillForePicker.Location = new System.Drawing.Point(659, 35);
            this.btnFillForePicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnFillForePicker.Name = "btnFillForePicker";
            this.btnFillForePicker.Size = new System.Drawing.Size(103, 24);
            this.btnFillForePicker.TabIndex = 7;
            this.btnFillForePicker.Text = " ";
            this.btnFillForePicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFillForePicker.UseVisualStyleBackColor = false;
            this.btnFillForePicker.Click += new System.EventHandler(this.pickFillForeColor);
            // 
            // btnBorderColorPicker
            // 
            this.btnBorderColorPicker.BackColor = System.Drawing.Color.Transparent;
            this.btnBorderColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorderColorPicker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorderColorPicker.Location = new System.Drawing.Point(423, 37);
            this.btnBorderColorPicker.Margin = new System.Windows.Forms.Padding(1);
            this.btnBorderColorPicker.Name = "btnBorderColorPicker";
            this.btnBorderColorPicker.Size = new System.Drawing.Size(121, 22);
            this.btnBorderColorPicker.TabIndex = 2;
            this.btnBorderColorPicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorderColorPicker.UseVisualStyleBackColor = false;
            this.btnBorderColorPicker.Click += new System.EventHandler(this.pickBorderColor);
            // 
            // btnZoom
            // 
            this.btnZoom.BackgroundImage = global::_2DDesigner.Properties.Resources.zoom_in;
            this.btnZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZoom.Location = new System.Drawing.Point(262, 3);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(32, 32);
            this.btnZoom.TabIndex = 31;
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weight";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "lc";
            this.saveFileDialog.FileName = "project1";
            this.saveFileDialog.Filter = "2D Designner file (*.lc)|*.lc";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save As";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "2D Designner file (*.lc)|*.lc";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Open project";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ContextMenuStrip = this.rightClickMenu;
            this.pictureBox.Location = new System.Drawing.Point(3, 131);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 426);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseEnter += new System.EventHandler(this.setMouseToMainBoard);
            this.pictureBox.MouseLeave += new System.EventHandler(this.setMouseToToolbar);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformToolStripMenuItem,
            this.btnCopy,
            this.btnCut,
            this.btnPaste,
            this.btnDelItem,
            this.btnLayerItem,
            this.btnExportShape});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(145, 158);
            this.rightClickMenu.Text = "2D Designer";
            this.rightClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickMenu_Opening);
            // 
            // btnCopy
            // 
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopy.Size = new System.Drawing.Size(144, 22);
            this.btnCopy.Text = "&Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Name = "btnCut";
            this.btnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnCut.Size = new System.Drawing.Size(144, 22);
            this.btnCut.Text = "Cu&t";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnPaste.Size = new System.Drawing.Size(144, 22);
            this.btnPaste.Text = "P&aste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnDelItem
            // 
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(144, 22);
            this.btnDelItem.Text = "&Delete";
            this.btnDelItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnLayerItem
            // 
            this.btnLayerItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bringFowardToolStripMenuItem,
            this.bringToFrontToolStripMenuItem,
            this.sendBackwardToolStripMenuItem,
            this.sendToBackToolStripMenuItem1});
            this.btnLayerItem.Name = "btnLayerItem";
            this.btnLayerItem.Size = new System.Drawing.Size(144, 22);
            this.btnLayerItem.Text = "Layer";
            // 
            // bringFowardToolStripMenuItem
            // 
            this.bringFowardToolStripMenuItem.Name = "bringFowardToolStripMenuItem";
            this.bringFowardToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bringFowardToolStripMenuItem.Text = "Bring to foward";
            this.bringFowardToolStripMenuItem.Click += new System.EventHandler(this.btnSendForward_Click);
            // 
            // bringToFrontToolStripMenuItem
            // 
            this.bringToFrontToolStripMenuItem.Name = "bringToFrontToolStripMenuItem";
            this.bringToFrontToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bringToFrontToolStripMenuItem.Text = "Bring to front";
            this.bringToFrontToolStripMenuItem.Click += new System.EventHandler(this.btnSendFront_Click);
            // 
            // sendBackwardToolStripMenuItem
            // 
            this.sendBackwardToolStripMenuItem.Name = "sendBackwardToolStripMenuItem";
            this.sendBackwardToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sendBackwardToolStripMenuItem.Text = "Send backward";
            this.sendBackwardToolStripMenuItem.Click += new System.EventHandler(this.btnSendBackward_Click);
            // 
            // sendToBackToolStripMenuItem1
            // 
            this.sendToBackToolStripMenuItem1.Name = "sendToBackToolStripMenuItem1";
            this.sendToBackToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.sendToBackToolStripMenuItem1.Text = "Send to back";
            this.sendToBackToolStripMenuItem1.Click += new System.EventHandler(this.btnSendBack_Click);
            // 
            // btnExportShape
            // 
            this.btnExportShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportShapeToBMP,
            this.btnExportToJPG,
            this.pNGToolStripMenuItem1,
            this.gIFToolStripMenuItem1});
            this.btnExportShape.Name = "btnExportShape";
            this.btnExportShape.Size = new System.Drawing.Size(144, 22);
            this.btnExportShape.Text = "Export";
            // 
            // btnExportShapeToBMP
            // 
            this.btnExportShapeToBMP.Name = "btnExportShapeToBMP";
            this.btnExportShapeToBMP.Size = new System.Drawing.Size(107, 22);
            this.btnExportShapeToBMP.Text = "*.BMP";
            this.btnExportShapeToBMP.Click += new System.EventHandler(this.bMPShapeExport_Click);
            // 
            // btnExportToJPG
            // 
            this.btnExportToJPG.Name = "btnExportToJPG";
            this.btnExportToJPG.Size = new System.Drawing.Size(107, 22);
            this.btnExportToJPG.Text = "*.JPG";
            this.btnExportToJPG.Click += new System.EventHandler(this.iMGShapeExport_Click);
            // 
            // pNGToolStripMenuItem1
            // 
            this.pNGToolStripMenuItem1.Name = "pNGToolStripMenuItem1";
            this.pNGToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.pNGToolStripMenuItem1.Text = "*.PNG";
            this.pNGToolStripMenuItem1.Click += new System.EventHandler(this.pNGShapeExport_Click);
            // 
            // gIFToolStripMenuItem1
            // 
            this.gIFToolStripMenuItem1.Name = "gIFToolStripMenuItem1";
            this.gIFToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.gIFToolStripMenuItem1.Text = "*.GIF";
            this.gIFToolStripMenuItem1.Click += new System.EventHandler(this.gifShapeExport_Click);
            // 
            // saveImgDialog
            // 
            this.saveImgDialog.FileName = "picture01";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToolStripMenuItem,
            this.rotateToolStripMenuItem1,
            this.scaleToolStripMenuItem});
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.transformToolStripMenuItem.Text = "Transform";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moveToolStripMenuItem.Text = "&Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem1
            // 
            this.rotateToolStripMenuItem1.Name = "rotateToolStripMenuItem1";
            this.rotateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rotateToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rotateToolStripMenuItem1.Text = "&Rotate";
            this.rotateToolStripMenuItem1.Click += new System.EventHandler(this.rotateToolStripMenuItem1_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scaleToolStripMenuItem.Text = "&Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
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
            this.fillPatternSelection.Location = new System.Drawing.Point(659, 9);
            this.fillPatternSelection.Name = "fillPatternSelection";
            this.fillPatternSelection.Size = new System.Drawing.Size(103, 21);
            this.fillPatternSelection.TabIndex = 15;
            this.fillPatternSelection.SelectedIndexChanged += new System.EventHandler(this.fillPatternSelection1_SelectedIndexChanged);
            // 
            // borderSelector
            // 
            this.borderSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.borderSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderSelector.FormattingEnabled = true;
            this.borderSelector.IntegralHeight = false;
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
            7,
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7});
            this.borderSelector.Location = new System.Drawing.Point(423, 9);
            this.borderSelector.Name = "borderSelector";
            this.borderSelector.Size = new System.Drawing.Size(121, 21);
            this.borderSelector.TabIndex = 5;
            this.borderSelector.SelectedIndexChanged += new System.EventHandler(this.borderSelector_SelectedIndexChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.toolbarHolder);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "Form";
            this.Text = "2D Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolbarHolder.ContentPanel.ResumeLayout(false);
            this.toolbarHolder.ContentPanel.PerformLayout();
            this.toolbarHolder.ResumeLayout(false);
            this.toolbarHolder.PerformLayout();
            this.layerPanel.ResumeLayout(false);
            this.shapePickerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBorderWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.rightClickMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem gifToolStripMenuItem;
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
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenProject;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnLayer;
        private System.Windows.Forms.FlowLayoutPanel layerPanel;
        private System.Windows.Forms.Button btnSendForward;
        private System.Windows.Forms.Button btnSendFront;
        private System.Windows.Forms.Button btnSendBackward;
        private System.Windows.Forms.Button btnSendBack;
        private System.Windows.Forms.Button btnHandView;
        private System.Windows.Forms.TrackBar zoomSlider;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.Label lbMouseHover;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnPaste;
        private System.Windows.Forms.ToolStripMenuItem btnLayerItem;
        private System.Windows.Forms.ToolStripMenuItem bringFowardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringToFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendBackwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToBackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnExportShape;
        private System.Windows.Forms.ToolStripMenuItem btnExportShapeToBMP;
        private System.Windows.Forms.ToolStripMenuItem btnExportToJPG;
        private System.Windows.Forms.ToolStripMenuItem btnDelItem;
        private System.Windows.Forms.SaveFileDialog saveImgDialog;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gIFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
    }
}

