using System;


namespace unit04_greed.GreedGame.Casting
{
   
    public class Actor
    {
        private string text = "";
        private int fontSize = 15;
        private Color color = new Color(255, 255, 255); // white
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);

       
        public Actor()
        {
        }

        /// <returns>The color.</returns>
        public Color GetColor()
        {
            return color;
        }

        
        /// <returns>The font size.</returns>
        public int GetFontSize()
        {
            return fontSize;
        }

       
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return position;
        }

        /// <returns>The text.</returns>
        public string GetText()
        {
            return text;
        }

        
        /// <returns>The velocity.</returns>
        public Point GetVelocity()
        {
            return velocity;
        }

       
        /// <param name="maxX">The maximum x value.</param>
        /// <param name="maxY">The maximum y value.</param>
        public void MoveNext(int maxX, int maxY)
        {
            int x = ((position.GetX() + velocity.GetX()) + maxX) % maxX;
            int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
            position = new Point(x, y);
        }

        /// <param name="color">The given color.</param>
        /// <exception cref="ArgumentException">When color is null.</exception>
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

       
        /// <param name="fontSize">The given font size.</param>
        /// <exception cref="ArgumentException">
        /// When font size is less than or equal to zero.
        /// </exception>
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this.fontSize = fontSize;
        }

        
        /// <param name="position">The given position.</param>
        /// <exception cref="ArgumentException">When position is null.</exception>
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        
        /// <param name="text">The given text.</param>
        /// <exception cref="ArgumentException">When text is null.</exception>
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }

       
        /// <param name="velocity">The given velocity.</param>
        /// <exception cref="ArgumentException">When velocity is null.</exception>
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }

    }
}