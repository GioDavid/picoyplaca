using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PicoYPlaca.View;
using PicoYPlaca.Presenter;
using PicoYPlaca.Model;

namespace PicoYPlaca
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IValidation
    {
        string errorText = "";
        bool valid = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        public Model.Date date
        {
            get
            {
                Date dt = new Date((DateTime)datePicker.SelectedDate);
                return dt;
            }
            set
            {
                datePicker.SelectedDate = value.Value;
            }
        }

        public Model.Vehicle vehicle
        {
            get
            {
                Vehicle vh = new Vehicle(txtPlate.Text);
                return vh;
            }
            set
            {
                txtPlate.Text = value.getPlate();
            }
        }

        public Model.Time time
        {
            get
            {
                Time tm = new Time(txtTime.Text);
                return tm;
            }
            set
            {
                txtTime.Text = value.Value;
            }
        }

        public bool isValid
        {
            get
            {
                return valid;
            }
            set
            {
                valid = value;
            }
        }

        public string error
        {
            get
            {
                errorText = result.Content.ToString();
                return errorText;
            }
            set
            {
                result.Content = value;
            }
        }

        private void btnVerify_Click(object sender, RoutedEventArgs e)
        {
            ValidationPresenter validationPresenter = new ValidationPresenter(this, date, vehicle, time);
            validationPresenter.canBeOnRoad();
        }

    }
}
