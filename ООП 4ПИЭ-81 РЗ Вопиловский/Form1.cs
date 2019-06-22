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
            initListAirModelDefault();
        }

        public void initListAirModelDefault()
        {   // инициализация моделей по молчанию

            //( name,  model,  weight, flightTime, serviceTime,  speed, maxFuel,  fuelConsumption,  fuel)
            // прогулочные модели
            listAirModel.Add( new WalkingAircraft("", "М-12 «Касатик»", 485, 8, 1, 190, 180, 22, 0));
            listAirModel.Add(new WalkingAircraft("", "Су-26", 680, 4, 1, 310, 200, 40, 0));
            listAirModel.Add(new WalkingAircraft("", "Як-52", 1035, 3, 1, 270, 200, 55, 0));

            // пассажирские
           
            listAirModel.Add(new PassengerAircraft("", "Аккорд-201", 1330, 10, 2, 200, 280, 20, 0, 6));
            listAirModel.Add(new PassengerAircraft("", "Л-42",       800,  10, 1, 210, 290, 22, 0, 4));
            listAirModel.Add(new PassengerAircraft("", "Ан-140",   12810,  5,  5, 550, 4500, 800, 0, 52));
            listAirModel.Add(new PassengerAircraft("", "Л-42",       800,  13, 3, 300, 290, 22, 0, 8));
            listAirModel.Add(new PassengerAircraft("", "Ту-334", 18700, 4, 10, 820, 10100, 2300, 0, 102));
            listAirModel.Add(new PassengerAircraft("", "Boeing 777", 263080, 13, 10, 805, 117000, 7800, 0, 350));
            listAirModel.Add(new PassengerAircraft("", "SSJ 100", 24250, 6, 8, 830, 15805, 2000, 0, 120));

            // военные
            listAirModel.Add(new WarAircraft("", "МиГ-29", 11000, 3, 10, 850, 3000, 800, 0));
            listAirModel.Add(new WarAircraft("", "МиГ-35", 13500, 3, 10, 1000, 3000, 800, 0));
            listAirModel.Add(new WarAircraft("", "Су-57", 18500, 3, 10, 2000, 11100, 3500, 0));

            // грузовые 
            listAirModel.Add(new CargoAircraft("", "Ан-124 «Руслан»", 178400, 10, 9, 800, 212350, 16000, 0, 100000));
            listAirModel.Add(new CargoAircraft("", "Ту-330", 25000, 9, 3, 800, 35000, 3500, 0, 35000));
            listAirModel.Add(new CargoAircraft("", "Basler BT-67", 7144, 5, 2, 380, 2350, 335, 0, 3550));


        }

    }
}
