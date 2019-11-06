﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_Projekt
{
    class Enemy : GameObject
    {
        private Random random;
        protected int health;



        public override void Update(GameTime gameTime)
        {
            Move(gameTime);
        }

        public override void LoadContent(ContentManager content)
        {

        }

        private void Move(GameTime gameTime)
        {
            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += ((velocity * speed) * deltaTime);
        }

        private void Respawn()
        {
            //velocity = todo: add player position
            speed = 100f;
            //position = new Vector2(random.Next(0,1000),random.Next(0,1000));
        }

    }
}