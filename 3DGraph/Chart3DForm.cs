using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DGraph
{
    public partial class Chart3DForm : Form
    {
        string function, nameX, nameY, nameZ;
        float gx, gy, hx, hy, stepX, stepY;
        Sprache.Calc.XtensibleCalculator calc;
        public Chart3DForm(string f, double gx, double hx, double gy, double hy, double stepX, double stepY, Sprache.Calc.XtensibleCalculator c, string nameX, string nameY, string nameZ)
        {
            this.gx = (float)gx;
            this.gy = (float)gy;
            this.hx = (float)hx;
            this.hy = (float)hy;
            this.stepX = (float)stepX;
            this.stepY = (float)stepY;
            this.nameX = nameX;
            this.nameY = nameY;
            this.nameZ = nameZ;
            InitializeComponent();
            Controls.Add(_surfacePlotControl);
            function = f;
            calc = c;
           // Load += Chart3DForm_Load;
        }

        private void Chart3DForm_Load(object sender, EventArgs e)
        {
            _configuration = new OpenControls.Wpf.SurfacePlot.Model.Configuration();

            OpenControls.Wpf.Serialisation.RegistryItemSerialiser configurationSerialiser = new OpenControls.Wpf.Serialisation.RegistryItemSerialiser(RegKeyPath);
            if (!configurationSerialiser.OpenKey())
            {
                configurationSerialiser.CreateKey();
            }
            IConfigurationSerialiser = configurationSerialiser;
            _configuration.Load(configurationSerialiser);

            _surfacePlotControl.Initialise(_configuration);
            Run();


            _configuration.ZScale = 0.365;
            _configuration.BackgroundColour = "Black";
            _configuration.ShadingAlgorithm = OpenControls.Wpf.SurfacePlot.Model.ShadingAlgorithm.Dynamic;
         
         
            

        }

        string RegKeyPath
        {
            get
            {
                return System.Environment.Is64BitOperatingSystem ? @"SOFTWARE\Wow6432Node\OpenControls.Wpf.SurfacePlotDemo\RawDataSettings" : @"SOFTWARE\OpenControls.Wpf.SurfacePlotDemo\RawDataSettings";
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_surfacePlotControl != null)
            {
                _surfacePlotControl.SetBounds(
                    ClientRectangle.X,
                    ClientRectangle.Y,
                    ClientRectangle.Width,
                    ClientRectangle.Height);
            }
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            _configuration.Save(IConfigurationSerialiser);
            this.Close();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void ScrollEvent(object sender, EventArgs e)
        {
            _configuration.Zoom = ZoomBar.Value;
        }

        private void CloseSettings_Click(object sender, EventArgs e)
        {
            OpenPanel.Visible = true;
            SettingsPanel.Visible = false;
        }



        private void OpenButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            OpenPanel.Visible = false;
            
        }

        private void ZScaleScroll(object sender, EventArgs e)
        {
            double value = ZScaleBar.Value;
            _configuration.ZScale = value/1000;
        }

    

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _configuration.ViewProjection = OpenControls.Wpf.SurfacePlot.Model.ViewProjection.ThreeDimensional;
            _configuration.Zoom = 350;
            _configuration.ZScale = 0.350;
            _configuration.ShowScatterPlot = false;
            _configuration.ShowShading = true;
            _configuration.ShowGrid = true;
            _configuration.ShadingMethod = OpenControls.Wpf.SurfacePlot.Model.ShadingMethod.Interpolated;
            _configuration.LabelFontSize = 24;
            CurrentSettings();

        }

        void CurrentSettings()
        {
            ZScaleBar.Value = Convert.ToInt32(_configuration.ZScale*1000);
            if (_configuration.ShadingMethod == OpenControls.Wpf.SurfacePlot.Model.ShadingMethod.Interpolated)
                InterpolatedRadio.Checked = true;
            else
                CorRadio.Checked = true;
            XLabelsValue.Value = XLabelsValue.Maximum;
            YLabelsValue.Value = YLabelsValue.Maximum;
            ZLabelsBar.Value = ZLabelsBar.Maximum;
            ZoomBar.Value = _configuration.Zoom;
            FontTrackbar.Value = _configuration.LabelFontSize;
            if (_configuration.ShowGrid == true)
                GridChecked.Checked = true;
            else
                GridChecked.Checked = false;
            if (_configuration.ShowScatterPlot == true)
                ScatterCheck.Checked = true;
            else
                ScatterCheck.Checked = false;
            
        }

        private void ZLabelsScroll(object sender, EventArgs e)
        {
            _surfacePlotControl.SetData(srcData, gx, hx, XLabelsValue.Value, gy, hy, YLabelsValue.Value, zminlabel, zmaxlabel, ZLabelsBar.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenControls.Wpf.SurfacePlot.Exports.ShowConfigurationDialog(_configuration);
            _configuration.Save(IConfigurationSerialiser);
           
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        OpenControls.Wpf.SurfacePlot.SurfacePlotControl _surfacePlotControl = new OpenControls.Wpf.SurfacePlot.SurfacePlotControl();

        private void FontTrackScroll(object sender, EventArgs e)
        {
            _configuration.LabelFontSize = FontTrackbar.Value;
        }

        private void YLabelsScroll(object sender, EventArgs e)
        {
            _surfacePlotControl.SetData(srcData, gx, hx, XLabelsValue.Value, gy, hy, YLabelsValue.Value, zminlabel, zmaxlabel, ZLabelsBar.Value);
        }

        private void GridCheckedChanged(object sender, EventArgs e)
        {
            if (GridChecked.Checked == true)
                _configuration.ShowGrid = true;
            else
                _configuration.ShowGrid = false;
        }

        private void ScatterCheckedChanged(object sender, EventArgs e)
        {
            if (ScatterCheck.Checked == true)
            {
                _configuration.ShowScatterPlot = true;
                _configuration.ShowShading = false;
            }
            else
            {
                _configuration.ShowScatterPlot = false;
                _configuration.ShowShading = true;
            }
        }

        private void RadioCheckedChanged(object sender, EventArgs e)
        {
            if (InterpolatedRadio.Checked == true)
                _configuration.ShadingMethod = OpenControls.Wpf.SurfacePlot.Model.ShadingMethod.Interpolated;
            if (CorRadio.Checked == true)
                _configuration.ShadingMethod = OpenControls.Wpf.SurfacePlot.Model.ShadingMethod.Coarse;

        }

        private void XAxisOrtoClick(object sender, EventArgs e)
        {
            _configuration.ViewProjection = OpenControls.Wpf.SurfacePlot.Model.ViewProjection.Orthographic_Side;
        }

        private void YAxisOrtoClick(object sender, EventArgs e)
        {
            _configuration.ViewProjection = OpenControls.Wpf.SurfacePlot.Model.ViewProjection.Orthographic_Front;
        }

        private void ZAxisOrtoClick(object sender, EventArgs e)
        {
            _configuration.ViewProjection = OpenControls.Wpf.SurfacePlot.Model.ViewProjection.BirdsEye_0;
        }

        private void Orto3DClick(object sender, EventArgs e)
        {
            _configuration.ViewProjection = OpenControls.Wpf.SurfacePlot.Model.ViewProjection.ThreeDimensional;
        }

        OpenControls.Wpf.SurfacePlot.Model.Configuration _configuration;
        private OpenControls.Wpf.Serialisation.IConfigurationSerialiser IConfigurationSerialiser;



        float zMax = float.MinValue;
        float zMin = float.MaxValue;
        float zminlabel, zmaxlabel;
        List<List<float>> srcData = new List<List<float>>();
        private void Run()
        {

            for (float i = gx; i <= hx; i += stepX)
            {
                //if (srcData.Count >= 50)
                //    break;
                List<float> list = new List<float>();

                for (float j = gy; j <= hy; j += stepY)
                {
                    var expr = calc.ParseExpression(ParseString(function), X => i, Y => j);
                    var func = expr.Compile();
                    float z = (float)func();
                    if (z > zMax)
                        zMax = z;
                    if (z < zMin)
                        zMin = z;
                    list.Add(z);
                }
                srcData.Add(list);
            }
            int zlabels = Convert.ToInt32(zMax - zMin) + 1;
            int ylabels = Convert.ToInt32((hy - gy) / stepY) + 1;
            int xlabels = Convert.ToInt32((hx - gx) / stepX) + 1;

            zminlabel = -zMax;
            zmaxlabel = zMax;
            if (Math.Abs(zMin) > Math.Abs(zMax))
            {
                zminlabel = zMin;
                zmaxlabel = Math.Abs(zMin);
            }
            _surfacePlotControl.SetData(srcData, gx, hx, xlabels, gy, hy, ylabels, zminlabel, zmaxlabel, zlabels);
            ZLabelsBar.Maximum = zlabels;

            if (zlabels >= 30)
                ZLabelsBar.Minimum = zlabels / 10;
            else
                ZLabelsBar.Minimum = zlabels / 2;

            XLabelsValue.Maximum = xlabels;
            if (xlabels >= 30)
                XLabelsValue.Minimum = xlabels / 10;
            else
                XLabelsValue.Minimum = xlabels / 2;

            YLabelsValue.Maximum = ylabels;
            if (ylabels >= 30)
                YLabelsValue.Minimum = ylabels / 10;
            else
                YLabelsValue.Minimum = ylabels / 2;

            _surfacePlotControl.XAxisTitle = nameX;
            _surfacePlotControl.YAxisTitle = nameY;
            _surfacePlotControl.ZAxisTitle = nameZ;
            CurrentSettings();

        }
        public string ParseString(string parsedString)
        {
            parsedString = parsedString.ToUpper();
            if (parsedString.Contains("COS"))
                parsedString = parsedString.Replace("COS", "Cos");
            if (parsedString.Contains("SIN"))
                parsedString = parsedString.Replace("SIN", "Sin");
            if (parsedString.Contains("TAN"))
                parsedString = parsedString.Replace("TAN", "Tan");
            if (parsedString.Contains("COS"))
                parsedString = parsedString.Replace("PI", "Pi");
            if (parsedString.Contains("SQRT"))
                parsedString = parsedString.Replace("SQRT", "Sqrt");
            if (parsedString.Contains("LOG"))
                parsedString = parsedString.Replace("LOG", "Log");

            return parsedString;
        }
    }


}
