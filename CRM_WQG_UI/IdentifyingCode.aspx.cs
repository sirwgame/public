﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CRM_WQG_UI
{
    public partial class IdentifyingCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tmp = RndNum(4);
            HttpCookie a = new HttpCookie("ImageV ", tmp);
            Response.Cookies.Add(a);
            this.ValidateCode(tmp);
        }
        private void ValidateCode(string VNum)
        {

            Bitmap Img = null;

            Graphics g = null;

            MemoryStream ms = null;

            int gheight = VNum.Length * 12;

            Img = new Bitmap(gheight, 25);

            g = Graphics.FromImage(Img);

    
            Random random = new Random();

            g.Clear(Color.White);

            for (int i = 0; i < 100; i++)
            {

                int x = random.Next(Img.Width);

                int y = random.Next(Img.Height);

                Img.SetPixel(x, y, Color.FromArgb(random.Next()));

            }


            Font f = new Font("Arial Black ", 12);

            SolidBrush s = new SolidBrush(Color.Blue);

            g.DrawString(VNum, f, s, 3, 3);

            ms = new MemoryStream();

            Img.Save(ms, ImageFormat.Jpeg);

            Response.ClearContent();

            Response.ContentType = "image/Jpeg ";

            Response.BinaryWrite(ms.ToArray());

            g.Dispose();
            Img.Dispose();
            HttpContext.Current.ApplicationInstance.CompleteRequest();

        }

        private string RndNum(int VcodeNum)
        {

            string Vchar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P" +

            ",Q,R,S,T,U,V,W,X,Y,Z"+"a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";

            string[] VcArray = Vchar.Split(new Char[] { ',' });

            string VNum = " ";
            int temp = -1;
            Random rand = new Random();

            for (int i = 1; i < VcodeNum + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));

                }
                int t = rand.Next(35);
                if (temp != -1 && temp == t)
                {
                    return RndNum(VcodeNum);

                }
                temp = t;
                VNum += VcArray[t];

            }

            return VNum;

        }
    }
}
