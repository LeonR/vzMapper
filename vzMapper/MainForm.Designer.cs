/*
 * Created by SharpDevelop.
 * User: Leon
 * Date: 28/05/2013
 * Time: 07:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace vzMapper
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainPnl = new System.Windows.Forms.Panel();
			this.snapshotBtn = new System.Windows.Forms.Button();
			this.windowsCmb = new System.Windows.Forms.ComboBox();
			this.localePcb = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitTmi = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsTmi = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutTmi = new System.Windows.Forms.ToolStripMenuItem();
			this.mainPnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.localePcb)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPnl
			// 
			this.mainPnl.Controls.Add(this.snapshotBtn);
			this.mainPnl.Controls.Add(this.windowsCmb);
			this.mainPnl.Controls.Add(this.localePcb);
			this.mainPnl.Location = new System.Drawing.Point(12, 43);
			this.mainPnl.Name = "mainPnl";
			this.mainPnl.Size = new System.Drawing.Size(857, 499);
			this.mainPnl.TabIndex = 0;
			// 
			// snapshotBtn
			// 
			this.snapshotBtn.Location = new System.Drawing.Point(209, 2);
			this.snapshotBtn.Name = "snapshotBtn";
			this.snapshotBtn.Size = new System.Drawing.Size(75, 23);
			this.snapshotBtn.TabIndex = 2;
			this.snapshotBtn.Text = "Snap it!";
			this.snapshotBtn.UseVisualStyleBackColor = true;
			this.snapshotBtn.Click += new System.EventHandler(this.SnapshotBtnClick);
			// 
			// windowsCmb
			// 
			this.windowsCmb.FormattingEnabled = true;
			this.windowsCmb.Location = new System.Drawing.Point(3, 3);
			this.windowsCmb.Name = "windowsCmb";
			this.windowsCmb.Size = new System.Drawing.Size(200, 21);
			this.windowsCmb.TabIndex = 1;
			this.windowsCmb.DropDown += new System.EventHandler(this.WindowsCmbDropDown);
			this.windowsCmb.SelectedIndexChanged += new System.EventHandler(this.WindowsCmbSelectedIndexChanged);
			// 
			// localePcb
			// 
			this.localePcb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.localePcb.Location = new System.Drawing.Point(69, 80);
			this.localePcb.Name = "localePcb";
			this.localePcb.Size = new System.Drawing.Size(513, 288);
			this.localePcb.TabIndex = 0;
			this.localePcb.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(965, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitTmi});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitTmi
			// 
			this.exitTmi.Name = "exitTmi";
			this.exitTmi.Size = new System.Drawing.Size(92, 22);
			this.exitTmi.Text = "Exit";
			this.exitTmi.Click += new System.EventHandler(this.ExitTmiClick);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.optionsTmi});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// optionsTmi
			// 
			this.optionsTmi.Name = "optionsTmi";
			this.optionsTmi.Size = new System.Drawing.Size(125, 22);
			this.optionsTmi.Text = "Options...";
			this.optionsTmi.Click += new System.EventHandler(this.OptionsTmiClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutTmi});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutTmi
			// 
			this.aboutTmi.Name = "aboutTmi";
			this.aboutTmi.Size = new System.Drawing.Size(116, 22);
			this.aboutTmi.Text = "About...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(965, 554);
			this.Controls.Add(this.mainPnl);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "vzMapper";
			this.mainPnl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.localePcb)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem aboutTmi;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsTmi;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitTmi;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button snapshotBtn;
		private System.Windows.Forms.ComboBox windowsCmb;
		private System.Windows.Forms.PictureBox localePcb;
		private System.Windows.Forms.Panel mainPnl;
	}
}
