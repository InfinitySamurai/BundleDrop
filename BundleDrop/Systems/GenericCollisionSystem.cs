using System;
using Entitas;
using Microsoft.Xna.Framework;

namespace BundleDrop {
    public class GenericCollisionSystem : IExecuteSystem, ISetPool {

        Group group;

        public void Execute() {
            var entities = group.GetEntities();
            int entityNumber = entities.Length;

            for(int i = 0; i < entityNumber; i++) {
                for(int j = i+1; j < entityNumber; j++) {
                    Entity e1 = entities[i];
                    Vector2 e1Pos = new Vector2(e1.position.x, e1.position.y);
                    Entity e2 = entities[j];
                    Vector2 e2Pos = new Vector2(e2.position.x, e2.position.y);

                    float minDistance = e1.boundingCircle.radius + e2.boundingCircle.radius;
                    float actualDistance = Vector2.Distance(e1Pos, e2Pos);

                    if(actualDistance < minDistance) {
                        if(!e1.hasCollision)
                            e1.AddCollision(e1, e2);
                    }

                }
            }
        }

        public void SetPool(Pool pool) {
            group = pool.GetGroup(Matcher.AllOf(CoreMatcher.BoundingCircle, CoreMatcher.Position));
        }
    }
}
