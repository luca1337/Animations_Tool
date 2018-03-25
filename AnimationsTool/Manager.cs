using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aiv.Fast2D;
using OpenTK;
using System.Threading.Tasks;

namespace AnimationsTool
{
    public static class Manager
    {
        public static Window Window => window;

        private static Window window;


        public static void Init()
        {
            window = new Window(900, 450, "Animations Tool");
            window.SetDefaultOrthographicSize(10);
        }

        public static void Run()
        {
            while (window.IsOpened)
            {
                if (window.GetKey(KeyCode.Esc))
                    window.Exit();


                window.Update();
            }
        }

    }
}
