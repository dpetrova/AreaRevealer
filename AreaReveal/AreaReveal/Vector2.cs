﻿using System;

namespace AreaReveal
{
    public class Vector2
    {
        private float x;
        private float y;        

        public Vector2(float xCoord, float yCoord)
        {
            this.X = xCoord;
            this.Y = yCoord;            
        }

        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
                
        
        public override string ToString()
        {
            return String.Format("Position({0},{1})", this.X, this.Y);
        }

    }
}
