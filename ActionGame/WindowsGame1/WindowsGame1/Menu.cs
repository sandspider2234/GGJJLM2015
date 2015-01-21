using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame1
{
    public class Menu
    {
        public Texture2D texture;
        Texture2D gameName, aboutTexture;
        Vector2 position, namePosition, aboutPosition;
        Rectangle rectangle, rectangle2;
        Color col = new Color(255, 255, 255, 255);
        Color col2 = new Color(255, 255, 255, 255);
        public Vector2 size, aboutSize;

        public Menu(Texture2D newTexture, GraphicsDevice graphics, Texture2D newTexture2, Texture2D newTexture3)
        {
            texture = newTexture;
            size = new Vector2(140, 140);
            aboutSize = new Vector2(200, 200);
            gameName = newTexture2;
            aboutTexture = newTexture3;

        }
        bool down;
        bool down2;
        public bool isClicked;
        public bool isClickedShop = false;
        public void Update(MouseState mouse)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            rectangle2 = new Rectangle((int)aboutPosition.X, (int)aboutPosition.Y, (int)aboutSize.X, (int)aboutSize.Y);
            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1);


            // mouse enter play button
            if (mouseRectangle.Intersects(rectangle))
            {
                if (col.A == 255) down = false;
                if (col.A == 0) down = true;
                if (down == true)
                {
                    col.A += 3;
                }
                else
                {
                    col.A -= 3;
                }
                if (mouse.LeftButton == ButtonState.Pressed) isClicked = true;
            }
            else if (col.A < 255)
            {
                col.A += 3;
                isClicked = false;
            }


            //mouse enter about label
            if (mouseRectangle.Intersects(rectangle2))
            {
                if (col2.A == 255) down2 = false;
                if (col2.A == 0) down2 = true;
                if (down2 == true)
                {
                    col2.A += 5;
                }
                else
                {
                    col2.A -= 5;
                }
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    isClickedShop = true;
                }
            }
            else if (col2.A < 255)
            {
                col2.A += 5;
                isClickedShop = false;
            }


        }
        public void SetPosition(Vector2 newPosition, Vector2 newNamePosition, Vector2 newAboutPosition)
        {
            position = newPosition;
            namePosition = newNamePosition;
            aboutPosition = newAboutPosition;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, col);
        }
        public void DrawMain(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(gameName, namePosition, Color.White);
            spriteBatch.Draw(aboutTexture, aboutPosition, col2);
        }

    }
}
