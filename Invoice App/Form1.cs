using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using MySql.Data.MySqlClient;
s
namespace Invoice_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// do this on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCartesianChart1(); 
            LoadCartesianChart3();
            LoadCartesianChart2();
        }
        /// <summary>
        /// function to load cartesian chart 1
        /// </summary>
        private void LoadCartesianChart1()
        {
            cartesianChart1.Series.Add
                  (new LineSeries
                  {
                      Values = new ChartValues<double> { 860 ,992 ,619 ,520, 686, 857 ,709, 819 },
                      Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)110, (byte)(int)113, (byte)(int)117)),
                      Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(100, (byte)(int)110, (byte)(int)113, (byte)(int)117)),
                      LineSmoothness = 10,
                      Title = "Invoice:",
                      PointGeometry = DefaultGeometries.None,
                      PointGeometrySize = 7,
                  }
                  );
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            var brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)32, (byte)(int)32, (byte)(int)32));
            cartesianChart1.DataTooltip.Foreground = brush;
        }
        /// <summary>
        /// function to load cartesian chart 2
        /// </summary>
        private void LoadCartesianChart2()
        {
            cartesianChart2.Series.Add
                  (new LineSeries
                  {
                      Values = new ChartValues<double> { 726 ,777 ,688 ,744, 907 ,848, 863, 639 },
                      Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)9, (byte)(int)189, (byte)(int)60)),
                      Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(100, (byte)(int)9, (byte)(int)189, (byte)(int)60)),
                      LineSmoothness = 10,
                      Title = "Invoice:",
                      PointGeometry = DefaultGeometries.None,
                      PointGeometrySize = 7,
                  }
                  );
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisY.Clear();
            var brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)32, (byte)(int)32, (byte)(int)32));
            cartesianChart2.DataTooltip.Foreground = brush;
        }
        /// <summary>
        /// function to load cartesian chart 3
        /// </summary>
        private void LoadCartesianChart3()
        {
            cartesianChart3.Series.Add
                  (new LineSeries
                  {
                      Values = new ChartValues<double> { 643 ,694, 959, 587 ,839 ,939,983, 852 },
                      Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)156, (byte)(int)61, (byte)(int)61)),
                      Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(100, (byte)(int)156, (byte)(int)61, (byte)(int)61)),
                      LineSmoothness = 10,
                      Title = "Invoice:",
                      PointGeometry = DefaultGeometries.None,
                      PointGeometrySize = 7,
                  }
                  );
            cartesianChart3.AxisX.Clear();
            cartesianChart3.AxisY.Clear();
            var brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)32, (byte)(int)32, (byte)(int)32));
            cartesianChart3.DataTooltip.Foreground = brush;
        }
    }
}
