namespace Laba_4_Inheritance
{

    /*Для раздачи транспортных средств (количество колес)
-Велосипеды (тип (горный, городской, детский), радиус колес)
-Автомобили (тип (автобус, грузовик, внедорожник, легковая), объем двигателя, количество дверей),
-Самолеты (тип двигателя, максимальная высота полета)*/

    public partial class Form1 : Form
    {
        List<Vehicle> vehiclesList = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            //vehiclesList.Clear();
            //for (var i = 0; i < 10; ++i)
            //{
            //    // классно да, список типа Fruit, а кладем Mandarin
            //    // вот она: "сила наследования"
            //    vehiclesList.Add(new Bike());
            //}
            vehiclesList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 13; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то мандарин
                        vehiclesList.Add(Bike.Generate());
                        break;
                    case 1: // если 1 то виноград
                        vehiclesList.Add(Car.Generate());
                        break;
                    case 2: // если 2 то арбуз
                        vehiclesList.Add(Plane.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();

            txtQueue.Text = AppdateAutomate();
        }

        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int bikeCount = 0;
            int carCount = 0;
            int planeCount = 0;

            // пройдемся по всему списку
            foreach (var vehicle in vehiclesList)
            {
                // помните, что в списки у нас лежат фрукты,
                // то есть объекты типа Fruit
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (vehicle is Bike) // читается почти как чистый инглиш, "если fruit есть Мандарин"
                {
                    bikeCount += 1;
                }
                else if (vehicle is Car)
                {
                    carCount += 1;
                }
                else if (vehicle is Plane)
                {
                    planeCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Велосипед\tАвтомобиль\tСамолёт"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", bikeCount, carCount, planeCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (vehiclesList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var vehicle = vehiclesList[0];
            vehiclesList.RemoveAt(0);

            // ЗАМЕНИЛ НАШИ if`ы
            txtOut.Text = vehicle.GetInfo();

            // обновим информацию о количестве товара на форме
            ShowInfo();

            txtQueue.Text = AppdateAutomate();
        }

        private string AppdateAutomate()
        {
            string str = "";

            foreach (var vehicle in vehiclesList)
            {
                switch (vehicle)
                {
                    case Bike:
                        str += "Велосипед\n";
                        break;
                    case Car:
                        str += "Автомобиль\n";
                        break;
                    case Plane:
                        str += "Самолёт\n";
                        break;
                }
            }
            return str;
        }
    }
}
