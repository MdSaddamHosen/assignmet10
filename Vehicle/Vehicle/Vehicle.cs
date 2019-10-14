using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle
{
    public partial class Vehicle : Form
    {
        VehicleAnother _vehicle;
        public Vehicle()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _vehicle = new VehicleAnother(vehicleNameTextBox.Text, regNoTextBox.Text);

         vehicleNameTextBox.Clear();
             regNoTextBox.Clear();

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            _vehicle.Speed = Convert.ToDouble(speedTextBox.Text);
            _vehicle.SetSpeed();

           speedTextBox.Clear();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = _vehicle.GetMinSpeed().ToString();
            maxSpeedTextBox.Text = _vehicle.GetMaxSpeed().ToString();
            averageSpeedTextBox.Text = _vehicle.GetAverageSpeed().ToString();

        }
    }
}
