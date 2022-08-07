using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_player
{
    class Player
    {
        public static List<string> List_positions = new List<string>() 
        {   "Center attacker",
            "Left attacker",
            "Right attacker",
            "Center midfielder", 
            "Left midfielder",
            "Right midfielder",
            "Center defender ",
            "Left defender",
            "Right defender ",
            "Goalkeeper"
        };

        public static List<string> filter = new List<string> 
        { 
            "All",
            "attacker",
            "midfielder",
            "defender",
            "goalkeeper"
        };

        public static string path_logo = @"T:\winform\project_team7\img\logo_bg\Logo_Bar.png";

        private string id;
        private string name;
        private string gender;
        private DateTime date;
        private string nationality;
        private string position;
        private string contract;
        private int salary;
        private string img_path;

        public Player()
        {
            id = "";
            name = "";
            gender = "";
            date = new DateTime(1990,01,01);
            Nationality = "";
            position = "";
            contract = "";
            salary = 0;
            img_path = path_logo;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Position { get => position; set => position = value; }
        public string Contract { get => contract; set => contract = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Img_path { get => img_path; set => img_path = value; }
    }
}
