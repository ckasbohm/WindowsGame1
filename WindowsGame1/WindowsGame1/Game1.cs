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
        private Texture2D ship;
        private Texture2D shuttle;
        private Texture2D mars;
        private Texture2D walkSheet1;
        private SpriteFont font;
        private int score = 0;
        private AnimatedSprite1 animatedSprite;

        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //use this.Content to load your game content here


            ship = Content.Load<Texture2D>("ship");
            shuttle = Content.Load<Texture2D>("shuttle");
            mars= Content.Load<Texture2D>("mars");
            font = Content.Load<SpriteFont>("SpriteFont1");
            walkSheet1 = Content.Load<Texture2D>("walkSheet1");
            animatedSprite = new AnimatedSprite1(walkSheet1, 4, 4);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            score++;
            animatedSprite.Update();
        
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Crimson);

            // TODO: Add your drawing code here




            spriteBatch.Begin();

            spriteBatch.Draw(mars, new Rectangle(0, 0, 800, 480), Color.White);

            //spriteBatch.Draw(ship, new Vector2(450, 240), Color.White);

           // spriteBatch.Draw(shuttle, new Vector2(450, 240), Color.White);

            spriteBatch.DrawString(font, "Score: "+ score, new Vector2(100,100),Color.WhiteSmoke);


            spriteBatch.End();

            animatedSprite.Draw(spriteBatch, new Vector2(400, 200));


            base.Draw(gameTime);
        }
    }
}
