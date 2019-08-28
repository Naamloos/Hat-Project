using Hat_Project.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hat_Project.Actors
{
    public class Player : Renderable
    {
        // Think of some way to load in textures.
        public Player(Texture2D tex) : base(tex, new Vector2(25, 25), new Vector2(25, 25))
        {

        }

        public override void Draw(GameTime gameTime, SpriteBatch sb)
        {
            base.Draw(gameTime, sb);
        }

        public override void Update(GameTime gameTime)
        {
            // test movement, kinda.
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                this.Location.X += 1;
            }


            base.Update(gameTime);
        }
    }
}
