namespace NetDebugTool
{
    using DevComponents.DotNetBar;
    using DevComponents.DotNetBar.Rendering;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form1 : Office2007Form
    {
        private Bar bar1;
        private ButtonItem buttonItem_tcpc;
        private ButtonItem buttonItem_tcps;
        private ButtonItem buttonItem1;
        private IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private LabelItem labelItem1;
        private LabelItem labelItem2;
        private RibbonControl ribbonControl1;
        private ToolStripMenuItem 平ToolStripMenuItem;

        public Form1()
        {
            this.InitializeComponent();
            this.MyInitialize();
        }

        private void buttonItem_tcpc_Click(object sender, EventArgs e)
        {
            new TCPClinetForm { MdiParent = this }.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            new TCPServerForm { MdiParent = this }.Show();
        }

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {
            new UDPForm { MdiParent = this }.Show();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.TopMost = true;
            SplashForm.CloseSplash();
            base.TopMost = true;
            base.TopMost = false;
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new RibbonControl();
            this.buttonItem_tcps = new ButtonItem();
            this.labelItem1 = new LabelItem();
            this.buttonItem_tcpc = new ButtonItem();
            this.labelItem2 = new LabelItem();
            this.buttonItem1 = new ButtonItem();
            this.bar1 = new Bar();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.平ToolStripMenuItem = new ToolStripMenuItem();
            this.bar1.BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            base.SuspendLayout();
            this.ribbonControl1.Dock = DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new BaseItem[] { this.buttonItem_tcps, this.labelItem1, this.buttonItem_tcpc, this.labelItem2, this.buttonItem1 });
            this.ribbonControl1.KeyTipsFont = new Font("Tahoma", 7f);
            this.ribbonControl1.Location = new Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Black;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new Size(0x32e, 0x19);
            this.ribbonControl1.Style = eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            this.buttonItem_tcps.ImagePaddingHorizontal = 8;
            this.buttonItem_tcps.Name = "buttonItem_tcps";
            this.buttonItem_tcps.Text = "新建TCP Server";
            this.buttonItem_tcps.Click += new EventHandler(this.buttonItem1_Click);
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = " ";
            this.buttonItem_tcpc.ImagePaddingHorizontal = 8;
            this.buttonItem_tcpc.Name = "buttonItem_tcpc";
            this.buttonItem_tcpc.Text = "新建TCP Client";
            this.buttonItem_tcpc.Click += new EventHandler(this.buttonItem_tcpc_Click);
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = " ";
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "新建UDP";
            this.buttonItem1.Click += new EventHandler(this.buttonItem1_Click_1);
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = AccessibleRole.StatusBar;
            this.bar1.BarType = eBarType.StatusBar;
            this.bar1.Dock = DockStyle.Bottom;
            this.bar1.GrabHandleStyle = eGrabHandleStyle.ResizeHandle;
            this.bar1.Location = new Point(0, 0x1d4);
            this.bar1.Name = "bar1";
            this.bar1.Size = new Size(0x32e, 0x19);
            this.bar1.Stretch = true;
            this.bar1.Style = eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.平ToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(0x55, 0x1a);
            this.平ToolStripMenuItem.Name = "平ToolStripMenuItem";
            this.平ToolStripMenuItem.Size = new Size(0x54, 0x16);
            this.平ToolStripMenuItem.Text = "平";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x32e, 0x1ed);
            base.Controls.Add(this.bar1);
            base.Controls.Add(this.ribbonControl1);
            base.Icon = (Icon) resources.GetObject("$this.Icon");
            base.Name = "Form1";
            this.Text = "网络调试助手";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.Form1_Load);
            this.bar1.EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void MyInitialize()
        {
            base.IsMdiContainer = true;
        }
    }
}

