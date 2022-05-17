using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace First_program
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D dinoTexture;
        Texture2D legoTexture;
        Texture2D robotTexture;
        Texture2D treeTexture;
        Texture2D velociTexture;
        Texture2D backgroundTexture;
        Rectangle backgRect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "My first Monogame Progect";
            _graphics.PreferredBackBufferWidth = 1900;
            _graphics.PreferredBackBufferHeight = 1000;
            backgRect = new Rectangle(0, 0, 1900, 1000);
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            legoTexture = Content.Load<Texture2D>("Lego Brick (1)");
            robotTexture = Content.Load<Texture2D>("Robot");
            treeTexture = Content.Load<Texture2D>("Tree (2)");
            velociTexture = Content.Load<Texture2D>("Velociraptor");
            backgroundTexture = Content.Load<Texture2D>("background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MediumVioletRed);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundTexture, backgRect, Color.White);

            _spriteBatch.Draw(dinoTexture, new Vector2(40, 40), Color.White);

            _spriteBatch.Draw(legoTexture, new Vector2(500, 700), Color.White);
            _spriteBatch.Draw(robotTexture, new Vector2(500, 425), Color.White);

            _spriteBatch.Draw(velociTexture, new Vector2(1000, 0), Color.White);
            _spriteBatch.Draw(treeTexture, new Vector2(800, 0), Color.White);
            //_spriteBatch.Draw(legoTexture, new Vector2(500, 500), Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);


        }
    }
}
