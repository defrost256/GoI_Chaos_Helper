using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace GoI_Chaos_Helper
{
    public partial class Form1 : Form
    {
        Color redBGmin = Color.FromArgb(110, 50, 50), redBGmax = Color.FromArgb(123, 57, 57);
        Color redFGmin = Color.FromArgb(138, 85, 85), redFGmax = Color.FromArgb(148, 102, 102);
        Color blueBGmin = Color.FromArgb(39, 77, 95), blueBGmax = Color.FromArgb(50, 82, 106);
        Color blueFGmin = Color.FromArgb(72, 105, 125), blueFGmax = Color.FromArgb(105, 122, 140);

        enum SearchState { FindRed, EndRed, FindBlue, EndBlue, Finished };

        Pen rectPen = new Pen(Color.Black, 2);
        Pen fillPen = new Pen(Color.FromArgb(50, 0, 0, 0), 1);
        Bitmap final, cont;
        List<Rectangle> rects;
        List<Bitmap> names = new List<Bitmap>();
        List<int> currentPosOfName = new List<int>(), currentNameInPos = new List<int>();
        List<int> finalPosOfName = new List<int>(), finalNameInPos = new List<int>();      //If finalPos[i] == j -> the position of names[i] is rects[j] ; if finalName[i] == j -> the name that goes to rects[i] is names[j] ; Concludes if finalPos[j] == i -> finalName[i] == j
        Random rng;
        int currentPos = 0;

         
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowOpenFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rng = new Random((int)DateTime.Now.Ticks);
                final = new Bitmap(openFileDialog1.FileName);
                cont = new Bitmap(openFileDialog1.FileName);
                contImage.Image = cont;
                finalImage.Image = final;
                rects = getGoiRects();
                filterRects();
                if (rects.Count % 8 != 0)
                    throw new ArgumentException("Invalid image file, unable to find players");
                names.Clear();
                currentPosOfName.Clear();
                currentNameInPos.Clear();
                finalNameInPos.Clear();
                finalPosOfName.Clear();
                currentPos = 0;
                nextButton.Enabled = true;
                foreach(Rectangle r in rects)
                {
                    names.Add(final.Clone(r, final.PixelFormat));
                }
                shuffle(1);
                makeFinalImage();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (rects != null)
                foreach (Rectangle r in rects)
                    graphics.DrawRectangle(rectPen, r);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            displayNext();
            if (currentPos == rects.Count)
                nextButton.Enabled = false;
        }

        private void QuitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<Rectangle> getGoiRects()
        {
            Size s = new Size(final.Width, final.Height);
            Color currentColor;
            SearchState state;
            List<Point> redPoints = new List<Point>(), bluePoints = new List<Point>();
            List<Rectangle> rects = new List<Rectangle>();
            bool lastLineIsEmpty  = true;

            for (int y = 0; y < s.Height; y++)
            {
                state = SearchState.FindRed;
                for (int x = 0; x < s.Width; x++)
                {
                    currentColor = final.GetPixel(x, y);
                    if (isInColorRange(state, currentColor))
                    {
                        switch (state)
                        {
                            case SearchState.FindRed:
                                lastLineIsEmpty = false;
                                redPoints.Add(new Point(x, y));
                                state = SearchState.EndRed;
                                break;
                            case SearchState.EndRed:
                                redPoints.Add(new Point(x, y));
                                state = SearchState.FindBlue;
                                break;
                            case SearchState.FindBlue:
                                bluePoints.Add(new Point(x, y));
                                state = SearchState.EndBlue;
                                break;
                            case SearchState.EndBlue:
                                bluePoints.Add(new Point(x, y));
                                state = SearchState.Finished;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (!lastLineIsEmpty && state == SearchState.FindRed)
                {
                    lastLineIsEmpty = true;
                    rects.Add(getBoundingRect(redPoints));
                    rects.Add(getBoundingRect(bluePoints));
                    redPoints.Clear();
                    bluePoints.Clear();
                }
            }

            return rects;
        }

        private bool isInColorRange(SearchState state, Color color)
        {
            return
             (state == SearchState.FindRed &&
             color.R < redFGmax.R && color.G < redFGmax.G && color.B < redFGmax.B &&
             color.R > redFGmin.R && color.G > redFGmin.G && color.B > redFGmin.B) ||
             (state == SearchState.EndRed &&
             color.R < redBGmax.R && color.G < redBGmax.G && color.B < redBGmax.B &&
             color.R > redBGmin.R && color.G > redBGmin.G && color.B > redBGmin.B) ||
             (state == SearchState.FindBlue &&
             color.R < blueFGmax.R && color.G < blueFGmax.G && color.B < blueFGmax.B &&
             color.R > blueFGmin.R && color.G > blueFGmin.G && color.B > blueFGmin.B) ||
             (state == SearchState.EndBlue &&
             color.R < blueBGmax.R && color.G < blueBGmax.G && color.B < blueBGmax.B &&
             color.R > blueBGmin.R && color.G > blueBGmin.G && color.B > blueBGmin.B);
        }

        private Rectangle getBoundingRect(List<Point> points)
        {

            if (points.Count == 0)
                throw new ArgumentException("List of points is empty.");

            int minX = int.MaxValue;
            int minY = minX;
            int maxX = int.MinValue;
            int maxY = maxX;
            int X, Y;

            foreach (Point p in points)
            {
                X = p.X;
                Y = p.Y;

                if (X < minX)
                    minX = X;
                if (X > maxX)
                    maxX = X;
                if (Y < minY)
                    minY = Y;
                if (Y > maxY)
                    maxY = Y;
            }

            return new Rectangle(minX, minY, maxX - minX, maxY - minY);
        }

        private void filterRects()
        {
            float avg = 0f;
            foreach (Rectangle r in rects)
                avg += r.Height;
            avg /= rects.Count;
            rects.RemoveAll(r => r.Height < avg);
            rects.Sort(delegate (Rectangle r1, Rectangle r2)
            {
                if (r1.Location.X < r2.Location.X)
                    return -1;
                if (r1.Location.X > r2.Location.X)
                    return 1;
                else
                {
                    if (r1.Location.Y < r2.Location.Y)
                        return -1;
                    if (r1.Location.Y > r2.Location.Y)
                        return 1;
                }
                return 0;
            });
        }

        private void shuffle(int factor)
        {
            for(int i = 0; i < rects.Count; i++)
            {
                finalPosOfName.Add(i);
                finalNameInPos.Add(i);
                currentPosOfName.Add(i);
                currentNameInPos.Add(i);
            }
            while(factor > 0)
            {
                for(int i = 0; i < rects.Count; i++)
                {
                    int rand = rng.Next(rects.Count);
                    int tmp = finalPosOfName[rand];
                    finalPosOfName[rand] = finalPosOfName[i];
                    finalPosOfName[i] = tmp;
                    finalNameInPos[finalPosOfName[i]] = i;
                    finalNameInPos[finalPosOfName[rand]] = rand;
                }
                factor--;
            }
        }

        private void placeImage(Bitmap srcImg, Bitmap dstImg, Point pos)
        {
          for(int y = 0; y < srcImg.Height; y++)
                for(int x = 0; x < srcImg.Width; x++)
                    dstImg.SetPixel(x + pos.X, y + pos.Y, srcImg.GetPixel(x, y));
        }

        private void makeFinalImage()
        {
            for (int i = 0; i < finalPosOfName.Count; i++)
                placeImage(names[finalNameInPos[i]], final, rects[i].Location);
        }

        private void displayNext()
        {
            int name1 = finalNameInPos[currentPos], name2 = currentNameInPos[currentPos];
            int pos1 = currentPos, pos2 = currentPosOfName[name1];
            leftSwapPicture.Image = names[name1];
            rightSwapPicture.Image = names[name2];
            currentNameInPos[pos1] = name1;
            currentNameInPos[pos2] = name2;
            currentPosOfName[name1] = pos1;
            currentPosOfName[name2] = pos2;
            placeImage(names[name1], cont, rects[pos1].Location);
            placeImage(names[name2], cont, rects[pos2].Location);
            contImage.Invalidate();
            currentPos++;
        }
    }
}
