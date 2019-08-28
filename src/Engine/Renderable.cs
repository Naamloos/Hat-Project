using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hat_Project.Engine
{
    /// <summary>
    /// Renderable is a base class that provides basic methods for renderable objects.
    /// It is recommended to override the Draw and Update methods, and call to the base class after or before your code.
    /// </summary>
    public abstract class Renderable
    {
        /// <summary>
        /// Texture to render.
        /// </summary>
        public Texture2D Texture;
        /// <summary>
        /// Texture's X and Y sizes.
        /// </summary>
        public Vector2 Size;
        /// <summary>
        /// Texture's rendering location.
        /// </summary>
        public Vector2 Location;
        /// <summary>
        /// Texture's hitbox. This hitbox is relative to the texture's location. x0/y0 would mean at the texture's location.
        /// </summary>
        public Rectangle RelativeHitbox;

        /// <summary>
        /// Texture's global hitbox. This hitbox is relative to the screen.
        /// </summary>
        public Rectangle GlobalHitbox
        {
            get
            {
                return new Rectangle((int)Location.X + RelativeHitbox.X, (int)Location.Y + RelativeHitbox.Y, RelativeHitbox.Width, RelativeHitbox.Height);
            }
        }

        /// <summary>
        /// Constructs a new Renderable with a default hitbox.
        /// </summary>
        /// <param name="tex">Texture to assign to the renderable.</param>
        /// <param name="size">Size of this renderable.</param>
        /// <param name="location">Location of this renderable.</param>
        public Renderable(Texture2D tex, Vector2 size, Vector2 location)
        {
            Texture = tex;
            this.Size = size;
            this.Location = location;
            this.RelativeHitbox = new Rectangle(location.ToPoint(), size.ToPoint());
        }

        /// <summary>
        /// Updates this Renderable item.
        /// </summary>
        public virtual void Update(GameTime gameTime)
        {

        }

        /// <summary>
        /// Draws this Renderable item.
        /// </summary>
        public virtual void Draw(GameTime gameTime, SpriteBatch sb)
        {
            // This will render the current Texture to it's location with it's designated size.
            sb.Draw(Texture, new Rectangle(Location.ToPoint(), Size.ToPoint()), Color.White);
        }
    }
}
