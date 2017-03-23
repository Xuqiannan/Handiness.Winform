using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Handiness.Winform.Control
{
    public class Button : BaseControl
    {
        /// <summary>
        /// 是否处于等待状态
        /// </summary>
        [Description("是否处于等待状态，处于等待状态将不再触发点击事件")]
        public Boolean IsWaiting
        {
            get
            {
                return this._waitIndicator.IsRolled;
            }
            set
            {
                this._waitIndicator.Visible = value;
                this._waitIndicator.IsRolled = value;
            }
        }
       
        [Description("按钮的圆角类型")]
        public RoundStyle RoundStyle { get;set; }
        [Description("按钮正常时的颜色")]
        public Color NormalColor
        {
            get
            {
                return this._normalColor;
            }
            set
            {
                if (this._normalColor != value)
                {
                    this._normalColor = value;
                    this._currentColor = value;
                    this.Invalidate();
                }
            }
        }
        [Description("指针悬浮时按钮的颜色")]
        public Color HoverColor { get; set; } = Color.FromArgb(70, 200, 250);
        [Description("按钮被点击时的颜色")]
        public Color DownColor { get; set; } = Color.FromArgb(175, 175, 175);

   
        public WaitIndicator WaitIndicator { get; set; }
        /***********************/
        private Color _normalColor = Color.FromArgb(61, 195, 245);
        private Color _currentColor = Color.FromArgb(61, 195, 245);
        private Color _shadowColor = Color.FromArgb(150,175,175,175);
        private Single _shadowWidth = 2;
        private WaitIndicator _waitIndicator;
        public Button() : base()
        {
            this.Cursor = Cursors.Hand;
            this.ForeColor = Color.White;
            this._waitIndicator = new WaitIndicator();
            this._waitIndicator.Visible = false;
            this._waitIndicator.IsFollowParentBackColor = false;
            this._waitIndicator.CanMousePenetrable = true;
            this._waitIndicator.RollPartWidthPercent = 20;
            this.Controls.Add(this._waitIndicator);
            
        }
        protected override void OnResize(EventArgs e)
        {
            this._waitIndicator.Size = new Size(this.Height / 2, this.Height / 2);
            this._waitIndicator.Location = new Point((Int32)(this.Width*0.1), (this.Height - this._waitIndicator.Height) / 2);
            base.OnResize(e);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            this._waitIndicator.BackColor = this._currentColor;
            this._waitIndicator.InnerColor = this._currentColor;

            SizeF buttonSzie = new SizeF(this.Width - this._shadowWidth, this.Height - this._shadowWidth);
            Brush nrlBrush = new SolidBrush(this._currentColor);
            Brush shadowBrush = new SolidBrush(this._shadowColor);
            RectangleF buttonRect = new RectangleF(new PointF(0, 0), buttonSzie);
            RectangleF shadowRect = new RectangleF(new PointF(this._shadowWidth, this._shadowWidth), buttonSzie);
            Single textOffsetX = 0;
            if (this.IsWaiting)
            {
                textOffsetX = this._waitIndicator.Location.X + this._waitIndicator.Width;
            }

            g.FillRectangle(shadowBrush, shadowRect);
            g.FillRectangle(nrlBrush, buttonRect);

            this.DrawText(g, buttonRect, textOffsetX);
            //释放笔刷资源
            this.ReleaseBrush(nrlBrush, shadowBrush);
            base.OnPaint(pevent);
        }
        private void DrawRound(RoundStyle round, Graphics g)
        {
            switch (round)
            {
                default:
                case RoundStyle.All:
                    {
                        //Int32 raduis = 10;
                        //GraphicsPath path = new GraphicsPath();
                        //path.AddArc(0,0,raduis * 2, raduis * 2,180, 90);
                        //Brush brush = new SolidBrush(this.NormalColor);
                        //path.CloseFigure();
                        //g.FillPath(brush, path);
                   
                    }
                    break;
            }
        }


        protected override void OnMouseEnter(EventArgs e)
        {
                this._currentColor = this.HoverColor;
                this.Invalidate();
                base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
                this._currentColor = this.NormalColor;
                this.Invalidate();
                base.OnMouseLeave(e);
        }
        protected override void OnClick(EventArgs e)
        {
            if (!this.IsWaiting)
            {
                base.OnClick(e);
            }
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {

                this._currentColor = this.DownColor;
                this._waitIndicator.WaitIndicatorColor = this.NormalColor;
                this.Invalidate();
                base.OnMouseDown(mevent);

        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {

                this._currentColor = this.HoverColor;
                this._waitIndicator.WaitIndicatorColor = this.DownColor;
                this.Invalidate();
                base.OnMouseUp(mevent);

        }
    }
}
