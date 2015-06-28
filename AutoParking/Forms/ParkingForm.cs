using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AutoParking.Helper;
using AutoParking.Models;

namespace AutoParking.Forms
{
    public partial class ParkingForm : Form
    {
        private Parking _parking;

        public ParkingForm()
        {
            InitializeComponent();
            DrawParking(pnlParking.CreateGraphics(), pnlParking.ClientSize);
            InitGui();
            LoadParkingInfo();
        }

        private void LoadParkingInfo()
        {
            using (var db = new AutoContext())
            {
                _parking = db.Parkings.FirstOrDefault(p => p.Id == 1);
                edCost.Value = _parking.Cost;
                edInflation.Value = db.Inflations.FirstOrDefault(p => p.Year == DateTime.Now.Year).Value;
            }
        }

        private void InitGui()
        {
            lblVip.BackColor = GetColor(ParkingPlaceType.Vip);
            lblMiddle.BackColor = GetColor(ParkingPlaceType.Middle);
            lblEconom.BackColor = GetColor(ParkingPlaceType.Econom);
            lblOnceOnly.BackColor = GetColor(ParkingPlaceType.OnceOnly);
            lblFree.BackColor = GetBrushColor(ParkingPlaceStatus.Free);
            lblReserve.BackColor = GetBrushColor(ParkingPlaceStatus.Reservated);
            lblBusy.BackColor = GetBrushColor(ParkingPlaceStatus.Busy);
        }

        private Color GetColor(ParkingPlaceType parkingPlaceType)
        {
            if (parkingPlaceType == ParkingPlaceType.OnceOnly) return Color.BlueViolet;
            if (parkingPlaceType == ParkingPlaceType.Econom) return Color.Green;
            if (parkingPlaceType == ParkingPlaceType.Middle) return Color.DarkOrange;
            return Color.DarkRed;
        }

        private void DrawParking(Graphics g, Size size)
        {
            using (var db = new AutoContext())
            {
                var parking = db.Parkings.FirstOrDefault(p => p.Id == 1);
                var placeWidth = 60;
                var placeHeight = 90;
                foreach (var p in db.ParkingPlaces.Where(p => p.ParkingId == parking.Id))
                {
                    const int offset = 3;
                    Rectangle rectangle = GetRectangle(p, placeHeight, placeWidth);
                    g.DrawRectangle(GetPen(p, offset * 2), rectangle);
                    g.FillRectangle(GetBrush(p),
                        new Rectangle(new Point(rectangle.X + offset, rectangle.Y + offset),
                            new Size(rectangle.Width - offset * 2, rectangle.Height - offset * 2)));
                    p.ParkingPlaceStatus = ParkingPlaceStatus.Reservated;
                    if (p.ParkingPlaceStatus != ParkingPlaceStatus.Free)
                    {
                        g.DrawImage(GetImage(p),
                            new Point(rectangle.Left + offset*2, rectangle.Top + offset*2));
                    }
                }
            }
        }

        private static Image GetImage(ParkingPlace parkingPlace)
        {
            if (parkingPlace.ParkingPlaceStatus == ParkingPlaceStatus.Reservated)
                return Image.FromFile("images/reservecar.png");
            return Image.FromFile("images/busycar.png");
        }

        private Brush GetBrush(ParkingPlace parkingPlace)
        {
            return new SolidBrush(GetBrushColor(parkingPlace.ParkingPlaceStatus));
        }

        private Color GetBrushColor(ParkingPlaceStatus status)
        {
            if (status == ParkingPlaceStatus.Busy) return Color.Red;
            if (status == ParkingPlaceStatus.Reservated) return Color.DarkGray;
            return Color.White;
        }

        private static Rectangle GetRectangle(ParkingPlace p, int placeHeight, int placeWidth)
        {
            const int offsetX = 10;
            const int offsetY = 10;
            return new Rectangle(
                (p.Column - 1) * placeWidth + offsetX, 
                (p.Row - 1) * placeHeight + offsetY, 
                placeWidth - offsetX, 
                placeHeight - offsetY);
        }

        private Pen GetPen(ParkingPlace parkingPlace, int thickness)
        {
            return new Pen(GetColor(parkingPlace.ParkingPlaceType), thickness);
        }

        private void pnlParking_Paint(object sender, PaintEventArgs e)
        {
            DrawParking(e.Graphics, pnlParking.ClientSize);
        }

        private void edCost_ValueChanged(object sender, EventArgs e)
        {
            using (var db = new AutoContext())
            {
                _parking.Cost = edCost.Value;
                db.Parkings.Attach(_parking);
                db.Entry(_parking).State = EntityState.Modified;
                DbHelper.Save(db);
            }
        }
    }
}
