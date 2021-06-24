﻿using System;
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
        OpenControls.Wpf.SurfacePlot.Model.Configuration _configuration;
        private OpenControls.Wpf.Serialisation.IConfigurationSerialiser IConfigurationSerialiser;



        private void Run()
        {

            float zMax = float.MinValue;
            float zMin = float.MaxValue;

            List<List<float>> srcData = new List<List<float>>();
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
            float zminlabel = -zMax, zmaxlabel = zMax;
            if (Math.Abs(zMin) > Math.Abs(zMax))
            {
                zminlabel = zMin;
                zmaxlabel = Math.Abs(zMin);
            }
            _surfacePlotControl.SetData(srcData, gx, hx, Convert.ToInt32((hx-gx)/stepX)+1, gy, hy, Convert.ToInt32((hy - gy) / stepY)+1, zminlabel, zmaxlabel, zlabels);
            
      //      _surfacePlotControl.XAxisTitle = "axis x";//nameX;
       
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
                parsedString = parsedString.Replace("PI", "3.14");
            if (parsedString.Contains("SQRT"))
                parsedString = parsedString.Replace("SQRT", "Sqrt");
            if (parsedString.Contains("LOG"))
                parsedString = parsedString.Replace("LOG", "Log");

            return parsedString;
        }
    }


}
