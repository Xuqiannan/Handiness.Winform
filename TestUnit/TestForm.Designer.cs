namespace TestUnit
{
    partial class TestForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.scutcheon3 = new Handiness.Winform.Control.Scutcheon();
            this.button2 = new Handiness.Winform.Control.Button();
            this.button4 = new Handiness.Winform.Control.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 114);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // scutcheon3
            // 
            this.scutcheon3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scutcheon3.CanMousePenetrable = true;
            this.scutcheon3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scutcheon3.ForeColor = System.Drawing.Color.White;
            this.scutcheon3.Location = new System.Drawing.Point(209, 156);
            this.scutcheon3.Name = "scutcheon3";
            this.scutcheon3.ScutcheonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            this.scutcheon3.ScutcheonShape = Handiness.Winform.Control.ScutcheonShapeType.Circle;
            this.scutcheon3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.scutcheon3.ShadowWidth = 2;
            this.scutcheon3.Size = new System.Drawing.Size(93, 90);
            this.scutcheon3.TabIndex = 8;
            this.scutcheon3.Text = "scutcheon3";
            this.scutcheon3.Click += new System.EventHandler(this.scutcheon3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.CanMousePenetrable = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button2.IsWaiting = false;
            this.button2.Location = new System.Drawing.Point(454, 282);
            this.button2.Name = "button2";
            this.button2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.button2.RoundStyle = Handiness.Winform.Control.RoundStyle.All;
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "开始";
            this.button2.WaitIndicator = null;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.DoubleClick += new System.EventHandler(this.button2_DoubleClick);
            // 
            // button4
            // 
            this.button4.CanMousePenetrable = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button4.IsWaiting = false;
            this.button4.Location = new System.Drawing.Point(451, 203);
            this.button4.Name = "button4";
            this.button4.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.button4.RoundStyle = Handiness.Winform.Control.RoundStyle.Node;
            this.button4.Size = new System.Drawing.Size(142, 63);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.WaitIndicator = null;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(777, 441);
            this.Controls.Add(this.scutcheon3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestForm";
            this.Text = "ControlTestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.Click += new System.EventHandler(this.TestForm_Click);
            this.DoubleClick += new System.EventHandler(this.TestForm_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Handiness.Winform.Control.Button button2;
        private System.Windows.Forms.Button button3;
        private Handiness.Winform.Control.Scutcheon scutcheon3;
        private Handiness.Winform.Control.Button button4;
    }
}

