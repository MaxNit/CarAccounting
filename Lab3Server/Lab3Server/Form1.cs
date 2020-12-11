using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;


namespace Lab3Server
{
    public partial class Form1 : Form
    {

        private bool isRunning;
        private TcpListener tcpListener;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeTcp()
        {
            tcpListener = new TcpListener(IPAddress.Any, 5555);
            tcpListener.Start();
            isRunning = true;

            LoopClients();
        }

        private void LoopClients()
        {

            while (isRunning)
            {
                TcpClient newClient = tcpListener.AcceptTcpClient();
                Thread thread = new Thread(new ParameterizedThreadStart(HandleClient));
                thread.Start(newClient);
            }

        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;

            StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            StreamReader streamReader = new StreamReader(client.GetStream(), Encoding.ASCII);

            bool isClientConnected = true;
            string clientData = null;

            while (isClientConnected)
            {
                clientData = streamReader.ReadLine();
                Console.WriteLine("Data: " + clientData);

                ServerRequest request = JsonSerializer.Deserialize<ServerRequest>(clientData);

                if (request.ActionType == 0)
                {
                    AddCar(request.Payload);
                } else if (request.ActionType == 1)
                {
                    GetCars(streamWriter);
                } else if (request.ActionType == 2)
                {
                    SearchCar(request.Payload, streamWriter);
                } else if (request.ActionType == 3)
                {
                    DeleteCar(request.Payload, streamWriter);
                } else if (request.ActionType == 4)
                {
                    SortByPrice(streamWriter);
                } else if (request.ActionType == 5)
                {
                    EditCar(request.Payload, streamWriter);
                }
            }
        }

        private void EditCar(string payload, StreamWriter clientWriter)
        {
            EditWorkerRequest request = JsonSerializer.Deserialize<EditWorkerRequest>(payload);
            Car newCar = request.NewCar;

            List<Car> cars = ReadCarsFromFile();

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Name.Equals(request.OldName))
                {
                    cars[i] = newCar;
                }
            }

            CarsArray arr = new CarsArray()
            {
                Cars = cars
            };

            clientWriter.WriteLine(JsonSerializer.Serialize(arr));
            clientWriter.Flush();

            string carsStr = JsonSerializer.Serialize(cars);

            carsStr = "";

            cars.ForEach(car =>
            {
                carsStr += JsonSerializer.Serialize(car) + "\n";
            });

            File.WriteAllText(@"C:\Users\Max\Downloads\Lab3_ris-master (1)\Lab3_ris-master\Lab3Server\text.txt", carsStr);
        }

        private void SortByPrice(StreamWriter clientWriter)
        {
            List<Car> cars = ReadCarsFromFile();

            IEnumerable<Car> query = cars.OrderBy(car => car.Price);
            cars = query.ToList();

            CarsArray arr = new CarsArray()
            {
                Cars = cars
            };

            clientWriter.WriteLine(JsonSerializer.Serialize(arr));
            clientWriter.Flush();
        }

        private void DeleteCar(string name, StreamWriter clientWriter)
        {
            List<Car> cars = ReadCarsFromFile();

            cars = cars.FindAll(car => !car.Name.Equals(name));

            CarsArray arr = new CarsArray()
            {
                Cars = cars
            };

            string carsStr = JsonSerializer.Serialize(arr);

            clientWriter.WriteLine(carsStr);
            clientWriter.Flush();

            carsStr = "";

            cars.ForEach(car =>
            {
                carsStr += JsonSerializer.Serialize(car) + "\n";
            });

            File.WriteAllText(@"C:\Users\Max\Downloads\Lab3_ris-master (1)\Lab3_ris-master\Lab3Server\text.txt", carsStr);
        }

        private void SearchCar(string payload, StreamWriter clientWriter)
        {
            List<Car> cars = ReadCarsFromFile();

            cars = cars.FindAll(car => car.Name.Contains(payload));

            CarsArray arr = new CarsArray()
            {
                Cars = cars
            };

            clientWriter.WriteLine(JsonSerializer.Serialize(arr));
            clientWriter.Flush();
        }

        private void GetCars(StreamWriter clientWriter)
        {
            List<Car> cars = ReadCarsFromFile();

            CarsArray arr = new CarsArray()
            {
                Cars = cars
            };

            clientWriter.WriteLine(JsonSerializer.Serialize(arr));
            clientWriter.Flush();
        }

        private void AddCar(string car)
        {
            FileStream fileStream = new FileStream(@"C:\Users\Max\Downloads\Lab3_ris-master (1)\Lab3_ris-master\Lab3Server\text.txt", FileMode.OpenOrCreate, FileAccess.Write);

            fileStream.Seek(0, SeekOrigin.End);

            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(car);
            streamWriter.Flush();
            fileStream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeTcp();
        }

        private List<Car> ReadCarsFromFile()
        {
            string line;
            List<Car> cars = new List<Car>();

            StreamReader reader = new StreamReader(@"C:\Users\Max\Downloads\Lab3_ris-master (1)\Lab3_ris-master\Lab3Server\text.txt");

            while ((line = reader.ReadLine()) != null)
            {
                cars.Add(JsonSerializer.Deserialize<Car>(line));
            }

            reader.Close();

            return cars;
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

    class ServerRequest
    {
        public int ActionType { get; set; }
        public string Payload { get; set; }
    }

    class ServerResponse
    {
        public string Response { get; set; }
    }

    class CarsArray
    {
        public List<Car> Cars { get; set; }
    }

    class EditWorkerRequest
    {
        public string OldName { get; set; }
        public Car NewCar { get; set; }
    }

}
