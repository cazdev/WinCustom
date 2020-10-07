using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CustomCheckBox : CheckBox
{
    public CustomCheckBox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        Padding = new Padding(6);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        this.OnPaintBackground(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using (var path = new GraphicsPath())
        {
            var d = Padding.All;
            var r = this.Height - 2 * d;
            path.AddArc(d, d, r, r, 90, 180);
            path.AddArc(this.Width - r - d, d, r, r, -90, 180);
            path.CloseFigure();
            e.Graphics.FillPath(Checked ? new SolidBrush(Color.FromArgb(50,50,50)) : new SolidBrush(Color.FromArgb(60, 60, 60)), path); ;
            r = Height - 1;
            var rect = Checked ? new Rectangle(Width - r - 1, 0, r, r)
                               : new Rectangle(0, 0, r, r);
            e.Graphics.FillEllipse(Checked ? new SolidBrush(Color.FromArgb(39, 174, 96)) : new SolidBrush(Color.FromArgb(192, 57, 43)), rect);
        }
    }
}
