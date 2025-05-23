﻿using System;
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
        static uint _idCounter = 1000;

        public ClothingItem(string user_id, string color, string name, string[] seasson, bool is_favorite, string usage, string type, string brand, int cost, string _size, bool is_casual) : this(name, is_casual)
        {
            _uint = IdCounter++;
            this.user_id = user_id;
            this.Cost = cost;
            this.Usage = (Usage)Enum.Parse(typeof(Usage), usage);
            this.color = color;
            this.Size = (Sizes)Enum.Parse(typeof(Sizes), _size);
            this.seasons = seasson;
            this.is_favorite = is_favorite;
            this.brand = brand;
            this.type = type;

        }

        public ClothingItem() { }
        public ClothingItem(string name, bool is_casual)
        {
            this.name = name;
            this.is_casual = is_casual;
        }

        public int Cost{get => cost;set => cost = value; }
        internal Usage Usage{get => usage;set => usage = value;}

        internal Sizes Size{get => _size;set => _size = value;}
        public string User_id{get => user_id;set => user_id = value;}
        public static uint IdCounter { get => _idCounter; set => _idCounter = value; }
        public string Name { get => name;}
        public string Color { get => color;}
        public string Type { get => type;}
        public string Brand { get => brand;}
        public string[] Seasons { get => seasons;}
        public bool Is_favorite { get => is_favorite;}
        public bool Is_casual { get => is_casual;}
    }
}
