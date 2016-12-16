using Entitas;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BundleDrop {
    [Core]
    public class ViewComponent : IComponent{
        public Texture2D sprite;
        public float scale;
        public Color color;
    }
}
