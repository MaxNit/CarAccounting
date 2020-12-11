using System;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;

namespace Lab3Client
{
    public partial class Form1 : Form
    {

        private TcpClient client;

        private StreamReader reader;
        private StreamWriter writer;

        private bool isConnected;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 5555);

                HandleCommunication();
            } catch (SocketException)
            {
                Console.WriteLine("Server is not found");
            }

        }

        private void HandleCommunication()
        {
            reader = new StreamReader(client.GetStream(), Encoding.ASCII);
            writer = new StreamWriter(client.GetStream(), Encoding.ASCII);

            isConnected = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddCar_Click(object sender, EventArgs e)
        {

        }

        private void AddCar_Click_1(object sender, EventArgs e)
        {
            Car car = new Car(Name.Text, Model.Text, long.Parse(Price.Text));
            string carData = JsonSerializer.Serialize(car);

            ServerRequest request = new ServerRequest
            {
                ActionType = 0,
                Payload = carData
            };

            string data = JsonSerializer.Serialize(request);

            if (isConnected)
            {
                try
                {
                    writer.WriteLine(data);
                    writer.Flush();
                }
                catch (IOException)
                {

                }

            }

        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            ServerRequest request = new ServerRequest
            {
                ActionType = 1,
            };

            string data = JsonSerializer.Serialize(request);

            if (isConnected)
            {
                try
                {
                    writer.WriteLine(data);
                    writer.Flush();

                    string serverResponse = reader.ReadLine();
                    CarsArray cars = JsonSerializer.Deserialize<CarsArray>(serverResponse);

                    string output = "";

                    cars.Cars.ForEach(car =>
                    {
                        output += car.Name + " " + car.Model + " " + car.Price + "\r\n";
                    });

                    SearchAllOutput.Text = output;
                }
                catch (IOException)
                {

                }

            }

        }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            ServerRequest request = new ServerRequest
            {
                ActionType = 2,
                Payload = CarName.Text
            };

            string data = JsonSerializer.Serialize(request);

            if (isConnected)
            {
                try
                {
                    writer.WriteLine(data);
                    writer.Flush();

                    string serverResponse = reader.ReadLine();
                    CarsArray cars = JsonSerializer.Deserialize<CarsArray>(serverResponse);

                    string output = "";

                    cars.Cars.ForEach(car =>
                    {
                        output += car.Name + " " + car.Model + " " + car.Price + "\r\n";
                    });

                    SearchAllOutput.Text = output;
                }
                catch (IOException)
                {

                }

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ServerRequest request = new ServerRequest
            {
                ActionType = 3,
                Payload = CarName.Text
            };

            string data = JsonSerializer.Serialize(request);

            if (isConnected)
            {
                try
                {
                    writer.WriteLine(data);
                    writer.Flush();

                    string serverResponse = reader.ReadLine();
                    CarsArray cars = JsonSerializer.Deserialize<CarsArray>(serverResponse);

                    string output = "";

                    cars.Cars.ForEach(car =>
                    {
                        output += car.Name + " " + car.Model + " " + car.Price + "\r\n";
                    });

                    SearchAllOutput.Text = output;
                }
                catch (IOException)
                {

                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServerRequest request = new ServerRequest
            {
                ActionType = 4,
            };

            string data = JsonSerializer.Serialize(request);

            if (isConnected)
            {
                try
                {
                    writer.WriteLine(data);
                    writer.Flush();

                    string serverResponse = reader.ReadLine();
                    CarsArray cars = JsonSerializer.Deserialize<CarsArray>(serverResponse);

                    string output = "";

                    cars.Cars.ForEach(car =>
                    {
                        output += car.Name + " " + car.Model + " " + car.Price + "\r\n";
                    });

                    SearchAllOutput.Text = output;
                }
                catch (IOException)
                {

                }

            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Car newCar = new Car(NewName.Text, NewModel.Text, long.Parse(NewPrice.Text));
            EditWorkerRequest editWorkerRequest = new EditWorkerRequest
            {
                NewCar = newCar,
                OldName = OldName.Text
            };

            ServerRequest request = new ServerRequest
            {
                ActionType = 5,
                Payload = JsonSerializer.Serialize(editWorkerRequest)                
            };

            string data = JsonSerializer.Serialize(request);

            if (isConnected)
            {
                try
                {
                    writer.WriteLine(data);
                    writer.Flush();

                    string serverResponse = reader.ReadLine();
                    CarsArray cars = JsonSerializer.Deserialize<CarsArray>(serverResponse);

                    string output = "";

                    cars.Cars.ForEach(car =>
                    {
                        output += car.Name + " " + car.Model + " " + car.Price + "\r\n";
                    });

                    SearchAllOutput.Text = output;
                }
                catch (IOException)
                {

                }

            }

        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            client.GetStream().Close();
            client.Close();
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public long Price { get; set; }

        public Car(string name, string model, long price)
        {
            Name = name;
            Model = model;
            Price = price;
        }
    }

    class CarsArray
    {
        public List<Car> Cars { get; set; }
    }

    class ServerRequest
    {
        public int ActionType { get; set; }
        public string Payload { get; set; }
    }

    class ServerResponse
    {
        public string Response { get; set; }
    }

    class EditWorkerRequest
    {
        public string OldName { get; set; }
        public Car NewCar { get; set; }
    }

}
