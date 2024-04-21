namespace Laba_4_Inheritance
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehiclesList = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            //this.vehiclesList.Clear();
            //for (var i = 0; i < 10; ++i)
            //{
            //    // классно да, список типа Fruit, а кладем Mandarin
            //    // вот она: "сила наследования"
            //    this.vehiclesList.Add(new Bike());
            //}
            this.vehiclesList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то мандарин
                        this.vehiclesList.Add(Bike.Generate());
                        break;
                    case 1: // если 1 то виноград
                        this.vehiclesList.Add(Car.Generate());
                        break;
                    case 2: // если 2 то арбуз
                        this.vehiclesList.Add(Plane.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int bikeCount = 0;
            int carCount = 0;
            int planeCount = 0;

            // пройдемся по всему списку
            foreach (var vehicle in this.vehiclesList)
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
            if (this.vehiclesList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var fruit = this.vehiclesList[0];
            this.vehiclesList.RemoveAt(0);

            // ЗАМЕНИЛ НАШИ if`ы
            txtOut.Text = fruit.GetInfo();

            // обновим информацию о количестве товара на форме
            ShowInfo();
        }
    }
}
