using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Entitas;
using System.Collections.Generic;
using System;

namespace BundleDrop {
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class BundleDrop : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Dictionary<string, Texture2D> sprites;
        SpriteFont font;
        Pools pools;
        Systems updateSystems;
        Systems renderSystems;

        public BundleDrop() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() {
            // TODO: Add your initialization logic here
            pools = Pools.sharedInstance;
            pools.SetAllPools();
            updateSystems = new Systems();
            renderSystems = new Systems();
            sprites = new Dictionary<string, Texture2D>();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            sprites["Bundle"] = Content.Load<Texture2D>("BundleBaby");

            CreateEntities();
            CreateSystems();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            updateSystems.Execute();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            renderSystems.Execute();
            spriteBatch.End();
            base.Draw(gameTime);
        }


    void CreateSystems() {
            renderSystems.Add(pools.core.CreateSystem(new ViewRenderSystem(spriteBatch, sprites)));

            updateSystems.Add(pools.core.CreateSystem(new SpinSystem()));
            updateSystems.Add(pools.core.CreateSystem(new MovementSystem()));
            updateSystems.Add(pools.core.CreateSystem(new BundleSpawnerSystem(sprites["Bundle"])));
        }

    void CreateEntities() {
            //var e = pools.core.CreateEntity().AddView(sprites["Bundle"], 1f, Color.White).AddPosition(20,20).AddAngle(0).AddRotation(0.05f).AddVelocity(1,1);
        }
    }
}
