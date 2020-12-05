using System;



namespace Rectangle_Class10._3
{
    class RectangleTest
    {
        private float length = 1;
        private float width = 1;

        public RectangleTest(float length, float width)
        {
            Length = length;
            Width = width;
        }
        public float Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= 0.0f || value > 20.0f)
                    this.length = 1.0f;
                else
                    this.length = value;
            }
        }

        public float Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0.0f || value > 20.0f)
                    this.width = 1.0f;
                else
                    this.width = value;
            }
        }

        public float Perimeter
        {
            get
            {
                return ((Length + Width) * 2);
            }
        }
       
        public float Area
        {
            get
            {
                return (Length * Width); 
            }
        }

        public override string ToString()
        {
            return string.Format("Perimeter is {0:F2} and the area is {1:F2}", Perimeter, Area);
        }
    }

}

