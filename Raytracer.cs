namespace raytracer
{
    class RayTracer
    {
        Surface surface;
        Game window;
        public RayTracer(Surface surface, Game window)
        {
            this.surface = surface;
            this.window = window;

        }

        public void Render()
        {
            int[] cx = { surface.width / 2, surface.width / 4, surface.width };
            int[] cy = { surface.height / 2, surface.height, 0 };
            float d1, d2, d3, red1, red2, red3;
            for (int x = 0; x < surface.width; x++)
            {
                for (int y = 0; y < surface.height; y++)
                {
                    // float red = ((float)x / surface.width);
                    // float green = ((float)y / surface.height);
                    // surface.SetPixel(x, y, red, green, 0.0f);

                    d1 = System.MathF.Sqrt(System.MathF.Pow(x - cx[0], 2) + System.MathF.Pow(y - cy[0], 2));
                    d2 = System.MathF.Sqrt(System.MathF.Pow(x - cx[1], 2) + System.MathF.Pow(y - cy[1], 2));
                    d3 = System.MathF.Sqrt(System.MathF.Pow(x - cx[2], 2) + System.MathF.Pow(y - cy[2], 2));
                    red1 = 1 - d1 / 100;
                    red2 = 1 - d2 / 100;
                    red3 = 1 - d3 / 100;

                    if(red1>red2 && red1>red3){
                        surface.SetPixel(x, y, red1, 0f, 0.0f);
                    }else if(red2>red3){
                        surface.SetPixel(x, y, red2, 0f, 0.0f);
                    }else{
                        surface.SetPixel(x, y, red3, 0f, 0.0f);
                    }

                    



                }
            }
        }

    }
}