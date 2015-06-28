using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoParking.Models;

namespace AutoParking.Forms
{
    public partial class ParkingForm : Form
    {
        public ParkingForm()
        {
            InitializeComponent();
            DrawParking(pnlParking.CreateGraphics(), pnlParking.ClientSize);
        }

        private void DrawParking(Graphics g, Size size)
        {
            using (var db = new AutoContext())
            {
                var parking = db.Parkings.FirstOrDefault(p => p.Id == 1);
                var placeWidth = size.Width/parking.Height;
                var placeHeight = placeWidth;
                foreach (var p in db.ParkingPlaces.Where(p => p.ParkingId == parking.Id))
                {
                    g.DrawRectangle(GetPen(p),
                        GetRectangle(p, placeHeight, placeWidth));
                }
            }
        }

        private static Rectangle GetRectangle(ParkingPlace p, int placeHeight, int placeWidth)
        {
            const int offsetX = 8;
            const int offsetY = 8;
            return new Rectangle(
                (p.Column - 1) * placeHeight + offsetX, 
                (p.Row - 1) * placeWidth + offsetY, 
                placeWidth - offsetX, 
                placeHeight - offsetY);
        }

        private Pen GetPen(ParkingPlace parkingPlace)
        {
            if (parkingPlace.ParkingPlaceType == ParkingPlaceType.OnceOnly) return new Pen(Color.BlueViolet, 2);
            if (parkingPlace.ParkingPlaceType == ParkingPlaceType.Econom) return new Pen(Color.Green, 2);
            if (parkingPlace.ParkingPlaceType == ParkingPlaceType.Middle) return new Pen(Color.DarkOrange, 2);
            return new Pen(Color.DarkRed, 2);
        }

        private void pnlParking_Paint(object sender, PaintEventArgs e)
        {
            DrawParking(e.Graphics, pnlParking.ClientSize);
        }
    }
}
