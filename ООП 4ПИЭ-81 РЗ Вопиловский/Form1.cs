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
    List<WarAircraft> listAirModelWar = new List<WarAircraft>(); // список военных самолетов
    List<PassengerAircraft> listAirModelPas = new List<PassengerAircraft>(); // список пассажирских самолетов
    List<CargoAircraft> listAirModelCar = new List<CargoAircraft>(); // список грузовых самолетов
    List<WalkingAircraft> listAirModelWal = new List<WalkingAircraft>(); // список прогулочных самолетов
    List<Airport> listAirports = new List<Airport>(); // список аэропортов
    List<Flight> listFlights = new List<Flight>();// список рейсов
    List<Crash> listCrash = new List<Crash>();// список крушений
    StepTime dispStepTime;  // объект класса StepTime

    public Form1() // инициализация форма
    {
      InitializeComponent();
      initListAirModelDefault();
      initListAirports();
      initAirs();
      dispStepTime = new StepTime(listAirports, listFlights, listCrash);
      initComboBoxPort();
      viewListAirports();
      viewListPAirs(0);
      viewListFlights();
    }

    public void initComboBoxPort()  // инициализация выпадываюшего списка
    {
      for (int i = 0; i < listAirports.Count;i++)
      {
        comboBoxPort.Items.Add(listAirports[i].Name);
      }
      comboBoxPort.SelectedIndex = 0;
      comBoxFlightTyp.SelectedIndex = 4;
      comBoxPortTyp.SelectedIndex = 4;
    }
    public void upViewList() // обновление списков
    {
      viewListAirports();
      viewListPAirs(comboBoxPort.SelectedIndex);
      viewListFlights();
      viewListCrash();
      labelSTimeInfo.Text = "Текуший шаг: " + dispStepTime.STime;
    }
    public void initAirs()  // инициализация списка самолетов (Рандом)
    {
      Random rnd = new Random();
      for (int pId=0; pId < listAirports.Count; pId++)
      {
        int maxAir = rnd.Next(listAirports[pId].MaxDocks*2/3, listAirports[pId].MaxDocks);
        for (int aId = 0; aId < maxAir; aId++)
        {
          int typeAir = rnd.Next(6); // соотношение рандома воен./пасс./груз./прог. => 1/2/2/1
          if (listAirports[pId].Type==0) { typeAir = 0; }  //если аэропорт военный, самолеты только военные
          switch (typeAir)
          {
            case 0: // военные самолеты 
              listAirports[pId].addAirInDock(new WarAircraft(listAirModelWar[rnd.Next(listAirModelWar.Count)], "WAR-"+ rnd.Next(1000)));
              break;
            case 1: // пассажирские самолеты 
            case 2: // больше пассажирских самолетов
              listAirports[pId].addAirInDock(new PassengerAircraft(listAirModelPas[rnd.Next(listAirModelPas.Count)], "PAS-" + rnd.Next(1000)));
              break;
            case 3: // грузовые самолеты 
            case 4: // больше грузовых самолетов
              listAirports[pId].addAirInDock(new CargoAircraft(listAirModelCar[rnd.Next(listAirModelCar.Count)], "CAR-" + rnd.Next(1000)));
              break;
            case 5: // прогулочные самолеты 
              listAirports[pId].addAirInDock(new WalkingAircraft(listAirModelWal[rnd.Next(listAirModelWal.Count)], "WAL-" + rnd.Next(1000)));
              break;
          }
        }
      }
    }
    public void initListAirports()  // инициализация списка аэропортов
    {
      // Airport(string name , int maxDocks, int x, int y, int type, , List<Flight> listFlights, List<Airport> listAirports)
      listAirports.Add(new Airport("Центральный", 10, 5000, 5000, 1, listFlights, listAirports));
      listAirports.Add(new Airport("Северный", 10, 5000, 6000, 1, listFlights, listAirports));
      listAirports.Add(new Airport("южный", 10, 5000, 4000, 1, listFlights, listAirports));
      listAirports.Add(new Airport("восточный", 10, 6000, 5000, 1, listFlights, listAirports));
      listAirports.Add(new Airport("западный", 10, 4000, 5000, 1, listFlights, listAirports));
      listAirports.Add(new Airport("Сев-Зап", 5, 4500, 5500, 1, listFlights, listAirports));
      listAirports.Add(new Airport("Сев-Вос", 5, 5500, 5500, 0, listFlights, listAirports));
      listAirports.Add(new Airport("Юг-Зап", 5, 4500, 4500, 0, listFlights, listAirports));
      listAirports.Add(new Airport("Юг-Вос", 5, 5500, 4500, 1, listFlights, listAirports));
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
      listViewPortAirs.Items.Clear(); // Очистить список самолетов
      int type = comBoxPortTyp.SelectedIndex;
      for (int i = 0; i < port.MaxDocks; i++)
      {
        Docks dock = port.getAirDocks(i);
        try
        {
            if ((type != 4) && (type != dock.Board.Type)) { continue; }
        }
        catch
        {
            continue;
        }
                
        ListViewItem newAir = new ListViewItem(Convert.ToString(i));
        if ((dock.Status != 0)&&(dock.Board != null)) {
          newAir.SubItems.Add(dock.Board.Name + " " + dock.Board.Model);
          switch (dock.Board.Type)
          {
            case 3:
              newAir.SubItems.Add("Пас.");
              newAir.SubItems.Add(Convert.ToString(dock.Board.MaxPassenger) + " пас");
              break;
            case 2:
              newAir.SubItems.Add("Груз");
              newAir.SubItems.Add(Convert.ToString(dock.Board.MaxCargo) + " кг");
              break;
            case 1:
              newAir.SubItems.Add("Прог");
              newAir.SubItems.Add("----");
              break;
            case 0:
              newAir.SubItems.Add("Воен");
              newAir.SubItems.Add("----");
              break;
          }
          switch (dock.Status)
          {
            case 2:
              newAir.SubItems.Add("Готов");
              break;
            case 1:
              newAir.SubItems.Add("Серв. " + Convert.ToString(dock.ServiceTime));
              break;
          }
        } else
        {
          newAir.SubItems.Add("Док свободен");
        }
        listViewPortAirs.Items.Add(newAir);
      }
      labelPortInfo.Text = "Отправленно: " + port.SendPassengers + " пасс. " + port.SendCargo + " кг груза | Принято: "
          + port.GetPassengers + " пасс. " + port.GetCargo + " кг груза";
    }
    public void viewListCrash()// отображение списка крушений самолетов
    {
      listViewCrash.Items.Clear(); // Очистить список рейсов
      int allPassenger = 0, allCargo = 0;
      for (int i = listCrash.Count-1; i >=0 ; i--)
      {
        ListViewItem newCrash = new ListViewItem(Convert.ToString(i));
        newCrash.SubItems.Add(listCrash[i].Board.Name + " "+ listCrash[i].Board.Model);
        newCrash.SubItems.Add(Convert.ToString(listCrash[i].X) );
        newCrash.SubItems.Add(Convert.ToString(listCrash[i].Y));
        newCrash.SubItems.Add(listCrash[i].Start.Name + "=>" + listCrash[i].Target.Name);
        newCrash.SubItems.Add(Convert.ToString(listCrash[i].STime));
        switch (listCrash[i].Board.Type)
        {
          case 3:
            newCrash.SubItems.Add(Convert.ToString(listCrash[i].Board.Passenger) + " пас.");
            allPassenger = allPassenger + listCrash[i].Board.Passenger;
            break;
          case 2:
            newCrash.SubItems.Add(Convert.ToString(listCrash[i].Board.Cargo) + " кг");
            allCargo = allCargo + listCrash[i].Board.Cargo;
            break;
          default:
            newCrash.SubItems.Add("---");
            break;
        }
        listViewCrash.Items.Add(newCrash);
      }
      labelCrashInfo.Text = "Погибло пассажиров: " + allPassenger + "чел., потеряно  груза: " + allCargo + "кг, в "+ listCrash.Count+ " упавших самолетов";
    }   
    public void viewListFlights()   //  отображение списка рейсов
    {
    listViewFlights.Items.Clear(); // Очистить список рейсов
    double maxFlightTime;
    int type = comBoxFlightTyp.SelectedIndex;
    int allPassenger = 0, allCargo = 0, kAir = 0;
    try
    {
          maxFlightTime = Convert.ToDouble( tBoxFlightMaxT.Text);
    }
    catch
    {
          maxFlightTime = 100;
    }
    for (int i =0; i < listFlights.Count; i++ )
      {
        if ((type != 4) && (type != listFlights[i].Board.Type)) {  continue; }
        if (maxFlightTime < listFlights[i].FlightTime ) {  continue; }
        ListViewItem newFlight = new ListViewItem(Convert.ToString(i));
        newFlight.SubItems.Add(listFlights[i].Board.Name + " "+ listFlights[i].Board.Model);
        newFlight.SubItems.Add(Convert.ToString(listFlights[i].X));
        newFlight.SubItems.Add(Convert.ToString(listFlights[i].Y));
        newFlight.SubItems.Add(Convert.ToString(listFlights[i].range));
        newFlight.SubItems.Add(Convert.ToString(listFlights[i].leftToFly));
        newFlight.SubItems.Add(Convert.ToString(Math.Round(listFlights[i].FlightTime, 2)));
        newFlight.SubItems.Add(listFlights[i].Start.Name + "=>"+ listFlights[i].Target.Name);
        string cargo = "";
        switch (listFlights[i].Board.Type)
        {
          case 3:
            cargo = Convert.ToString(listFlights[i].Board.Passenger) + " пас.";
            allPassenger = allPassenger + listFlights[i].Board.Passenger;
            break;
          case 2:
            cargo = Convert.ToString(listFlights[i].Board.Cargo) + " кг";
            allCargo = allCargo + listFlights[i].Board.Cargo;
            break;
          case 1:
            cargo = "Турист";
            break;
          case 0:
            cargo = "АРМ";
            break;
        }
        newFlight.SubItems.Add(cargo);
        listViewFlights.Items.Add(newFlight);
        kAir++;
      }
      switch (type) {
        case 4:
          labelFlightInfo.Text = "Самолетов: " + kAir + "   || Пассажиров: " + allPassenger + "   || Груза: " + allCargo + "кг";
          break;
        case 3:
          labelFlightInfo.Text = "Пассажирских самолетов: " + kAir + "   || Пассажиров: " + allPassenger;
          break;
        case 2:
          labelFlightInfo.Text = "Грузовых самолетов: " + kAir +  "   || Груза: " + allCargo + "кг";
          break;
        case 1:
          labelFlightInfo.Text = "Прогулочных самолетов: " + kAir;
          break;
        case 0:
          labelFlightInfo.Text = "Военных самолетов: " + kAir ;
          break;
      }
    }
    public void initListAirModelDefault() // инициализация моделей по молчанию
    {
      //( name,  model,  weight, flightTime, serviceTime,  speed )
      // прогулочные модели
      listAirModelWal.Add(new WalkingAircraft("", "М-12 «Касатик»", 485, 30, 10, 38));
      listAirModelWal.Add(new WalkingAircraft("", "Су-26", 680, 20, 7, 62));
      listAirModelWal.Add(new WalkingAircraft("", "Як-52", 1035, 17, 5, 54));
      // пассажирские
      listAirModelPas.Add(new PassengerAircraft("", "Аккорд-201", 1330, 20, 22, 40, 6));
      listAirModelPas.Add(new PassengerAircraft("", "Л-42",       800,  20, 18, 42, 4));
      listAirModelPas.Add(new PassengerAircraft("", "Ан-140",   12810,  12,  10, 110, 52));
      listAirModelPas.Add(new PassengerAircraft("", "Л-42",       800,  25, 30, 60, 8));
      listAirModelPas.Add(new PassengerAircraft("", "Ту-334", 18700, 20, 10, 160,  102));
      listAirModelPas.Add(new PassengerAircraft("", "Boeing 777", 263080, 25, 19, 160,350));
      listAirModelPas.Add(new PassengerAircraft("", "SSJ 100", 24250, 12, 8, 160,  120));
      // военные
      listAirModelWar.Add(new WarAircraft("", "МиГ-29", 11000, 20, 10, 170 ));
      listAirModelWar.Add(new WarAircraft("", "МиГ-35", 13500, 25, 11, 200 ));
      listAirModelWar.Add(new WarAircraft("", "Су-57", 18500, 21, 12, 400 ));
      // грузовые 
      listAirModelCar.Add(new CargoAircraft("", "Ан-124 «Руслан»", 178400, 25, 22, 160,  100000));
      listAirModelCar.Add(new CargoAircraft("", "Ту-330", 25000, 24, 14, 160,  35000));
      listAirModelCar.Add(new CargoAircraft("", "Basler BT-67", 7144, 16, 11, 150,  3550));
    }
    private void ListViewPorts_Click(object sender, EventArgs e) // нажатие по индексу списка аэропортов
    {
      comboBoxPort.SelectedIndex = listViewPorts.FocusedItem.Index;
    }
    private void Button2_Click(object sender, EventArgs e)  // нажатие на кнопку шаг
    {
      dispStepTime.step();
      upViewList();
    }
    private void allUpdate(object sender, EventArgs e) // обновыть списки по событию
    {
      upViewList();
    }
  }
}
