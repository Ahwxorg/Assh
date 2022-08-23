using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class GhostButton : Button
{

    #region Variables

    private Timer loop = new Timer();

    private Color disabledBackColor = Color.FromArgb(192, 192, 0);
    private Color backcolor = Color.FromArgb(255, 230, 0);

    private int roundRadius = 3;
    private ClickAnimationType clickAnimation = ClickAnimationType.Ripple;

    private List<Ripple> ripples = new List<Ripple>();
    private int rippleSpeed = 10;

    public enum ClickAnimationType
    {
        Blink,
        Ripple
    }

    #endregion

    #region Properties

    public Color Backcolor
    {
        get
        {
            return backcolor;
        }
        set
        {
            backcolor = value;
        }
    }

    [Browsable(false)]
    public override Color BackColor
    {
        get { return base.BackColor; }
        set { base.BackColor = value; }
    }


    public Color DisabledBackColor
    {
        get
        {
            return disabledBackColor;
        }
        set
        {
            disabledBackColor = value;
        }
    }

    public int RoundRadius
    {
        get
        {
            return roundRadius;
        }
        set
        {
            roundRadius = value;
        }
    }

    public int RippleSpeed
    {
        get
        {
            return rippleSpeed;
        }
        set
        {
            rippleSpeed = value;
        }
    }

    public ClickAnimationType ClickAnimation
    {
        get
        {
            return clickAnimation;
        }
        set
        {
            clickAnimation = value;
        }
    }

    #endregion

    #region Events

    protected async override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        int i = 0;
        while (i < 10) 
        {
            i++;
            backcolor = ChangeColorBrightness(backcolor, -1);
            await Task.Delay(1);
            Refresh();
        }
        Refresh();
    }

    protected async override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseEnter(e);
        int i = 0;
        while (i < 10)
        {
            i++;
            backcolor = ChangeColorBrightness(backcolor, 1);
            await Task.Delay(1);
            Refresh();
        }
        Refresh();
    }

    protected async override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseEnter(e);
        InvokeOnClick(this, EventArgs.Empty);
        if (clickAnimation == ClickAnimationType.Blink)
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                backcolor = ChangeColorBrightness(backcolor, -1);
                await Task.Delay(1);
                Refresh();
            }
            Refresh();
        } else if (ClickAnimation == ClickAnimationType.Ripple)
        {
            ripples.Add(new Ripple(e.X, e.Y, 0, 0, ChangeColorBrightness(backcolor, -50)));
        }
    }

    protected async override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseEnter(e);
        if (clickAnimation == ClickAnimationType.Blink)
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                backcolor = ChangeColorBrightness(backcolor, 1);
                await Task.Delay(1);
                Refresh();
            }
            Refresh();
        }
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x20;
            return cp;
        }
    }

    private void loop_tick(object sender, EventArgs e)
    {
        foreach (Ripple ripple in ripples.ToList())
        {
            ripple.Width += rippleSpeed;
            ripple.Height += rippleSpeed;
            if (ripple.BackColor.A > rippleSpeed)
            {
                ripple.BackColor = Color.FromArgb(ripple.BackColor.A - rippleSpeed, ripple.BackColor);
            } else
            {
                ripples.Remove(ripple);
            }
            Refresh();
        }
    }

    #endregion

    public GhostButton()
    {
        BackColor = Color.Transparent;
        ForeColor = Color.White;
        Size = new Size(135, 30);
        Font = new Font("Segoe UI", 10);
        FlatStyle = FlatStyle.Flat;
        loop.Tick += loop_tick;
        loop.Interval = 10;
        loop.Enabled = true;
        loop.Start();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.Clear(Parent.BackColor);
        g.SmoothingMode = SmoothingMode.AntiAlias;

        GraphicsPath RoundRect;
        if (roundRadius > 0)
        {
            RoundRect = CreateRoundRect(0, 0, Width - 1, Height - 1, roundRadius);
        }
        else
        {
            RoundRect = CreateRoundRect(-1, -1, Width + 1, Height + 1, 1);
        }

        Region region = new Region(RoundRect);
        g.FillPath(new SolidBrush(Enabled ? backcolor : disabledBackColor), RoundRect);
        g.DrawPath(new Pen(Enabled ? backcolor : disabledBackColor), RoundRect);
        g.SetClip(region, CombineMode.Replace);

        foreach (Ripple ripple in ripples)
        {
            g.FillEllipse(new SolidBrush(ripple.BackColor), ripple.X - ripple.Width / 2, ripple.Y - ripple.Height / 2, ripple.Width, ripple.Height);
        }

        Size TextSize = TextRenderer.MeasureText(Text, Font);
        if (TextAlign == ContentAlignment.TopLeft)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), 5, 5);
        }
        else if (TextAlign == ContentAlignment.TopCenter)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2 - TextSize.Width / 2, 5);
        }
        else if (TextAlign == ContentAlignment.TopRight)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), Width - TextSize.Width - 5, 5);
        }
        else if (TextAlign == ContentAlignment.MiddleLeft)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), 5, Height / 2 - TextSize.Height / 2);
        }
        else if (TextAlign == ContentAlignment.MiddleCenter)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2 - TextSize.Width / 2, Height / 2 - TextSize.Height / 2);
        }
        else if (TextAlign == ContentAlignment.MiddleRight)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), Width - TextSize.Width - 5, Height / 2 - TextSize.Height / 2);
        }
        else if (TextAlign == ContentAlignment.BottomLeft)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), 5, Height - TextSize.Height - 5);
        }
        else if (TextAlign == ContentAlignment.BottomCenter)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2 - TextSize.Width / 2, Height - TextSize.Height - 5);
        }
        else if (TextAlign == ContentAlignment.BottomRight)
        {
            g.DrawString(Text, Font, new SolidBrush(ForeColor), Width - TextSize.Width - 5, Height - TextSize.Height - 5);
        }
    }

    #region Functions

    public static GraphicsPath CreateRoundRect(float x, float y, float width, float height, float radius)
    {
        GraphicsPath gp = new GraphicsPath();
        gp.AddLine(x + radius, y, x + width - (radius * 2), y);
        gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);

        gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2));
        gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, radius * 2, 0, 90);

        gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height);
        gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90);

        gp.AddLine(x, y + height - (radius * 2), x, y + radius);
        gp.AddArc(x, y, radius * 2, radius * 2, 180, 90);

        gp.CloseFigure();
        return gp;
    }

    public static Color ChangeColorBrightness(Color color, int amount)
    {
        float red = color.R;
        float green = color.G;
        float blue = color.B;

        red += amount;
        green += amount;
        blue += amount;

        if (red > 255) red = 255;
        if (red < 0) red = 0;

        if (green > 255) green = 255;
        if (green < 0) green = 0;

        if (blue > 255) blue = 255;
        if (blue < 0) blue = 0;

        return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
    }

    #endregion

}

public class Ripple
{
    public int X;
    public int Y;
    public int Width;
    public int Height;
    public Color BackColor;

    public Ripple(int x, int y, int width, int height, Color backColor) 
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        BackColor = backColor;
    }

}