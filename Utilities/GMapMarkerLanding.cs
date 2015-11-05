using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace MissionPlanner.Utilities
{
    [Serializable]
    public class GMapMarkerLanding: GMapMarker
    {
            public PointLatLng CenterPoint; 
            
            public Pen Pen = new Pen(Brushes.White, 2);

            public Color Color { get { return Pen.Color; } set { if (!initcolor.HasValue) initcolor = value; Pen.Color = value; } }

            public Color FillColor;
            
            Color? initcolor = null;

            public GMapMarker InnerMarker;

            public int RectWidth = 30; //m

            public int RectHeight = 30; //m

            public double LandingDirection = 0; //degrees

            public void ResetColor()
            {
                if (initcolor.HasValue)
                    Color = initcolor.Value;
                else
                    Color = Color.White;
            }

            public GMapMarkerLanding(PointLatLng p, int width, int height, Color Fillcolor, Color BorderColor, double Direction)
                : base(p)
            {
                Pen.DashStyle = DashStyle.Dash;
                Color = BorderColor;
                RectWidth = width;
                RectHeight = height;
                FillColor = Fillcolor;
                LandingDirection = Direction;
                CenterPoint = p;



                // do not forget set Size of the marker
                // if so, you shall have no event on it ;}
                Size = new System.Drawing.Size((int)RectWidth, (int)RectHeight);
                Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
            }

            public override void OnRender(Graphics g)
            {
                double width = (Overlay.Control.MapProvider.Projection.GetDistance(Overlay.Control.FromLocalToLatLng(0, 0), Overlay.Control.FromLocalToLatLng(Overlay.Control.Width, 0)) * 1000.0);
                double height = (Overlay.Control.MapProvider.Projection.GetDistance(Overlay.Control.FromLocalToLatLng(0, 0), Overlay.Control.FromLocalToLatLng(Overlay.Control.Height, 0)) * 1000.0);
                double m2pixelwidth = Overlay.Control.Width / width;
                double m2pixelheight = Overlay.Control.Height / height;


                Matrix temp = g.Transform;
                g.TranslateTransform(LocalPosition.X + RectHeight, LocalPosition.Y + RectWidth);
                g.RotateTransform(-Overlay.Control.Bearing);

                
                base.OnRender(g);
                if (RectHeight == 0 || Overlay.Control == null)
                    return;

                // if we have drawn it, then keep that color
                if (!initcolor.HasValue)
                    Color = Color.White;

                //wprad = 300;

                // undo autochange in mouse over
                // if (Pen.Color == Color.Blue)
                // Pen.Color = Color.White;
                

                //GPoint loc = new GPoint((int)(LocalPosition.X - (m2pixelwidth * RectWidth * 2)), LocalPosition.Y);// MainMap.FromLatLngToLocal(wpradposition);
                GPoint loc = new GPoint((int)(LocalPosition.X - (m2pixelwidth * RectWidth)), (int)(LocalPosition.Y - (m2pixelheight * RectHeight)));// MainMap.FromLatLngToLocal(wpradposition);

                double direction = LandingDirection;

                //mine
                int x = Offset.X - (int)(Math.Abs(loc.X - (int)LocalPosition.X) / 2);
                int y = Offset.Y - (int)(Math.Abs(loc.Y - (int)LocalPosition.Y) / 2);
                int widtharc = (int)Math.Abs(loc.X - LocalPosition.X);
                int heightarc = (int)Math.Abs(loc.Y - LocalPosition.Y);
                
                if (widtharc > 0)
                {
                    try
                    {
                        g.RotateTransform((int)LandingDirection);
                    }
                    catch { }

                    //draw circle
                    //g.DrawArc(Pen, new System.Drawing.Rectangle(x, y, widtharc, heightarc), 0, 360);
                    //g.FillPie(new SolidBrush(Color.FromArgb(25, FillColor)), x, y, widtharc, heightarc, 0, 360);

                    g.DrawRectangle(Pen, x, y, RectWidth * (int)m2pixelwidth, RectHeight * (int)m2pixelheight);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, FillColor)), x, y, RectWidth * (int)m2pixelwidth, RectHeight * (int)m2pixelheight);

                    g.Transform = temp;
                                   
                }
            }
        
    }
}
