using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace FirstFormApp
{
	class RoundPicture : PictureBox
	{
		protected override void OnPaint(PaintEventArgs pe)
		{
			GraphicsPath grpath = new GraphicsPath();
			grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
			this.Region = new System.Drawing.Region(grpath);
			base.OnPaint(pe);
		}
	}
}
