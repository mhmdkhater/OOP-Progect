using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Progect
{
    using System.Drawing;
    using System.Windows.Forms;

    public class CirclePanel : Panel
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // بنمنع رسم الخلفية عشان نشيل اللون الأبيض
        }
    }
}
