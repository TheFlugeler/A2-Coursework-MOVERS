using System.Drawing.Drawing2D;

namespace CustControlLib;

public partial class CustomPanel : Panel
{
    private int borderWidth = 0;
    private int borderRadius = 40;
    private Color borderColor = Color.Black;

    public int BorderWidth { get => borderWidth; set => borderWidth = value; }
    public int BorderRadius
    {
        get => borderRadius;
        set
        {
            int min = Width < Height ? Width : Height;
            if (value <= borderRadius) borderRadius = value;
            else borderRadius = min;
        }
    }
    public Color BorderColor { get => borderColor; set => borderColor = value; }

    public CustomPanel()
    {
        InitializeComponent();
        Size = new Size(150, 40);
        BackColor = Color.White;
        ForeColor = Color.Black;
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        RectangleF surface = new(0, 0, Width, Height);
        RectangleF border = new(0, 0, Width, Height);

        if (BorderRadius > 2)
        {
            using (GraphicsPath pathSurface = ControlTool.GetRoundedRectangle(surface, BorderRadius))
            using (GraphicsPath pathBorder = ControlTool.GetRoundedRectangle(border, BorderRadius + 2))
            using (Pen penSurface = new(Parent.BackColor, 1))
            using (Pen penBorder = new(BorderColor, BorderWidth + 1))
            {
                Region = new(pathSurface);

                penBorder.Alignment = PenAlignment.Inset;
                if (BorderWidth >= 1) pe.Graphics.DrawPath(penBorder, pathBorder);

                pe.Graphics.DrawPath(penSurface, pathSurface);
            }
        }
        else
        {
            Region = new(surface);
            if (BorderWidth >= 1)
            {
                using (Pen penBorder = new(BorderColor, BorderWidth))
                {
                    pe.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                }
            }
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
    }

    private void Container_BackColorChanged(object sender, EventArgs e)
    {
        if (DesignMode) Invalidate();
    }
}
