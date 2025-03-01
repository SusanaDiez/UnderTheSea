﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game_UnderTheSea
{
    class Fangs : Sprite
    {
        public Fangs(ContentManager contentManager) : this(contentManager, new Point())
        {

        }

        public Fangs(ContentManager contentManager, Point location) : base("Canine", location, new Point(50))
        {
            this.LoadContent(contentManager);
            this.Location = new Point(this.Location.X - 50, this.Location.Y + 80);
        }

        public void MoveLeft()
        {
            this.Location = new Point(this.Location.X - 10, this.Location.Y);
        }
    }
}
