/*
 *
 * CMPG223 Project - G10 DVD Rentals
 * Date Created: 03/08/2024
 * Rohann Venter, 25130757
 * Jacques van Heerden, 35317906 
 * Francois Verster, 40723380
 * Stefan Venter, 39066894
 * Christo Prinsloo, 21052239
 *
 */

using System.Drawing;
using System.Windows.Forms;

namespace CMPG223_Group10_DVD_Rental
{
    internal class CustomRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(89, 60, 93)))
                {
                    e.Graphics.FillRectangle(brush, e.Item.ContentRectangle);
                }
            } else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
