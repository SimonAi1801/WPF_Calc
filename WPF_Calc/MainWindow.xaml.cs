using System;
using System.Collections.Generic;
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

namespace WPF_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _result;
        private string _first;
        private string _second;
        private string _operator;
        public MainWindow()
        {
            InitializeComponent();
            btnNum0.Click += Btn_Click;
            btnNum1.Click += Btn_Click;
            btnNum2.Click += Btn_Click;
            btnNum3.Click += Btn_Click;
            btnNum4.Click += Btn_Click;
            btnNum5.Click += Btn_Click;
            btnNum6.Click += Btn_Click;
            btnNum7.Click += Btn_Click;
            btnNum8.Click += Btn_Click;
            btnNum9.Click += Btn_Click;
            btnEqual.Click += Btn_Click;
            btnC.Click += Btn_Click;
            btnDiv.Click += Btn_Click;
            btnMinus.Click += Btn_Click;
            btnMult.Click += Btn_Click;
            btnPlus.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Content.ToString())
            {
                case "C":
                    {
                        _first = null;
                        _operator = null;
                        _second = null;
                        _result = 0;
                        txtResult.Text = _result.ToString();
                        break;
                    }
                case "+":
                    {
                        _operator = "+";
                        txtResult.Text = _operator;
                        break;
                    }

                case "-":
                    {
                        _operator = "-";
                        txtResult.Text = _operator;
                        break;
                    }


                case "*":
                    {
                        _operator = "*";
                        txtResult.Text = _operator;
                        break;
                    }

                case "/":
                    {
                        _operator = "/";
                        txtResult.Text = _operator;
                        break;
                    }
                case "=":
                    {
                        if (_operator == null)
                        {
                            txtResult.Text = "0";
                            _first = null;
                            _second = null;
                            _result = 0;
                        }
                        else
                        {
                            if (_operator == "+")
                            {
                                txtResult.Text = (Convert.ToInt32(_first) + Convert.ToInt32(_second)).ToString();
                            }
                            else if (_operator == "-")
                            {
                                txtResult.Text = (Convert.ToInt32(_first) - Convert.ToInt32(_second)).ToString();
                            }
                            else if (_operator == "*")
                            {
                                txtResult.Text = (Convert.ToInt32(_first) * Convert.ToInt32(_second)).ToString();
                            }
                            else if (_operator == "/")
                            {
                                if (_second != "0")
                                {
                                    txtResult.Text = (Convert.ToInt32(_first) / Convert.ToInt32(_second)).ToString();
                                }
                            }
                        }
                        break;
                    }
                case "1":
                    {
                        if (_operator == null)
                        {
                            _first += "1";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "1";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "2":
                    {
                        if (_operator == null)
                        {
                            _first += "2";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "2";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "3":
                    {
                        if (_operator == null)
                        {
                            _first += "3";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "3";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "4":
                    {
                        if (_operator == null)
                        {
                            _first += "4";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "4";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "5":
                    {
                        if (_operator == null)
                        {
                            _first += "5";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "5";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "6":
                    {
                        if (_operator == null)
                        {
                            _first += "6";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "6";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "7":
                    {
                        if (_operator == null)
                        {
                            _first += "7";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "7";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "8":
                    {
                        if (_operator == null)
                        {
                            _first += "8";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "8";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "9":
                    {
                        if (_operator == null)
                        {
                            _first += "9";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "9";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
                case "0":
                    {
                        if (_operator == null)
                        {
                            _first += "0";
                            txtResult.Text = _first.ToString();
                        }
                        else
                        {
                            _second += "0";
                            txtResult.Text = _second.ToString();
                        }
                        break;
                    }
            }
        }
    }
}
