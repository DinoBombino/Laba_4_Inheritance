namespace Laba_4_Inheritance
{

    /*��� ������� ������������ ������� (���������� �����)
-���������� (��� (������, ���������, �������), ������ �����)
-���������� (��� (�������, ��������, �����������, ��������), ����� ���������, ���������� ������),
-�������� (��� ���������, ������������ ������ ������)*/

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
            //    // ������� ��, ������ ���� Fruit, � ������ Mandarin
            //    // ��� ���: "���� ������������"
            //    vehiclesList.Add(new Bike());
            //}
            vehiclesList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 13; ++i)
            {
                switch (rnd.Next() % 3) // ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
                {
                    case 0: // ���� 0, �� ��������
                        vehiclesList.Add(Bike.Generate());
                        break;
                    case 1: // ���� 1 �� ��������
                        vehiclesList.Add(Car.Generate());
                        break;
                    case 2: // ���� 2 �� �����
                        vehiclesList.Add(Plane.Generate());
                        break;
                        // ��������� ������ ����� ������������
                }
            }
            ShowInfo();

            txtQueue.Text = AppdateAutomate();
        }

        private void ShowInfo()
        {
            // ������� �������� ��� ������ ���
            int bikeCount = 0;
            int carCount = 0;
            int planeCount = 0;

            // ��������� �� ����� ������
            foreach (var vehicle in vehiclesList)
            {
                // �������, ��� � ������ � ��� ����� ������,
                // �� ���� ������� ���� Fruit
                // ������� ����� ��������� ����� ������ �����
                // �� � ������ ������ ����������, �� ���������� �������� ����� is
                if (vehicle is Bike) // �������� ����� ��� ������ ������, "���� fruit ���� ��������"
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

            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = "���������\t����������\t������"; // ����� ������, ����� ������ �� �����
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", bikeCount, carCount, planeCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (vehiclesList.Count == 0)
            {
                txtOut.Text = "����� Q_Q";
                return;
            }

            var vehicle = vehiclesList[0];
            vehiclesList.RemoveAt(0);

            // ������� ���� if`�
            txtOut.Text = vehicle.GetInfo();

            // ������� ���������� � ���������� ������ �� �����
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
                        str += "���������\n";
                        break;
                    case Car:
                        str += "����������\n";
                        break;
                    case Plane:
                        str += "������\n";
                        break;
                }
            }
            return str;
        }
    }
}
