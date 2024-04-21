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
            //    // ������� ��, ������ ���� Fruit, � ������ Mandarin
            //    // ��� ���: "���� ������������"
            //    this.vehiclesList.Add(new Bike());
            //}
            this.vehiclesList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
                {
                    case 0: // ���� 0, �� ��������
                        this.vehiclesList.Add(Bike.Generate());
                        break;
                    case 1: // ���� 1 �� ��������
                        this.vehiclesList.Add(Car.Generate());
                        break;
                    case 2: // ���� 2 �� �����
                        this.vehiclesList.Add(Plane.Generate());
                        break;
                        // ��������� ������ ����� ������������
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            // ������� �������� ��� ������ ���
            int bikeCount = 0;
            int carCount = 0;
            int planeCount = 0;

            // ��������� �� ����� ������
            foreach (var vehicle in this.vehiclesList)
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
            if (this.vehiclesList.Count == 0)
            {
                txtOut.Text = "����� Q_Q";
                return;
            }

            var fruit = this.vehiclesList[0];
            this.vehiclesList.RemoveAt(0);

            // ������� ���� if`�
            txtOut.Text = fruit.GetInfo();

            // ������� ���������� � ���������� ������ �� �����
            ShowInfo();
        }
    }
}
