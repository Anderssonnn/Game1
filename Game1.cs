using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //KOmentar

        Texture2D player;
        Vector2 playerPos = new Vector2(200, 200);

        Texture2D enemy;
        Vector2 enemyPos = new Vector2(1700, 200);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 1080;
            graphics.PreferredBackBufferWidth = 1920;

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
            player = this.Content.Load<Texture2D>("xwing");
            enemy = this.Content.Load<Texture2D>("onionenemy");
            // TODO: use this.Content to load your game content here 
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Player

            if (Keyboard.GetState().IsKeyDown(Keys.Left) && playerPos.X > 0)
            {
                playerPos.X = playerPos.X - 5;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right) && playerPos.X + player.Width < 1920)
            {
                playerPos.X = playerPos.X + 5;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up) && playerPos.Y > 10)
            {
                playerPos.Y = playerPos.Y - 5;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down) && playerPos.Y + player.Height < 1050)
            {
                playerPos.Y = playerPos.Y + 5;
            }

            // Enemy
            if (enemyPos.X + enemy.Width < 1920)
            {
                enemyPos.X -= 5;
            }


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Brown);

            // TODO: Add your drawing code here.
            spriteBatch.Begin();
            spriteBatch.Draw(player,playerPos, Color.White);
            spriteBatch.Draw(enemy, enemyPos, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
