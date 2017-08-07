using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontAngryChineseMan
{
    public class Player
    {
        private string color;
        public bool IsPlaying { get; set; }
        public string Name { get; set; }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                switch(value)
                {
                    case "Biały":
                        color = "White";
                        break;
                    case "Czarny":
                        color = "Black";
                        break;
                    case "Czerwony":
                        color = "Red";
                        break;
                    case "Niebieski":
                        color = "Blue";
                        break;
                    case "Zielony":
                        color = "Green";
                        break;
                    case "Żółty":
                        color = "Yellow";
                        break;
                }
            }
        }
        public bool? IsHuman { get; set; }

        public Player()
        {
            Name = String.Empty;
            Color = String.Empty;
            IsHuman = false;
            IsPlaying = false;
        }

        public void setPlayer(string name, string color, bool? human)
        {
            Name = name;
            Color = color;
            IsHuman = human;
        }

        public Player(Player pl)
        {
            this.Name = pl.Name;
            this.Color = pl.Color;
            this.IsHuman = pl.IsHuman;
        }
    }
}
