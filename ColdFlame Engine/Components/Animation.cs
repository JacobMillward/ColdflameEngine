﻿using SFML.Graphics;
using System;
using System.Collections.Generic;

namespace ColdFlame
{
    public class Animation : Component
    {
        public List<SFML.Graphics.Sprite> spriteList = new List<SFML.Graphics.Sprite>();
        public int currentFrame { get; set; }
        public float frameRate { get; set; }
        public SFML.System.Clock clock = new SFML.System.Clock();
        public bool firstRun = true;
        public bool play = true;

        public Animation(List<SFML.Graphics.Sprite> list)
        {
            spriteList = list;
            currentFrame = 0;
        }

        public Animation(string imagePath, int frameWidth, int frameHeight, int frames, int xOffset = 0, int yOffset = 0, float frameRate = 24f)
        {
            this.frameRate = frameRate;

            currentFrame = 0;
            Texture t = new Texture(@imagePath);
            for(int i = 0; i < frames; i++)
            {
                SFML.System.Vector2i pos = new SFML.System.Vector2i(i * frameWidth, 0);
                SFML.System.Vector2i size = new SFML.System.Vector2i(frameWidth, frameHeight);
                spriteList.Add(new SFML.Graphics.Sprite(t, new IntRect(pos, size)));
            }
        }
    }
}
