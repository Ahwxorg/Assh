using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GhostSwitch : CheckBox
{

    #region Variables

    private Timer AnimationTimer = new Timer { Interval = 1 };
    private GraphicsPath RoundedRectangle;
    private Graphics G;

    private Color enabledCheckedColor = Color.FromArgb(255, 230, 0);
    private Color disabledCheckedColor = Color.FromArgb(220, 190, 0);
    private Color enabledUnCheckedColor = Color.FromArgb(188, 191, 196);
    private Color disabledUnCheckedColor = Color.FromArgb(195, 196, 198);
    
    private double ButtonLocationX = 4.0d;

    #endregion

    #region  Properties

    [Category("Appearance")]
    public Color EnabledCheckedColor
    {
        get { return enabledCheckedColor; }
        set
        {
            enabledCheckedColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color DisabledCheckedColor
    {
        get { return disabledCheckedColor; }
        set
        {
            disabledCheckedColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color EnabledUnCheckedColor
    {
        get { return enabledUnCheckedColor; }
        set
        {
            enabledUnCheckedColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color DisabledUnCheckedColor
    {
        get { return disabledUnCheckedColor; }
        set
        {
            disabledUnCheckedColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Events

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        AnimationTimer.Start();
    }

    protected override void OnResize(EventArgs e)
    {
        Height = 19; 
        Width = 47;
        
        RoundedRectangle = new GraphicsPath();
        int radius = 10;

        RoundedRectangle.AddArc(4, 1, radius + 3, radius + 3, 180, 90);
        RoundedRectangle.AddArc(Width - 25, 1, radius + 3, radius + 3, -90, 90);
        RoundedRectangle.AddArc(Width - 25, Height - 15, radius + 3, radius + 3, 0, 90);
        RoundedRectangle.AddArc(4, Height - 15, radius + 3, radius + 3, 90, 90);

        RoundedRectangle.CloseAllFigures();
        Invalidate(); 
    }

    private void AnimationTick(object sender, EventArgs e)
    {
        if (Checked)
        {
            if (ButtonLocationX <= 19)
            {
                ButtonLocationX += (19 - ButtonLocationX) / 5;
                Invalidate();
            }
        }
        else
        {
            if (ButtonLocationX >= 4)
            {
                ButtonLocationX += (4 - ButtonLocationX) / 5;
                Invalidate();
            }
        }
    }

    #endregion

    public GhostSwitch()
    {
        Height = 19;
        Width = 47;
        DoubleBuffered = true;
        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        G = e.Graphics;
        G.SmoothingMode = SmoothingMode.AntiAlias;
        G.Clear(Parent.BackColor);

        G.FillPath(new SolidBrush(Color.FromArgb(115, Enabled ? Checked ? enabledCheckedColor : enabledUnCheckedColor : Checked ? disabledCheckedColor : disabledUnCheckedColor)), RoundedRectangle);
        G.DrawPath(new Pen(Color.FromArgb(50, Enabled ? Checked ? enabledCheckedColor : enabledUnCheckedColor : Checked ? disabledCheckedColor : disabledUnCheckedColor)), RoundedRectangle);

        G.FillEllipse(new SolidBrush(Enabled ? Checked ? enabledCheckedColor : Color.White : Checked ? disabledCheckedColor : disabledUnCheckedColor), (float)ButtonLocationX, 1, 16, 16); 
    }

}

