using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikAnimasyonVize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bayrak çerçevesi noktaları
        private PointF[] NoktalarCerceve1 = new PointF[4];
        private PointF[] NoktalarCerceve2 = new PointF[4];
        private PointF[] NoktalarCerceve3 = new PointF[4];
        private PointF[] NoktalarCerceve4 = new PointF[4];
        private PointF[] NoktalarCerceve5 = new PointF[4];
        private PointF[] NoktalarCerceve6 = new PointF[4];

        //yıldız noktaları
        private PointF[] NoktalarYildiz1 = new PointF[4];
        private PointF[] NoktalarYildiz2 = new PointF[4];
        private PointF[] NoktalarYildiz3 = new PointF[4];
        private PointF[] NoktalarYildiz4 = new PointF[4];
        private PointF[] NoktalarYildiz5 = new PointF[4];
        private PointF[] NoktalarYildiz6 = new PointF[4];
        private PointF[] NoktalarYildiz7 = new PointF[4];
        private PointF[] NoktalarYildiz8 = new PointF[4];
        private PointF[] NoktalarYildiz9 = new PointF[4];
        private PointF[] NoktalarYildiz10 = new PointF[4];

        //hilal noktaları
        private PointF[] NoktalarHilal1 = new PointF[4];
        private PointF[] NoktalarHilal2 = new PointF[4];








        public static void Temizle(PointF[] noktalar)
        {
           noktalar[0].X = 0;
           noktalar[0].Y = 0;
           noktalar[1].X = 0;
           noktalar[1].Y = 0;
           noktalar[2].X = 0;
           noktalar[2].Y = 0;
           noktalar[3].X = 0;
           noktalar[3].Y = 0;
        }
        
        public static void bCiz(PointF[] noktalar,float n1,float n2,float n3,float n4,float n5,float n6,float n7,float n8)
        {

            noktalar[0].X =n1 ;
            noktalar[0].Y =n2 ;
            noktalar[3].X =n3 ;
            noktalar[3].Y =n4 ;
            noktalar[1].X =n5 ;
            noktalar[1].Y =n6 ;
            noktalar[2].X =n7 ;
            noktalar[2].Y =n8 ;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Bayrak çerçevesii
            Temizle(NoktalarCerceve1);
            Temizle(NoktalarCerceve2);
            Temizle(NoktalarCerceve3);
            Temizle(NoktalarCerceve4);
            Temizle(NoktalarCerceve5);
            Temizle(NoktalarCerceve6);

            Temizle(NoktalarYildiz1);
            Temizle(NoktalarYildiz2);
            Temizle(NoktalarYildiz3);
            Temizle(NoktalarYildiz4);
            Temizle(NoktalarYildiz5);
            Temizle(NoktalarYildiz6);
            Temizle(NoktalarYildiz7);
            Temizle(NoktalarYildiz8);
            Temizle(NoktalarYildiz9);
            Temizle(NoktalarYildiz10);

            Temizle(NoktalarHilal1);
            Temizle(NoktalarHilal2);

            Cizim.Invalidate();
        }
        public static void yCiz(PointF[] nokta, float n1, float n2, float n3, float n4)
        {
            bCiz(nokta, n1, n2, n3, n4, n1, n2, n3, n4);
        }
        private void ÇİZ_Click(object sender, EventArgs e)
        {
            

            //sol yan çerçeve
            bCiz(NoktalarCerceve1, 40, 40, 40, 180, 40, 60, 40, 60);

            //sol üst çerçeve
            bCiz(NoktalarCerceve2, 40, 40, 180, 40, 50, 60, 170, 60);

            //sağ üst çerçeve
            bCiz(NoktalarCerceve3, 320, 40, 180, 40, 300, 20, 200, 20);

            //sağ yan çerçeve
            bCiz(NoktalarCerceve4, 320, 40, 320, 180, 320, 40, 320, 180);

            //sol alt çerçeve
            bCiz(NoktalarCerceve5, 40, 180, 180, 180, 60, 200, 160, 200);

            //sağ alt çerçeve 
            bCiz(NoktalarCerceve6, 320, 180, 180, 180, 300, 160, 200, 160);

            //y1
            yCiz(NoktalarYildiz1, 220, 60, 200, 90);

            //y2
            yCiz(NoktalarYildiz2, 220, 60, 240, 90);

            //y3
            yCiz(NoktalarYildiz3, 280, 90, 240, 90);

            //y4
            yCiz(NoktalarYildiz4, 280, 90, 250, 120);

            //y5
            yCiz(NoktalarYildiz5, 270, 150, 250, 120);

            //y6
            yCiz(NoktalarYildiz6, 270, 150, 220, 130);

            //y7
            yCiz(NoktalarYildiz7, 170, 150, 220, 130);

            //y8
            yCiz(NoktalarYildiz8, 170, 150, 190, 120);

            //y9
            yCiz(NoktalarYildiz9, 160, 90, 190, 120);

            //10
            yCiz(NoktalarYildiz10, 160, 90, 200, 90);

            //hilal1
            bCiz(NoktalarHilal1, 120, 70, 120, 150, 50, 50, 50, 170);

            //hilal
            bCiz(NoktalarHilal2, 120, 70, 120, 150, 70, 70, 70, 150);



            Cizim.Invalidate();

        }

        private void Cizim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Cizim.BackColor);


            //hilal
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarHilal1[0], NoktalarHilal1[1], NoktalarHilal1[2], NoktalarHilal1[3]);
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarHilal2[0], NoktalarHilal2[1], NoktalarHilal2[2], NoktalarHilal2[3]);



            //çerçeve
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarCerceve1[0], NoktalarCerceve1[1], NoktalarCerceve1[2], NoktalarCerceve1[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarCerceve2[0], NoktalarCerceve2[1], NoktalarCerceve2[2], NoktalarCerceve2[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarCerceve3[0], NoktalarCerceve3[1], NoktalarCerceve3[2], NoktalarCerceve3[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarCerceve4[0], NoktalarCerceve4[1], NoktalarCerceve4[2], NoktalarCerceve4[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarCerceve5[0], NoktalarCerceve5[1], NoktalarCerceve5[2], NoktalarCerceve5[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarCerceve6[0], NoktalarCerceve6[1], NoktalarCerceve6[2], NoktalarCerceve6[3]);




            //yıldız
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                NoktalarYildiz1[0], NoktalarYildiz1[1], NoktalarYildiz1[2], NoktalarYildiz1[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz2[0], NoktalarYildiz2[1], NoktalarYildiz2[2], NoktalarYildiz2[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz3[0], NoktalarYildiz3[1], NoktalarYildiz3[2], NoktalarYildiz3[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz4[0], NoktalarYildiz4[1], NoktalarYildiz4[2], NoktalarYildiz4[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz5[0], NoktalarYildiz5[1], NoktalarYildiz5[2], NoktalarYildiz5[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz6[0], NoktalarYildiz6[1], NoktalarYildiz6[2], NoktalarYildiz6[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz7[0], NoktalarYildiz7[1], NoktalarYildiz7[2], NoktalarYildiz7[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz8[0], NoktalarYildiz8[1], NoktalarYildiz8[2], NoktalarYildiz8[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz9[0], NoktalarYildiz9[1], NoktalarYildiz9[2], NoktalarYildiz9[3]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,
                            NoktalarYildiz10[0], NoktalarYildiz10[1], NoktalarYildiz10[2], NoktalarYildiz10[3]);

        }
    }
}
