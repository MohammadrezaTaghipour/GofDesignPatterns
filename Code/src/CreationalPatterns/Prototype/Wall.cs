using Prototype;

namespace Prototype
{
    public class Wall : MapSite
    {
        public Wall()
        { }

        public virtual Wall Clone()
        {
            return new Wall();
        }
    }
}
