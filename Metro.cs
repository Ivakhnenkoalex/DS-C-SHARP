using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Metro
{
    public class Station
    {
        public string name;
        public string color;
        public Line line;
        public bool isWheelchairAccessible;
        public bool hasParkAndRide;
        public bool hasNearbyCableCar;
        public List<Station> transfers;
        public Station(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool isWheelchairAccessibl()
        {
            return isWheelchairAccessible;
        }
        public bool hasParkAndRid()
        {
            return hasParkAndRide;
        }
        public bool hasNearbyCableCa()
        {
            return hasNearbyCableCar;
        }
        public string GetLineName()
        {
            return line.GetName();
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }



        
    }







    public class Line
    {
        List<Station> stations;
        string name;
        string color;

        public Line(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station GetStation(string name)
        {
            foreach(Station i in stations)
            {
                if (i.GetName() == name)
                {
                    return i;
                }
            }
            return null;
        }
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;

        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }


        public void AddStation(string name,string color)
        {
            Station neww = new Station(name, color);
        }

        public void RemoveStation(string name)
        {
            foreach (Station i in stations)
            {
                if (i.GetName() == name)
                {
                    i.SetName("");
                }
            }
        }

        public List<Station> GetStationList()
        {
            return stations;
        }


    }




    public class Metro
    {
        public string city;
        public List<Line> lines;
        public Metro(string city)
        {
            this.city = city;
        }
        public string GetCity()
        {
            return city;
        }
        public void AddLine(string name, string color)
        {
            Line line = new Line(name, color);
            lines.Add(line);
        }

        public void RemoveLine(string name)
        {
            foreach (Line i in lines)
            {
                if (i.GetName() == name)
                {
                    i.SetName("");
                }
            }
        }
        public Station FindStation(string name,string lineName)
        {
            foreach (Line i in lines)
            {
                if (i.GetName() == lineName)
                {
                    return i.GetStation(name);
                }
            }
            return null;
        }
        public List<Station> GetStationList (string name)
        {
            foreach (Line i in lines)
            {
                if (i.GetName() == name)
                {
                    return i.GetStationList();
                }
            }
            return null;
        }

        public void LoadStationFromFile(string FileName)
        {

        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
