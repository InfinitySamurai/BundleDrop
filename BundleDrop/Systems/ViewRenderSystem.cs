using System;
using Entitas;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace BundleDrop{
    public class ViewRenderSystem : IExecuteSystem, ISetPool {

        Group group;
        SpriteBatch spriteBatch;
        Dictionary<string, Texture2D> content;

        public ViewRenderSystem(SpriteBatch sb, Dictionary<string, Texture2D> content) {
            spriteBatch = sb;
            this.content = content;
        }

        public void Execute() {
            foreach(Entity e in group.GetEntities()) {

                Texture2D sprite = e.view.sprite;

                float width = sprite.Width;
                float height = sprite.Height;
                float scale = e.view.scale;

                Vector2 position = new Vector2(e.position.x, e.position.y);
                Vector2 centre = new Vector2(width / 2, height / 2);

                Color c = e.view.color;

                float rotation = 0;

                if(e.hasAngle) {
                    rotation = e.angle.angle;
                }

                spriteBatch.Draw(sprite, position, null, c, rotation, centre, scale, SpriteEffects.None, 0f);
    }
        }

        public void SetPool(Pool pool) {
            group = pool.GetGroup(Matcher.AllOf(CoreMatcher.View, CoreMatcher.Position));
        }
    }
}
