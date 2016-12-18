using System;
using Entitas;

namespace BundleDrop {
    public sealed class IncrementTickSystem : ISetPools, IInitializeSystem, IExecuteSystem {

        Pools pools;

        public void Initialize() {
            pools.core.SetTick(0);
        }

        public void Execute() {
            pools.core.ReplaceTick(pools.core.tick.value + 1);
        }

        public void SetPools(Pools pools) {
            this.pools = pools;
        }
    }
}
