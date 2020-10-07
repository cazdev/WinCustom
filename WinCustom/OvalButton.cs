using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class OvalButton : Button
{
    public OvalButton()
    {
        this.BackColor = Color.DarkGray;
    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        using (var gp = new GraphicsPath())
        {
            gp.AddEllipse(new Rectangle(0, 0, this.Width - 2, this.Height - 2));
            this.Region = new Region(gp);
        }
    }
}