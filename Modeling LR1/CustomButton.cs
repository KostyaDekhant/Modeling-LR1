using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Manager.RJControls
{
    public class CustomButton : Control
    {
        private Color _buttonColor = Color.FromArgb(255, 33, 40, 48);
        private Color _hoverColor = Color.FromArgb(255, 33, 40, 48);
        private Color _clickColor = Color.FromArgb(255, 33, 40, 48);
        private Color _textColor = Color.FromArgb(255, 233, 238, 245);
        private Color _borderColor = Color.FromArgb(255, 147, 154, 163);
        private bool _isHovering = false;
        private bool _isClicking = false;
        private int _cornerRadius = 0;
        private int _borderThickness = 0;
        private bool _enableAnimation = true;

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color HoverColor
        {
            get => _hoverColor;
            set
            {
                _hoverColor = value;
                Invalidate();
            }
        }

        public Color ClickColor
        {
            get => _clickColor;
            set
            {
                _clickColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                _borderThickness = Math.Max(0, value);
                Invalidate();
            }
        }

        public bool EnableAnimation
        {
            get => _enableAnimation;
            set => _enableAnimation = value;
        }

        public CustomButton()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.Size = new Size(100, 40);
            this.Font = new Font("Arial", 8, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawButton(e.Graphics);
        }

        /*private void DrawButton(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color currentColor = _buttonColor;

            if (_isClicking)
                currentColor = _clickColor;
            else if (_isHovering)
                currentColor = _hoverColor;

            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (Brush brush = new SolidBrush(currentColor))
            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                if (_cornerRadius > 0)
                {
                    GraphicsPath path = GetRoundedRectanglePath(rect, _cornerRadius);
                    g.FillPath(brush, path);
                    g.DrawPath(pen, path);
                }
                else
                {
                    g.FillRectangle(brush, rect);
                    g.DrawRectangle(pen, rect);
                }
            }

            using (Brush textBrush = new SolidBrush(_textColor))
            {
                SizeF textSize = g.MeasureString(Text, Font);
                PointF textPosition = new PointF(
                    (Width - textSize.Width) / 2,
                    (Height - textSize.Height) / 2);
                g.DrawString(Text, Font, textBrush, textPosition);
            }
        }
        */
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovering = true;
            if (_enableAnimation)
                Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovering = false;
            if (_enableAnimation)
                Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _isClicking = true;
            if (_enableAnimation)
                Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isClicking = false;
            if (_enableAnimation)
                Invalidate();
        }

        private bool _borderVisible = true;

        public bool BorderVisible
        {
            get => _borderVisible;
            set
            {
                _borderVisible = value;
                Invalidate();
            }
        }

        // ... (other methods remain the same)

        private void DrawButton(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color currentColor = _buttonColor;

            if (_isClicking)
                currentColor = _clickColor;
            else if (_isHovering)
                currentColor = _hoverColor;

            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (Brush brush = new SolidBrush(currentColor))
            {
                if (_cornerRadius > 0)
                {
                    GraphicsPath path = GetRoundedRectanglePath(rect, _cornerRadius);
                    g.FillPath(brush, path);
                    if (_borderVisible)
                    {
                        using (Pen pen = new Pen(_borderColor, _borderThickness))
                        {
                            g.DrawPath(pen, path);
                        }
                    }
                }
                else
                {
                    g.FillRectangle(brush, rect);
                    if (_borderVisible)
                    {
                        using (Pen pen = new Pen(_borderColor, _borderThickness))
                        {
                            g.DrawRectangle(pen, rect);
                        }
                    }
                }
            }

            using (Brush textBrush = new SolidBrush(_textColor))
            {
                SizeF textSize = g.MeasureString(Text, Font);
                PointF textPosition = new PointF(
                    (Width - textSize.Width) / 2,
                    (Height - textSize.Height) / 2);
                g.DrawString(Text, Font, textBrush, textPosition);
            }
        }
    
    }
}
