﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        Sprite sprite;
        AABB hitbox;
        turrent turrent;
        public Tank(float x, float y) : base(x,y)
        {
            X = x;
            Y = y;

            sprite = new Sprite("GraphicalTestApp/Assets/topdowntanks/PNG/Tanks/tankBlue.png");
            
            AddChild(sprite);
            hitbox = new AABB(sprite.Width, sprite.Height);
            AddChild(hitbox);
            turrent = new turrent(0, 0);
            AddChild(turrent);


            OnUpdate += moveup;
            OnUpdate += movedown;
            OnUpdate += rotateleft;
            OnUpdate += rotateright;
        }

        public void testrotate(float deltatime)
        {
            turrent.Rotate(1f * deltatime);
        }

        public void moveup(float deltatime)
        {
            if(Input.IsKeyDown(87)) //W
            {
                Vector3 facing = new Vector3(Getm12, Getm11, 0);

                XAcceleration = facing.x * -50;
                YAcceleration = facing.y * -50;
            }
           else if(Input.IsKeyReleased(87)) //W
            {

                XAcceleration = 0;
                XVelocity = 0;

                YAcceleration = 0;
                YVelocity = 0;
            }
        /*    if (YVelocity > .01f)
            {
                YVelocity = .01f;
                    } */
        }

        public void movedown(float deltatime)
        {
            if (Input.IsKeyDown(83))
            {
                Vector3 facing = new Vector3(Getm12, Getm11, 0) *50;

                XAcceleration = facing.x;
                YAcceleration = facing.y;
            }
            else if (Input.IsKeyReleased(83))
            {
                XAcceleration = 0;
                XVelocity = 0;
                YAcceleration = 0;
                YVelocity = 0;
            }
            ////if (YVelocity < -.01f)
            ////{
            ////    YVelocity = -.01f;
            ////}
        }

        public void rotateleft(float deltatime)
        {
            if(Input.IsKeyDown(65) )
            {
                Rotate(-1f * deltatime);
            }
            else if (Input.IsKeyReleased(65))
            {
            }
        }

        public void rotateright(float deltatime)
        {
            if (Input.IsKeyDown(68))
            {
                Rotate(1f * deltatime);
            }
            else if (Input.IsKeyReleased(68))
            {
            }
           

        }
        
    }
}
