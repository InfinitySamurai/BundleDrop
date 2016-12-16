using System;
using System.Collections.Generic;
using Entitas;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BundleDrop{
    public class BundleSpawnerSystem : IExecuteSystem {

        Texture2D sprite;
        Random random = new Random();
        List<Color> colors;

        public BundleSpawnerSystem(Texture2D sprite) {
            this.sprite = sprite;

            colors = new List<Color>();
            colors.Add(Color.White);
            colors.Add(Color.Gold);
            colors.Add(Color.Magenta);
            colors.Add(Color.RoyalBlue);
            colors.Add(Color.Green);
        }

        public void Execute() {

            int citem = random.Next(colors.Count);

            Color c = colors[citem];

            int xpos = random.Next(0, 800);
            int xspeed = random.Next(-10, 10);
            int yspeed = random.Next(1, 10);
            float rotation = (float)random.NextDouble()*0.5f;

            Entity e = Pools.sharedInstance.core.CreateEntity();
            e.AddAngle(0);
            e.AddPosition(xpos, 10);
            e.AddRotation(rotation);
            e.AddVelocity(xspeed, yspeed);
            e.AddView(sprite, 1, c);

        }

    }
}
