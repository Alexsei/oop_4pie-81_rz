using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public partial class Form1 : Form
    {
        List<object> listAirModel = new List<object>();


        public Form1()
        {
            InitializeComponent();
        }

        public void initDefault()
        {
            listAirModel.Add( new Aircraft("", "А-29", weight, flightTime, serviceTime,
             speed, maxFuel, fuelConsumption, fuel));
        }

    }
}
