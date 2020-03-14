using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace KolejneWykresy
{
    public partial class Form1 : Form
    {
        string file; // plik
        int dane = 0; // nr wykresu z danego pliku
        double[,] values; // wartosci do wszystkich wykresow
        double strt = 0;
        double stopp = 0;
        double stepp = 0;
        double nulll = 0;
        bool logarytmiczna = false;
        bool blok = false; // blokada skali logarytmicznej
        int elements; // ilosc rodzajow wykresow

        string[] names = new string[12];

        public Form1()
        {
            InitializeComponent();
            this.chart1.MouseMove += new MouseEventHandler(chart1_MouseMove);
        }

       


        private void loadingWszystkiego()
        {
            string start = "";
            string stop = "";
            string step = "";
            string nul = "";
            StreamReader reader = new StreamReader(file);
            int enter = 0; // do łapania startu/stopu/skoku
            for (int i = 0; i < 50; i++)
            {


                var parts = reader.ReadLine().Split(new char[] { ' ' });
                string[] x = parts;

                enter = 0;
                foreach (string str in x)
                {
                    if (str == "STRT.M")
                    {
                        enter = 1;
                    }
                    if (enter == 1)
                    {
                        if (str != "STRT.M" && str != "" && str != ":")
                            start = str;
                    }
                    if (str == "STOP.M")
                    {
                        enter = 2;
                    }
                    if (enter == 2)
                    {
                        if (str != "STOP.M" && str != "" && str != ":")
                            stop = str;
                    }
                    if (str == "STEP.M")
                    {
                        enter = 3;
                    }
                    if (enter == 3)
                    {
                        if (str != "STEP.M" && str != "" && str != ":")
                            step = str;
                    }
                    if (str == "NULL.")
                    {
                        enter = 4;
                    }
                    if (enter == 4)
                    {
                        if (str != "NULL." && str != "" && str != ":")
                            nul = str;
                    }
                    //System.Threading.Thread.Sleep(10);
                    if (nul != "")
                        break;
                }

            }
            //Console.WriteLine("\n\nstart: {0}\t stop: {1}\t skok: {2}\t null: {3}", start, stop, step, nul);
            strt = 0;
            stopp = 0;
            stepp = 0;
            nulll = 0;
            try
            {
                strt = Double.Parse(start, System.Globalization.CultureInfo.InvariantCulture);
                stopp = Double.Parse(stop, System.Globalization.CultureInfo.InvariantCulture);
                stepp = Double.Parse(step, System.Globalization.CultureInfo.InvariantCulture);
                nulll = Double.Parse(nul, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                strt = Double.Parse(start.Remove(start.Length - 1, 1), System.Globalization.CultureInfo.InvariantCulture);
                stopp = Double.Parse(stop.Remove(stop.Length - 1, 1), System.Globalization.CultureInfo.InvariantCulture);
                stepp = Double.Parse(step.Remove(step.Length - 1, 1), System.Globalization.CultureInfo.InvariantCulture);
                nulll = Double.Parse(nul.Remove(nul.Length - 1, 1), System.Globalization.CultureInfo.InvariantCulture);
            }


            while (true) // wczytanie nazw kolumn
            {
                string[] parts = reader.ReadLine().Split(new char[] { ' ' });

                if (parts[0] == "~A")
                {
                    elements = 0;
                    foreach (string x in parts)
                    {
                        if (x == "~A" || x == "DEPTH" || x == "DEPT" || x == "")
                            continue;
                        names[elements++] = x;
                        //Console.WriteLine("{0}", names[elements - 1]);
                    }
                    break;
                }
            }
            values = new double[elements, 9100];
            int iter1;
            int iter2 = 0;
            while (true) // wczytanie wartosci
            {
                string[] parts;
                string line = reader.ReadLine();
                if (line == null)
                    break;
                else if (line == "")
                    continue;
                else
                    parts = line.Split(new char[] { ' ' });

                if (parts[0] == "#")
                    continue;

                Console.WriteLine("{0}", line);
                iter1 = 0;
                foreach (string x in parts)
                {
                    if (x == "")
                        continue;
                    if (iter1 == 0)
                    {
                        iter1++;
                        continue;
                    }
                    values[iter1++ - 1, iter2] = Double.Parse(x, System.Globalization.CultureInfo.InvariantCulture);

                }
                iter2++;

            }
            reader.Close();
        }

        private void loadingWykresu()
        {
            double maxY = nulll;
            double minY = nulll;
            dataToolStripMenuItem.Text = names[dane];
            
            //chart1.Size = new Size(434, (int)(stopp - strt) / 10);
            
            for (int x = 0; x < 12; x++)
            {
                dataToolStripMenuItem.DropDownItems[x].Text = names[x];
                if (x < elements)
                    dataToolStripMenuItem.DropDownItems[x].Visible = true;
                else
                    dataToolStripMenuItem.DropDownItems[x].Visible = false;
            }

            //if (elements < 12)
            //    for (int x = 11; x > elements; x--)
            //        dataToolStripMenuItem.DropDownItems[x].Visible = false;

            chart1.Series["Series1"].Points.Clear();
            int j = 0;
            blok = false;
            
            button1.Enabled = true;
            for (double i = strt; i < stopp; i += stepp)
            {
                if (values[dane, j] == nulll)
                {
                    j++;
                    continue;
                }

                if (maxY == nulll || maxY < values[dane, j])
                    maxY = values[dane, j];
                if (minY == nulll || minY > values[dane, j])
                    minY = values[dane, j];

                if (i <= 0 || values[dane, j] <= 0)
                {
                    blok = true;
                    
                }
                chart1.Series["Series1"].Points.AddXY(values[dane, j++], i);
            }
            //chart1.ChartAreas["ChartArea1"].AxisX.Maximum = maxY;
            //chart1.ChartAreas["ChartArea1"].AxisX.Minimum = minY;
            chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.MinSize = 150;
            chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoom(strt - 10, 150);
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = stopp + 10;
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = strt - 10;
            chart1.ChartAreas["ChartArea1"].AxisY.ScrollBar.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Position = maxY;

            if (logarytmiczna)
                label3.Text = "Aktualna skala:\n  logarytmiczna";
            else
                label3.Text = "Aktualna skala:\n  liniowa";

            if (blok)
                button1.Enabled = false;
            chart1.Refresh();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dane = 0;
            
            loadingWykresu();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dane2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 1;
            loadingWykresu();
        }

        private void dane3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 2;
            loadingWykresu();
        }

        private void dane4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 3;
            loadingWykresu();
        }

        private void dane5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 4;
            loadingWykresu();
        }

        private void dane6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 5;
            loadingWykresu();
        }

        private void dane7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 6;
            loadingWykresu();
        }

        private void dane8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 7;
            loadingWykresu();
        }

        private void dane9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 8;
            loadingWykresu();
        }

        private void dane10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 9;
            loadingWykresu();
        }

        private void dane11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 10;
            loadingWykresu();
        }

        private void dane12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logarytmiczna = false;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
            dane = 11;
            loadingWykresu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logarytmiczna)
            {
                chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
                //chart1.ChartAreas["ChartArea1"].AxisY.IsLogarithmic = false;                
            }
            else
            {
                chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = true;
                //chart1.ChartAreas["ChartArea1"].AxisY.IsLogarithmic = true;
            }
            logarytmiczna = !logarytmiczna;
            loadingWykresu();
            
        }

        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            tooltip.Show("Głębokość = " + prop.YValues[0] + "  Wartość = " + prop.XValue, this.chart1,
                                            pos.X, pos.Y - 15);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog1.OpenFile()) != null)
                    {
                        file = openFileDialog1.FileName;
                        //MessageBox.Show(file);
                        logarytmiczna = false;
                        chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = false;
                        //file = "K.las";
                        dane = 0;
                        button2.Text = file;
                        loadingWszystkiego();
                        loadingWykresu();
                        menuStrip2.Enabled = true;
                        button1.Enabled = true;
                        //klasToolStripMenuItem.Visible = false;
                        //sOBlasToolStripMenuItem.Visible = true;
                        //wLASToolStripMenuItem1.Visible = true;
                        //chart1.ChartAreas["ChartArea1"].AxisY.Maximum = stopp;
                        //chart1.ChartAreas["ChartArea1"].AxisY.Minimum = strt;
                        chart1.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
