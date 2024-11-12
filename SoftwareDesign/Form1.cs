using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareDesign.Aircraft;
using SoftwareDesign.AircraftFactoryApp;

namespace SoftwareDesign
{
    public partial class Form1 : Form
    {
        private AircraftFactory currentFactory;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateMilitary_Click(object sender, EventArgs e)
        {
            if (currentFactory != null)
            {
                var militaryPlane = currentFactory.CreateMilitaryPlane();
                textBoxResult.Text = militaryPlane.Fly();
            }
            else
            {
                textBoxResult.Text = "Будь ласка, оберіть фабрику.";
            }
        }

        private void btnCreateCargo_Click(object sender, EventArgs e)
        {
            if (currentFactory != null)
            {
                var cargoPlane = currentFactory.CreateCargoPlane();
                textBoxResult.Text = cargoPlane.Fly();
            }
            else
            {
                textBoxResult.Text = "Будь ласка, оберіть фабрику.";
            }
        }

        private void btnCreatePassenger_Click(object sender, EventArgs e)
        {
            if (currentFactory != null)
            {
                var passengerPlane = currentFactory.CreatePassengerPlane();
                textBoxResult.Text = passengerPlane.Fly();
            }
            else
            {
                textBoxResult.Text = "Будь ласка, оберіть фабрику.";
            }
        }


        //---------------------------------------------------------------------


        private void btnBoeingFactory_Click(object sender, EventArgs e)
        {
            currentFactory = new BoeingFactory();
            textBoxResult.Text = "Обрано фабрику Boeing.";
        }

        private void btnAirbusFactory_Click(object sender, EventArgs e)
        {
            currentFactory = new AirbusFactory();
            textBoxResult.Text = "Обрано фабрику Airbus.";
        }

        private void btnLockheedFactory_Click(object sender, EventArgs e)
        {
            currentFactory = new LockheedMartinFactory();
            textBoxResult.Text = "Обрано фабрику Lockheed Martin.";
        }
    }
}
