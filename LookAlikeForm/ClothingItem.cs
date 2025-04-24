using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LookAlikeForm
{
    enum Sizes
    {
        S = 1, M, L, XL, XXL, OS
    }
    enum Usage
    {
        NotInUse = 1, InSomeUses, MostlyUsed
    }
    internal class ClothingItem
    {
        Usage usage;
        Sizes _size;
        int cost;
        uint _uint;
        string[] seasons;
        string user_id, name, color, type, brand;
        bool is_favorite, is_casual;
        static uint _idCounter= 1000;

        public ClothingItem(string user_id, string color, string name, string[] seasson, bool is_favorite, int usage, string type, string brand, int cost, int _size, bool is_casual) : this(name, is_casual)
        {
            _uint = IdCounter++;
            this.user_id = user_id;
            this.Cost = cost;
            this.Usage = (Usage)usage;
            this.color = color;
            this.Size = (Sizes)_size;
            this.seasons = seasson;
            this.is_favorite = true;
            //this.name = name;
            this.brand = brand;
            this.type = type;
            //SetIsCasual(is_casual);

        }

        public ClothingItem() { }
        public ClothingItem(string name, bool is_casual)
        {
            this.name = name;
            this.is_casual = is_casual;
        }
        public void Print()
        {
         
        }


        public int Cost
        {
            get => cost;
            set
            {
                while (value <= 0)
                {
                    Console.Write("Please enter a postive price tag: ");
                    value = int.Parse(Console.ReadLine());
                }
                cost = value;
            }
        }
       

        internal Usage Usage
        {
            get => usage;
            set
            {
                int num_value = (int)value;
                while (num_value < 1 || num_value > 3)
                {
                    Console.Write("Please enter a number between 1-3 for the usage rate: ");
                    num_value = int.Parse(Console.ReadLine());
                }
                usage = (Usage)value;
            }
        }

        internal Sizes Size
        {
            get => _size;
            set => _size = value;
        }
        public string User_id
        {
            get => user_id;
            set => user_id = value;
        }
        public static uint IdCounter { get => _idCounter; set => _idCounter=value; }

        
       
      
    }
}
