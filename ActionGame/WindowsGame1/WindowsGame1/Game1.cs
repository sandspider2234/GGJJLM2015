using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        Menu menu1;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 800;
            Content.RootDirectory = "Content";
        }



        public class SoundManager
        {
            public SoundEffect playerShootSound, explodeSound, menuSound;
            public Song bgMusic;
            public SoundManager()
            {
                playerShootSound = explodeSound = menuSound = null;
                bgMusic = null;
            }
            public void LoadContent(ContentManager Content)
            {
                playerShootSound = Content.Load<SoundEffect>("playershoot");
                explodeSound = Content.Load<SoundEffect>("explode");
                menuSound = Content.Load<SoundEffect>("epic1");
                bgMusic = Content.Load<Song>("theme");

            }

        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>

        protected override void Initialize()
        {
          

            base.Initialize();
        }

        protected override void LoadContent()
        {
          
            spriteBatch = new SpriteBatch(GraphicsDevice);
            menu1 = new Menu(Content.Load<Texture2D>("Start3"), graphics.GraphicsDevice, Content.Load<Texture2D>("coollogo_com-256261018"), Content.Load<Texture2D>("shop"));
            menu1.SetPosition(new Vector2(350, 300), new Vector2(50, 90), new Vector2(300, 430));
            
            
        }

       
        protected override void UnloadContent()
        {
         
        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
           
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

      
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
