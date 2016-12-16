using System;
using Entitas;
using Microsoft.Xna.Framework.Graphics;

namespace BundleDrop.Systems {
    public class ViewRenderSystem : IExecuteSystem, ISetPool {

        Group group;

        public void Execute() {
            throw new NotImplementedException();
        }

        public void SetPool(Pool pool) {
            group = pool.GetGroup(Matcher.AllOf(CoreMatcher.View, CoreMatcher.Position));
        }
    }
}
