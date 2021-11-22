using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametrierung
{
    class Class_Interface
    {
        public Class_Interface()
        {

        }

        public void saveValues(System.Drawing.PointF[] points, string directoryPath, string filename)
        {
            float pointcounter = points[0].X;
            string x_array = "[";
            string y_array = "[";

            for(int i = 1; i < pointcounter; i++)
            {
                x_array += points[i].X + ":";
                y_array += points[i].Y + ":";
            }

            x_array += "]";
            y_array += "]";

            System.IO.StreamWriter writer = new System.IO.StreamWriter(directoryPath + @"\" + filename);
            writer.WriteLine(x_array);
            writer.WriteLine(y_array);
            writer.Close();
        }

        public void saveValues(System.Windows.Forms.DataVisualization.Charting.DataPointCollection points, string directoryPath, string filename)
        {
            int pointcounter = points.Count;
            string x_array = "[";
            string y_array = "[";

            for (int i = 1; i < pointcounter; i++)
            {
                x_array += points[i].XValue + ":";
                y_array += points[i].YValues[0] + ":";
            }

            x_array += "]";
            y_array += "]";

            System.IO.StreamWriter writer = new System.IO.StreamWriter(directoryPath + @"\" + filename);
            writer.WriteLine(x_array);
            writer.WriteLine(y_array);
            writer.Close();
        }

        public void importValues(string filepath, System.Windows.Forms.DataVisualization.Charting.Series series)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(filepath);

            string x_array = reader.ReadLine();
            string y_array = reader.ReadLine();
            reader.Close();

            System.Diagnostics.Debug.WriteLine(x_array);
            System.Diagnostics.Debug.WriteLine(y_array);

            string[] values_x = x_array.Split(':');
            values_x[0] = values_x[0].Remove(0, 1);

            string[] values_y = y_array.Split(':');
            values_y[0] = values_y[0].Remove(0, 1);


            for (int i = 0; i < values_x.Length-1; i++)
            {
                series.Points.AddXY(Convert.ToDouble(values_x[i]), Convert.ToDouble(values_y[i]));
            }

        }

    }
}
