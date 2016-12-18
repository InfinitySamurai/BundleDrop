using System;
using Entitas;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace BundleDrop {
    public class FollowMouseSystem : IExecuteSystem, ISetPool {

        Group group;

        public void Execute() {
            Point mousePosition = Mouse.GetState().Position;

            foreach(Entity e in group.GetEntities()) {
                var position = e.position;
                position.x = mousePosition.X;
                position.y = mousePosition.Y;

                e.ReplacePosition(position.x, position.y);
            }



        }

        public void SetPool(Pool pool) {
            group = pool.GetGroup(Matcher.AllOf(CoreMatcher.FollowMouse, CoreMatcher.Position));
        }
    }
}
