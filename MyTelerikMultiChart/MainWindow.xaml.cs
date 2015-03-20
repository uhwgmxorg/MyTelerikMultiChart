/******************************************************************************/
/*                                                                            */
/*   Program: MyTelerikMultiChart                                             */
/*   Multi charts with Telerik's RadChaerView                                 */
/*                                                                            */
/*                                                                            */
/*   11.03.2015 0.0.0.0 uhwgmxorg Start                                       */
/*                                                                            */
/******************************************************************************/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTelerikMultiChart
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementiation
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// OnPropertyChanged
        /// </summary>
        /// <param name="p"></param>
        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
        #endregion

        public static int CLT = 5;   // ChartLineThickness
        const int NOMVPS = 40;       // NumberOfMeasurementValuesPerSeries

        // Fields
        static Random _random = new Random();

        ///  Properties
        public ObservableCollection<MeasurementSerie> MeasurementSeriesList { get; set; }
        public ObservableCollection<SeriesProviderDataItem> Data { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Data = new ObservableCollection<SeriesProviderDataItem>();
        }

        /******************************/
        /*       Button Events        */
        /******************************/
        #region Button Events

        /// <summary>
        /// Button_Click_Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            AddAChartLine(GetRandomStandartColor());
        }

        /// <summary>
        /// Button_Click_Clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Data.Clear();
        }

        #endregion
        /******************************/
        /*      Menu Events          */
        /******************************/
        #region Menu Events

        #endregion
        /******************************/
        /*      Other Events          */
        /******************************/
        #region Other Events

        #endregion
        /******************************/
        /*      Other Functions       */
        /******************************/
        #region Other Functions

        /// <summary>
        /// AddAChartLine
        /// </summary>
        /// <param name="chartSeriesColor"></param>
        private void AddAChartLine(Color chartSeriesColor)
        {
            SeriesProviderDataItem SPDataItem = new SeriesProviderDataItem(new SolidColorBrush(chartSeriesColor));
            ObservableCollection<MeasurementValue> LineSeries = new ObservableCollection<MeasurementValue>();

            for (int i = 1; i <= NOMVPS; i++)
                LineSeries.Add(new MeasurementValue(i, RandomDouble(1, 20, 0)));

            SPDataItem.Items = LineSeries;
            Data.Add(SPDataItem);
        }

        /// <summary>
        /// RandomDouble
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="deci"></param>
        /// <returns></returns>
        public double RandomDouble(double min, double max, int deci)
        {
            double d;
            d = _random.NextDouble() * (max - min) + min;
            return Math.Round(d, deci);
        }

        /// <summary>
        /// GetRandomStandartColor
        /// </summary>
        /// <returns></returns>
        public static Color GetRandomStandartColor()
        {
            int c = _random.Next(1, 140);
            switch (c)
            {
                case 1: return (Color)Colors.AntiqueWhite;
                case 2: return (Color)Colors.Aqua;
                case 3: return (Color)Colors.Aquamarine;
                case 4: return (Color)Colors.Azure;
                case 5: return (Color)Colors.Beige;
                case 6: return (Color)Colors.Bisque;
                case 7: return (Color)Colors.Black;
                case 8: return (Color)Colors.BlanchedAlmond;
                case 9: return (Color)Colors.Blue;
                case 10: return (Color)Colors.BlueViolet;
                case 11: return (Color)Colors.Brown;
                case 12: return (Color)Colors.BurlyWood;
                case 13: return (Color)Colors.CadetBlue;
                case 14: return (Color)Colors.Chartreuse;
                case 15: return (Color)Colors.Chocolate;
                case 16: return (Color)Colors.Coral;
                case 17: return (Color)Colors.CornflowerBlue;
                case 18: return (Color)Colors.Cornsilk;
                case 19: return (Color)Colors.Crimson;
                case 20: return (Color)Colors.Cyan;
                case 21: return (Color)Colors.DarkBlue;
                case 22: return (Color)Colors.DarkCyan;
                case 23: return (Color)Colors.DarkGoldenrod;
                case 24: return (Color)Colors.DarkGray;
                case 25: return (Color)Colors.DarkGreen;
                case 26: return (Color)Colors.DarkKhaki;
                case 27: return (Color)Colors.DarkMagenta;
                case 28: return (Color)Colors.DarkOliveGreen;
                case 29: return (Color)Colors.DarkOrange;
                case 30: return (Color)Colors.DarkOrchid;
                case 31: return (Color)Colors.DarkRed;
                case 32: return (Color)Colors.DarkSalmon;
                case 33: return (Color)Colors.DarkSeaGreen;
                case 34: return (Color)Colors.DarkSlateBlue;
                case 35: return (Color)Colors.DarkSlateGray;
                case 36: return (Color)Colors.DarkTurquoise;
                case 37: return (Color)Colors.DarkViolet;
                case 38: return (Color)Colors.DeepPink;
                case 39: return (Color)Colors.DeepSkyBlue;
                case 40: return (Color)Colors.DimGray;
                case 41: return (Color)Colors.DodgerBlue;
                case 42: return (Color)Colors.Firebrick;
                case 43: return (Color)Colors.FloralWhite;
                case 44: return (Color)Colors.ForestGreen;
                case 45: return (Color)Colors.Fuchsia;
                case 46: return (Color)Colors.Gainsboro;
                case 47: return (Color)Colors.GhostWhite;
                case 48: return (Color)Colors.Gold;
                case 49: return (Color)Colors.Goldenrod;
                case 50: return (Color)Colors.Gray;
                case 51: return (Color)Colors.Green;
                case 52: return (Color)Colors.GreenYellow;
                case 53: return (Color)Colors.Honeydew;
                case 54: return (Color)Colors.HotPink;
                case 55: return (Color)Colors.IndianRed;
                case 56: return (Color)Colors.Indigo;
                case 57: return (Color)Colors.Ivory;
                case 58: return (Color)Colors.Khaki;
                case 59: return (Color)Colors.Lavender;
                case 60: return (Color)Colors.LavenderBlush;
                case 61: return (Color)Colors.LawnGreen;
                case 62: return (Color)Colors.LemonChiffon;
                case 63: return (Color)Colors.LightBlue;
                case 64: return (Color)Colors.LightCoral;
                case 65: return (Color)Colors.LightCyan;
                case 66: return (Color)Colors.LightGoldenrodYellow;
                case 67: return (Color)Colors.LightGray;
                case 68: return (Color)Colors.LightGreen;
                case 69: return (Color)Colors.LightPink;
                case 70: return (Color)Colors.LightSalmon;
                case 71: return (Color)Colors.LightSeaGreen;
                case 72: return (Color)Colors.LightSkyBlue;
                case 73: return (Color)Colors.LightSlateGray;
                case 74: return (Color)Colors.LightSteelBlue;
                case 75: return (Color)Colors.LightYellow;
                case 76: return (Color)Colors.Lime;
                case 77: return (Color)Colors.LimeGreen;
                case 78: return (Color)Colors.Linen;
                case 79: return (Color)Colors.Magenta;
                case 80: return (Color)Colors.Maroon;
                case 81: return (Color)Colors.MediumAquamarine;
                case 82: return (Color)Colors.MediumBlue;
                case 83: return (Color)Colors.MediumOrchid;
                case 84: return (Color)Colors.MediumPurple;
                case 85: return (Color)Colors.MediumSeaGreen;
                case 86: return (Color)Colors.MediumSlateBlue;
                case 87: return (Color)Colors.MediumSpringGreen;
                case 88: return (Color)Colors.MediumTurquoise;
                case 89: return (Color)Colors.MediumVioletRed;
                case 90: return (Color)Colors.MidnightBlue;
                case 91: return (Color)Colors.MintCream;
                case 92: return (Color)Colors.MistyRose;
                case 93: return (Color)Colors.Moccasin;
                case 94: return (Color)Colors.NavajoWhite;
                case 95: return (Color)Colors.Navy;
                case 96: return (Color)Colors.OldLace;
                case 97: return (Color)Colors.Olive;
                case 98: return (Color)Colors.OliveDrab;
                case 99: return (Color)Colors.Orange;
                case 100: return (Color)Colors.OrangeRed;
                case 101: return (Color)Colors.Orchid;
                case 102: return (Color)Colors.PaleGoldenrod;
                case 103: return (Color)Colors.PaleGreen;
                case 104: return (Color)Colors.PaleTurquoise;
                case 105: return (Color)Colors.PaleVioletRed;
                case 106: return (Color)Colors.PapayaWhip;
                case 107: return (Color)Colors.PeachPuff;
                case 108: return (Color)Colors.Peru;
                case 109: return (Color)Colors.Pink;
                case 110: return (Color)Colors.Plum;
                case 111: return (Color)Colors.PowderBlue;
                case 112: return (Color)Colors.Purple;
                case 113: return (Color)Colors.Red;
                case 114: return (Color)Colors.RosyBrown;
                case 115: return (Color)Colors.RoyalBlue;
                case 116: return (Color)Colors.SaddleBrown;
                case 117: return (Color)Colors.Salmon;
                case 118: return (Color)Colors.SandyBrown;
                case 119: return (Color)Colors.SeaGreen;
                case 120: return (Color)Colors.SeaShell;
                case 121: return (Color)Colors.Sienna;
                case 122: return (Color)Colors.Silver;
                case 123: return (Color)Colors.SkyBlue;
                case 124: return (Color)Colors.SlateBlue;
                case 125: return (Color)Colors.SlateGray;
                case 126: return (Color)Colors.Snow;
                case 127: return (Color)Colors.SpringGreen;
                case 128: return (Color)Colors.SteelBlue;
                case 129: return (Color)Colors.Tan;
                case 130: return (Color)Colors.Teal;
                case 131: return (Color)Colors.Thistle;
                case 132: return (Color)Colors.Tomato;
                case 133: return (Color)Colors.Transparent;
                case 134: return (Color)Colors.Turquoise;
                case 135: return (Color)Colors.Violet;
                case 136: return (Color)Colors.Wheat;
                case 137: return (Color)Colors.White;
                case 138: return (Color)Colors.WhiteSmoke;
                case 139: return (Color)Colors.Yellow;
                case 140: return (Color)Colors.YellowGreen;
                default:
                    return (Color)Colors.Black;
            }
        }

        #endregion
    }

    #region Help Clases

    /// <summary>
    /// Class
    /// </summary>
    public class MeasurementValue
    {
        ///  Properties
        public int Nr { get; set; }
        public double Value { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MeasurementValue()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="v"></param>
        /// <param name="time"></param>
        public MeasurementValue(int nr, double v)
        {
            Nr = nr;
            Value = v;
        }    
    }

    /// <summary>
    /// Class MeasurementSerie
    /// </summary>
    public class MeasurementSerie
    {
        ///  Properties
        public ObservableCollection<MeasurementValue> Values { get; set; }
    }

    /// <summary>
    /// Class SeriesProviderDataItem
    /// </summary>
    public class SeriesProviderDataItem : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementiation
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// OnPropertyChanged
        /// </summary>
        /// <param name="p"></param>
        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
        #endregion

        ///  Properties
        private Brush seriesBrush = new SolidColorBrush(Colors.Black);
        public Brush SeriesBrush
        {
            get
            {
                return seriesBrush;
            }
            set
            {
                seriesBrush = value;
                OnPropertyChanged("SeriesBrush");
            }
        }
        private double seriesStrokeThikness = MainWindow.CLT;
        public double SeriesStrokeThikness
        {
            get
            {
                return seriesStrokeThikness;
            }
            set
            {
                seriesStrokeThikness = value;
                OnPropertyChanged("SeriesStrokeThikness");
            }
        }

        public ObservableCollection<MeasurementValue> Items { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public SeriesProviderDataItem()
        {
        }

        /// <summary>
        /// SeriesProviderDataItem
        /// </summary>
        /// <param name="brush"></param>
        public SeriesProviderDataItem(SolidColorBrush brush)
        {
            SeriesBrush = brush;
        }
    }

    /// <summary>
    /// Class ChartUtilities
    /// </summary>
    public class ChartUtilities
    {

        ///  DependencyProperties
        public static readonly DependencyProperty AttachVerticalAxisProperty = DependencyProperty.RegisterAttached("AttachVerticalAxis", typeof(bool), typeof(ChartUtilities), new PropertyMetadata(false, OnAttachVerticalAxisChanged));
        private static void OnAttachVerticalAxisChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var series = d as Telerik.Windows.Controls.ChartView.CartesianSeries;
            if (series != null)
            {
                series.VerticalAxis = (bool)e.NewValue ? new Telerik.Windows.Controls.ChartView.LinearAxis() : null;
            }
        }
        public static bool GetAttachVerticalAxis(DependencyObject obj)
        {
            return (bool)obj.GetValue(AttachVerticalAxisProperty);
        }
        public static void SetAttachVerticalAxis(DependencyObject obj, bool value)
        {
            obj.SetValue(AttachVerticalAxisProperty, value);
        }

        public static readonly DependencyProperty SeriesVerticalAxisBrushProperty = DependencyProperty.RegisterAttached("SeriesVerticalAxisBrush", typeof(Brush), typeof(ChartUtilities), new PropertyMetadata(null, OnSeriesVerticalAxisBrushChanged));
        private static void OnSeriesVerticalAxisBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var series = d as Telerik.Windows.Controls.ChartView.CartesianSeries;
            if (series != null)
            {
                series.VerticalAxis = (Brush)e.NewValue != null ? new Telerik.Windows.Controls.ChartView.LinearAxis() { LineStroke = (Brush)e.NewValue } : null;
                if(series.VerticalAxis != null) series.VerticalAxis.LineThickness = MainWindow.CLT;
            }
        }
        public static Brush GetSeriesVerticalAxisBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(SeriesVerticalAxisBrushProperty);
        }
        public static void SetSeriesVerticalAxisBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(SeriesVerticalAxisBrushProperty, value);
        }
    }

    #endregion
}
