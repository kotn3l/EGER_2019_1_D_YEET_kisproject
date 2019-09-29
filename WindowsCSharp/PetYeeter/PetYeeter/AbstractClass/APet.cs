using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetYeeter
{
    abstract class APet : IDrawable
    {
        
        private byte health;
        public byte Health
        {
            get { return health; }
            set {
                if (value >= 0)
                    health = value;
                else throw new Exception();
            }
        }

        private int hunger;
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }


        private bool dead;
        public bool Dead
        {
            get { return dead; }
            set {
                if (this.Health == 0)
                    dead = true;
                else dead = false;
            }
        }

        private string texturePath;
        public string TexturePath { get { return texturePath; }
            set {
                if (File.Exists(value))
                    texturePath = value;
                else throw new FileNotFoundException("File not found", value);
            }
        }

        private Point position;
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }


        public void Damage()
        {

        }
        public void Heal()
        {

        }

        public  void Display(Graphics g)
        {
            Image img = Image.FromFile(texturePath);
            g.DrawImage(img, new Point(this.Position.X * config.Default.drawingUnit,
                                       this.Position.Y * config.Default.drawingUnit));
        }

        public APet(string TexturePath, Point Position)
        {
            this.Dead = false;
            this.Health = 255;
            this.Hunger = 0;
            this.TexturePath = TexturePath;
            this.Position = Position;
        }

    }
}
