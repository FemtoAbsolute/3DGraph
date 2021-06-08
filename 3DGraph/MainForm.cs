using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3DGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string f;
        public Func<Dictionary<string, double>, double> func;
        //public Func<double, double, double> points;

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            //Если расчетов мало - то табличку во всю ширину, если много - то скроллбары
            if ((Convert.ToDouble(XMaxNumeric.Value) - Convert.ToDouble(XMinNumeric.Value)) / Convert.ToDouble(DeltaXNumeric.Value) <= 8)
                ValuesOfFunction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            else
                ValuesOfFunction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            //Очищение таблиц
            ValuesOfFunction.Rows.Clear();
            ValuesOfFunction.Columns.Clear();

            if ((Convert.ToDouble(XMaxNumeric.Value) - Convert.ToDouble(XMinNumeric.Value)) / Convert.ToDouble(DeltaXNumeric.Value) * (Convert.ToDouble(XMaxNumeric.Value) - Convert.ToDouble(XMinNumeric.Value)) / Convert.ToDouble(DeltaXNumeric.Value) > 1000)
            {
                if (MessageBox.Show("Вы выбрали маленькое значение шага. Большое количество вычислений может занять больше времени. Уверены, что хотите продолжить?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Calculate();
            }
            else
                Calculate();
        }

        public void Calculate()
        {
            int currentY, currentX = 0;
            var calc = new Sprache.Calc.XtensibleCalculator();
            try
            {
                label10.Visible = true;
                //Переменные если первый цикл и если Х есть в выражении
                bool FirstCycleFlag = true;
                bool isXExist = true;

                if (!FunctionTextbox.Text.ToUpper().Contains("X") && !FunctionTextbox.Text.ToUpper().Contains("Y"))
                {
                    var expr = calc.ParseExpression(ParseString(FunctionTextbox.Text));
                    var func = expr.Compile();
                    double Point = Math.Round(func(), 2);

                    ValuesOfFunction.Columns.Add("X", "X");
                    ValuesOfFunction.Rows.Add();
                    ValuesOfFunction.Rows[0].Cells[0].Value = Point;
                    ValuesOfFunction.Rows[0].HeaderCell.Value = ("Y");
                }
                else
                    for (double x = Convert.ToDouble(XMinNumeric.Value); x <= Convert.ToDouble(XMaxNumeric.Value); x += Convert.ToDouble(DeltaXNumeric.Value))
                    {
                        //Если чисто выражение
                        currentY = 0;
                        x = Math.Round(x, 2);

                        //Если Х нет в выражении, добавляет 1 столбец с названием У, в противном случае он будет добавлять столбцы для каждого значения Х
                        if (isXExist && !FunctionTextbox.Text.ToUpper().Contains("X"))
                        {
                            ValuesOfFunction.Columns.Add("X", "X");
                            isXExist = false;
                        }
                        if (isXExist)
                            ValuesOfFunction.Columns.Add(x.ToString(), x.ToString());

                        for (double y = Convert.ToDouble(YMinNumeric.Value); y <= Convert.ToDouble(YMaxNumeric.Value); y += Convert.ToDouble(DeltaYNumeric.Value))
                        {
                            y = Math.Round(y, 2);
                            f = FunctionTextbox.Text;
                            //Расчет функции
                            var expr = calc.ParseExpression(ParseString(FunctionTextbox.Text), X => x, Y => y);
                            var func = expr.Compile();
                            double Point = Math.Round(func(), 2);
                            

                            //Если функция содержит У и это первый цикл (проверка первого цикла нужна чтоб он не добавлял кучу строк пустых), то добавляет столько строк, сколько нужно
                            if (FirstCycleFlag && FunctionTextbox.Text.ToUpper().Contains("Y"))
                            {
                                ValuesOfFunction.Rows.Add();
                                ValuesOfFunction.Rows[currentY].Cells[currentX].Value = Point;
                                ValuesOfFunction.Rows[currentY].HeaderCell.Value = (y.ToString());
                                currentY++;
                                continue;
                            }

                            //Если же У нет, то он добавляет строку и больше строк не добавляется
                            else if (FirstCycleFlag && !FunctionTextbox.Text.ToUpper().Contains("Y"))
                            {
                                ValuesOfFunction.Rows.Add();
                                FirstCycleFlag = false;
                            }
                            //Значение текущей точки
                            ValuesOfFunction.Rows[currentY].Cells[currentX].Value = Point;

                            //Если У есть, то хедер равен значению У, если нет - слову У
                            if (FunctionTextbox.Text.ToUpper().Contains("Y"))
                                ValuesOfFunction.Rows[currentY].HeaderCell.Value = (y.ToString());
                            else
                                ValuesOfFunction.Rows[currentY].HeaderCell.Value = "Y";
                           
                            if (FunctionTextbox.Text.ToUpper().Contains("Y"))
                                currentY++;

                            if (x == Convert.ToDouble(XMaxNumeric.Value))
                                button1.Enabled = true;
           
                        }
                        FirstCycleFlag = false;
                        if (isXExist)
                            currentX++;
                    }
            }
            catch (Sprache.ParseException)
            {
                ValuesOfFunction.Rows.Clear();
                ValuesOfFunction.Columns.Clear();
                label10.Visible = false;
                if (MessageBox.Show("Похоже, вы ошиблись в записи функции. Внимательно прочтите документацию и попробуйте еще раз. Открыть документацию?", "Ошибка", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Tabs.SelectedTab = DocumentTabs;
            }
            catch (KeyNotFoundException)
            {
                ValuesOfFunction.Rows.Clear();
                ValuesOfFunction.Columns.Clear();
                label10.Visible = false;
                if (MessageBox.Show("Вы неверно ввели имя переменной. Внимательно прочтите документацию и попробуйте еще раз. Открыть документацию? ?", "Ошибка", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Tabs.SelectedTab = DocumentTabs;
            }
            catch (Exception ex)
            {
                ValuesOfFunction.Rows.Clear();
                ValuesOfFunction.Columns.Clear();
                label10.Visible = false;
                if (MessageBox.Show("Что-то пошло не так. Внимательно прочтите документацию и попробуйте еще раз. Открыть документацию? ?", "Ошибка", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Tabs.SelectedTab = DocumentTabs;
            }
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

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var calc = new Sprache.Calc.XtensibleCalculator();
            double minX = Convert.ToDouble(XMinNumeric.Value);
            double maxX = Convert.ToDouble(XMaxNumeric.Value);
            double minY = Convert.ToDouble(YMinNumeric.Value);
            double maxY = Convert.ToDouble(YMaxNumeric.Value);
            double stepX = Convert.ToDouble(DeltaXNumeric.Value);
            double stepY = Convert.ToDouble(DeltaYNumeric.Value);

            new Chart3DForm(f, minX, maxX, minY, maxY, stepX, stepY, calc).ShowDialog();
            button1.Enabled = false;
        }
    }
}