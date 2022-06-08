
namespace ip_cam
{
    partial class video
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.videoCapture1 = new VisioForge.Core.UI.WinForms.VideoView();
            this.State = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.Bullets_Result = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.videoCapture1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoCapture1
            // 
            this.videoCapture1.BackColor = System.Drawing.Color.Black;
            this.videoCapture1.Controls.Add(this.State);
            this.videoCapture1.Controls.Add(this.btnReload);
            this.videoCapture1.Controls.Add(this.btnFire);
            this.videoCapture1.Controls.Add(this.Bullets_Result);
            this.videoCapture1.Controls.Add(this.menuStrip1);
            this.videoCapture1.Location = new System.Drawing.Point(0, 0);
            this.videoCapture1.Margin = new System.Windows.Forms.Padding(4);
            this.videoCapture1.Name = "videoCapture1";
            this.videoCapture1.Size = new System.Drawing.Size(815, 519);
            this.videoCapture1.StatusOverlay = null;
            this.videoCapture1.TabIndex = 0;
            this.videoCapture1.Paint += new System.Windows.Forms.PaintEventHandler(this.videoCapture1_Paint);
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.BackColor = System.Drawing.Color.Black;
            this.State.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.ForeColor = System.Drawing.Color.Red;
            this.State.Location = new System.Drawing.Point(16, 6);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(223, 34);
            this.State.TabIndex = 7;
            this.State.Text = "State: Unworking";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(630, 466);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(118, 42);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.Black;
            this.btnFire.Location = new System.Drawing.Point(345, 466);
            this.btnFire.Margin = new System.Windows.Forms.Padding(4);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(109, 42);
            this.btnFire.TabIndex = 4;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // Bullets_Result
            // 
            this.Bullets_Result.AutoSize = true;
            this.Bullets_Result.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bullets_Result.ForeColor = System.Drawing.Color.Red;
            this.Bullets_Result.Location = new System.Drawing.Point(512, 6);
            this.Bullets_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bullets_Result.Name = "Bullets_Result";
            this.Bullets_Result.Size = new System.Drawing.Size(290, 34);
            this.Bullets_Result.TabIndex = 6;
            this.Bullets_Result.Text = "Number of bullets：15";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(58, 480);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(88, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(823, 373);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 40);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stop.ForeColor = System.Drawing.Color.Black;
            this.Btn_Stop.Location = new System.Drawing.Point(823, 307);
            this.Btn_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(118, 42);
            this.Btn_Stop.TabIndex = 9;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Return
            // 
            this.Btn_Return.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Return.ForeColor = System.Drawing.Color.Black;
            this.Btn_Return.Location = new System.Drawing.Point(823, 238);
            this.Btn_Return.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(118, 42);
            this.Btn_Return.TabIndex = 10;
            this.Btn_Return.Text = "Return";
            this.Btn_Return.UseVisualStyleBackColor = true;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(823, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(823, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.videoCapture1);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.Btn_Stop);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "video";
            this.Text = "基於機械手臂與視覺辨識實現 適用於遠端遙控槍塔之 彈藥自動再裝填系統";
            this.Load += new System.EventHandler(this.video_Load);
            this.videoCapture1.ResumeLayout(false);
            this.videoCapture1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VisioForge.Core.UI.WinForms.VideoView videoCapture1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label Bullets_Result;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

