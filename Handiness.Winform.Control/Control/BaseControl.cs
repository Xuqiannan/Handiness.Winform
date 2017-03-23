using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Handiness.Winform;
namespace Handiness.Winform.Control
{
    public class BaseControl : System.Windows.Forms.Control
    {
        [Description("文本内容在当前字体与环境下的占用的大小（注意！当他大于控件的大小时，控件不会显示文字信息）")]
        public SizeF TextPixelSize { get; private set; }
        /// <summary>
        /// 开启鼠标穿透
        /// </summary>
        [Description("开启鼠标穿透")]
        public Boolean CanMousePenetrable { get; set; } = false;
        public BaseControl()
        {
            this.SetStyle(ControlStyles.Opaque, false);
            this.DoubleBuffered = true;
        }
        /// <summary>
        /// 绘制文字信息至指定区域，默认文字垂直位置居中，水平位置由参数<see cref="x"/>指定
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect"></param>
        /// <param name="x">若值为0 则文字水平也居中</param>
        protected virtual void DrawText(Graphics g, RectangleF vectorRect, Single x)
        {
            PointF offsex = new PointF(0, 0);
            if (x != 0)
            {
                vectorRect.Width = 0;
                offsex.X = x;
            }
            this.DrawText(g, vectorRect, offsex);
        }
        /// <summary>
        /// 在控件上绘制文字信息，此函数默认将文字绘制至区域中心,并根据偏移量调整位置
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect">承载文字的区域</param>
        /// <param name="offset">文字的偏移量</param>
        protected virtual void DrawText(Graphics g, RectangleF vectorRect, PointF offset)
        {
            SizeF textPixelSize = this.FetchTextPixelSize(g);
            this.TextPixelSize = textPixelSize;
            PointF textLocation = new PointF(0, 0);
            textLocation.X = vectorRect.Width != 0 ? (vectorRect.Width - textPixelSize.Width) / 2 : 0;
            textLocation.Y = vectorRect.Height != 0 ? (vectorRect.Height - textPixelSize.Height) / 2 : 0;
            if (!offset.IsEmpty)
            {
                textLocation.X += offset.X;
                textLocation.Y += offset.Y;
            }
            this.DrawText(g, textLocation.X, textLocation.Y);
        }
        protected virtual void DrawText(Graphics g, Single x, Single y)
        {
            if (!String.IsNullOrEmpty(this.Text))
            {
                Brush textBrush = new SolidBrush(this.ForeColor);
                g.DrawString(this.Text, this.Font, textBrush, x, y);
                textBrush.Dispose();
            }
        }
        protected virtual SizeF FetchTextPixelSize(Graphics g)
        {
            return g.MeasureString(this.Text, this.Font);
        }
        /// <summary>
        /// 在控件上绘制文字信息，此函数默认将文字绘制至区域中心，如果需要调整文字的位置，请使用其他重载
        /// </summary>
        /// <param name="g"></param>
        /// <param name="vectorRect">承载文字的区域</param>
        protected virtual void DrawText(Graphics g, RectangleF vectorRect)
        {
            this.DrawText(g, vectorRect, PointF.Empty);
        }
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            //让容器背景跟随父容器的背景颜色变化
            this.BackColor = this.Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }
        protected virtual void ReleaseBrush(params Brush[] brushs)
        {
            foreach (Brush brush in brushs)
            {
                brush.Dispose();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (this.CanMousePenetrable&&!this.DesignMode)
            {
                switch (m.Msg)
                {
                    case WMConstants.WM_MOUSEACTIVATE:
                    case WMConstants.WM_MOUSEFIRST:
                    case WMConstants.WM_MOUSEHOVER:
                    case WMConstants.WM_MOUSELAST:
                    case WMConstants.WM_MOUSELEAVE:
                    case WMConstants.WM_LBUTTONDOWN:
                    case WMConstants.WM_LBUTTONUP:
                    case WMConstants.WM_LBUTTONDBLCLK:
                    case WMConstants.WM_RBUTTONDOWN:
                    case WMConstants.WM_RBUTTONUP:
                    case WMConstants.WM_RBUTTONDBLCLK:
                    case WMConstants.WM_MBUTTONDOWN:
                    case WMConstants.WM_MBUTTONUP:
                    case WMConstants.WM_MBUTTONDBLCLK:
                    case WMConstants.WM_NCHITTEST:
                        {
                            //将返回值置为 -1 表示交由父控件处理
                            m.Result = (IntPtr)(-1);
                        }
                        break;
                    default:
                        {
                            base.WndProc(ref m);
                        }
                        break;
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
