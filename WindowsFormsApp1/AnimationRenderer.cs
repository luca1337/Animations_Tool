using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Aiv.Fast2D;

namespace WindowsFormsApp1
{
    public class AnimationRenderer
    {
        public bool Stop { get; set; }
        public bool Show { get; set; }

        private Texture spriteSheet;
        private Sprite sprite;
        private int width;
        private int height;
        private int tilesPerRow;
        private int[] keyFrames;
        private float frameLenght;
        private float time;
        private int currentIndex;
        private int index;

        public AnimationRenderer(Texture spriteSheet, int width, int height, int tilesPerRow, int[] keyFrames, float frameLenght, bool show, bool stop) : base()
        {
            sprite = new Sprite(1f, 1f);
            this.tilesPerRow = tilesPerRow;
            this.spriteSheet = spriteSheet;
            this.width = width;
            this.height = height;
            this.keyFrames = keyFrames;
            this.frameLenght = frameLenght;
            this.Stop = stop;
            this.Show = show;
            index = 0;
            currentIndex = keyFrames[0];
        }

        public virtual void Update()
        {

            if (Stop)
                return;

            //   time += Window.DeltaTime;
            if (time > frameLenght)
            {
                time = 0f;
                currentIndex = keyFrames[index];
                index++;
            }
            else
                return;

            if (index > keyFrames.Length - 1)
            {
                currentIndex = keyFrames[0];
                index = 0;
            }
        }

        public virtual void Draw()
        {
            if (!Show) return;

            int xIndex = currentIndex % tilesPerRow;
            int yIndex = currentIndex / tilesPerRow;

            sprite.DrawTexture(spriteSheet, xIndex * width, yIndex * height, width, height);
        }

        public void Reset()
        {
            this.currentIndex = 0;
            index = 0;
            time = 0f;
            index = 0;
        }
    }
}

