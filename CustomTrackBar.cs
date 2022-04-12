using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuckTiktok
{
    public class CustomTrackBar : TrackBar
    {
        public event PaintEventHandler PaintOver;

        public CustomTrackBar()
            : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.BackColor = Color.Black;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // WM_PAINT
            if (m.Msg == 0x0F)
            {
                using (Graphics lgGraphics = Graphics.FromHwndInternal(m.HWnd))
                    OnPaintOver(new PaintEventArgs(lgGraphics, this.ClientRectangle));
            }
        }

        protected virtual void OnPaintOver(PaintEventArgs e)
        {
            PaintOver?.Invoke(this, e);
            e.Graphics.DrawRectangle(Pens.Lime, 0, 0, this.Width - 1, this.Height - 1);
            // Paint over code here
        }
    }
}
