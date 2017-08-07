using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontAngryChineseMan
{
    class Pawn:Player
    {
        new public string Color { get; set; }
        public int FieldsToHome { get; set; }
        public string ActualField { get; set; }




        //public Pawn(string name, string color, bool? human) : base(name, color, human)
        //{
        //    Name = name;
        //    Color = color;
        //    IsHuman = human;
        //}

        public Pawn(Player pl):base(pl)
        {
            this.Color = pl.Color;
            FieldsToHome = 40;
            ActualField = "pleple";
        }
    }
}
