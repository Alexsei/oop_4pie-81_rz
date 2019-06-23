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
        List<Aircraft> listAirModelWar = new List<Aircraft>(); // список военных самолетов
        List<Aircraft> listAirModelPas = new List<Aircraft>(); // список пассажирских самолетов
        List<Aircraft> listAirModelCar = new List<Aircraft>(); // список грузовых самолетов
        List<Aircraft> listAirModelWal = new List<Aircraft>(); // список прогулочных самолетов
        List<Airport> listAirports = new List<Airport>();
        List<Flight> listFlights = new List<Flight>();

        public Form1()
        {
            InitializeComponent();
            initListAirModelDefault();
            initListAirports();
            initAirs();
            viewListAirports();
            viewListPAirs(0);
        }

        public void initAirs()  // инициализация списка самолетов (Рандом)
        {
            Random rnd = new Random();
            for (int pId=0; pId < listAirports.Count; pId++)
            {
                int maxAir = rnd.Next(listAirports[pId].MaxDocks);
                for (int aId = 0; aId < maxAir; aId++)
                {
                    int typeAir = rnd.Next(4);
                    if (listAirports[pId].Type==0) { typeAir = 0; }  //если аэропорт военный, самолеты только военные
       
                    switch (typeAir)
                    {
                        case 0: // военные самолеты 
                            listAirports[pId].addAirInDock(new WarAircraft(listAirModelWar[rnd.Next(listAirModelWar.Count)], "WAR-"+ rnd.Next(1000)));
                            break;
                        case 1: // пассажирские самолеты 
                            listAirports[pId].addAirInDock(new WarAircraft(listAirModelPas[rnd.Next(listAirModelPas.Count)], "PAS-" + rnd.Next(1000)));
                            break;
                        case 2: // грузовые самолеты 
                            listAirports[pId].addAirInDock(new WarAircraft(listAirModelCar[rnd.Next(listAirModelCar.Count)], "CAR-" + rnd.Next(1000)));
                            break;
                        case 3: // прогулочные самолеты 
                            listAirports[pId].addAirInDock(new WarAircraft(listAirModelWal[rnd.Next(listAirModelWal.Count)], "WAL-" + rnd.Next(1000)));
                            break;
                    }

                }
  
            }

        }

        public void initListAirports()  // инициализация списка аэропортов
        {
            // Airport(string name , int maxDocks, int x, int y, int type)
            listAirports.Add(new Airport("Центральный", 10, 5000, 5000, 1));
            listAirports.Add(new Airport("Северный", 10, 5000, 6000, 1));
            listAirports.Add(new Airport("южный", 10, 5000, 4000, 1));
            listAirports.Add(new Airport("восточный", 10, 6000, 5000, 1));
            listAirports.Add(new Airport("западный", 10, 4000, 5000, 1));
            listAirports.Add(new Airport("Сев-Зап", 5, 4500, 5500, 1));
            listAirports.Add(new Airport("Сев-Вос", 5, 5500, 5500, 0));
            listAirports.Add(new Airport("Юг-Зап", 5, 4500, 4500, 0));
            listAirports.Add(new Airport("Юг-Вос", 5, 5500, 4500, 1));

        }

        public void viewListAirports()  // отображение списка аэропортов
        {
            listViewPorts.Items.Clear(); // Очистить список аэропортов
            for (int i = 0; i < listAirports.Count; i++)
            {
                ListViewItem newPorts = new ListViewItem(Convert.ToString(i));
                newPorts.SubItems.Add(listAirports[i].Name);
                newPorts.SubItems.Add(Convert.ToString(listAirports[i].MaxDocks));
                newPorts.SubItems.Add(Convert.ToString(listAirports[i].FreeDocks));
                newPorts.SubItems.Add(Convert.ToString(listAirports[i].X));
                newPorts.SubItems.Add(Convert.ToString(listAirports[i].Y));
                if (listAirports[i].Type==0)
                {
                    newPorts.SubItems.Add("Арм.");
                } else
                {
                    newPorts.SubItems.Add("Гражд.");
                }
                listViewPorts.Items.Add(newPorts);
            }

        }

        public void viewListPAirs(int id)  // отображение списка самолетов в аэропарту
        {
            Airport port = listAirports[id];
            Console.WriteLine(port.Name);
            listViewPortAirs.Items.Clear(); // Очистить список самолетов
            for (int i = 0; i < port.MaxDocks; i++)
            {
                Docks dock = port.getAirDocks(i);
                ListViewItem newAir = new ListViewItem(Convert.ToString(i));
                if (dock.Status != 0) {
                    newAir.SubItems.Add(dock.Air.Name);
                    newAir.SubItems.Add(dock.Air.Model);
                } else
                {
                    newAir.SubItems.Add("Док свободен");
                }
                listViewPortAirs.Items.Add(newAir);
            }
        }
        public void initListAirModelDefault() // инициализация моделей по молчанию
        {

            //( name,  model,  weight, flightTime, serviceTime,  speed, maxFuel,  fuelConsumption,  fuel)
            // прогулочные модели
            listAirModelWal.Add( new WalkingAircraft("", "М-12 «Касатик»", 485, 8, 1, 190, 180, 22, 0));
            listAirModelWal.Add(new WalkingAircraft("", "Су-26", 680, 4, 1, 310, 200, 40, 0));
            listAirModelWal.Add(new WalkingAircraft("", "Як-52", 1035, 3, 1, 270, 200, 55, 0));

            // пассажирские

            listAirModelPas.Add(new PassengerAircraft("", "Аккорд-201", 1330, 10, 2, 200, 280, 20, 0, 6));
            listAirModelPas.Add(new PassengerAircraft("", "Л-42",       800,  10, 1, 210, 290, 22, 0, 4));
            listAirModelPas.Add(new PassengerAircraft("", "Ан-140",   12810,  5,  5, 550, 4500, 800, 0, 52));
            listAirModelPas.Add(new PassengerAircraft("", "Л-42",       800,  13, 3, 300, 290, 22, 0, 8));
            listAirModelPas.Add(new PassengerAircraft("", "Ту-334", 18700, 4, 10, 820, 10100, 2300, 0, 102));
            listAirModelPas.Add(new PassengerAircraft("", "Boeing 777", 263080, 13, 10, 805, 117000, 7800, 0, 350));
            listAirModelPas.Add(new PassengerAircraft("", "SSJ 100", 24250, 6, 8, 830, 15805, 2000, 0, 120));

            // военные
            listAirModelWar.Add(new WarAircraft("", "МиГ-29", 11000, 3, 10, 850, 3000, 800, 0));
            listAirModelWar.Add(new WarAircraft("", "МиГ-35", 13500, 3, 10, 1000, 3000, 800, 0));
            listAirModelWar.Add(new WarAircraft("", "Су-57", 18500, 3, 10, 2000, 11100, 3500, 0));

            // грузовые 
            listAirModelCar.Add(new CargoAircraft("", "Ан-124 «Руслан»", 178400, 10, 9, 800, 212350, 16000, 0, 100000));
            listAirModelCar.Add(new CargoAircraft("", "Ту-330", 25000, 9, 3, 800, 35000, 3500, 0, 35000));
            listAirModelCar.Add(new CargoAircraft("", "Basler BT-67", 7144, 5, 2, 380, 2350, 335, 0, 3550));
        }

        private void ListViewPorts_Click(object sender, EventArgs e)
        {
            //listStoreView.FocusedItem.Text
            viewListPAirs(listViewPorts.FocusedItem.Index);

        }
    }
}
