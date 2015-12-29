using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace City
{
    class Pallete
    {
        private List<Color> _pallete;

        public Pallete(int count)
        {
            int R = 0;
            int G = 0;
            int B = 0;
            int colorStep = 2 * 255 / count;

            _pallete = new List<Color>();
            while (R < 255)
            {
                _pallete.Add(Color.FromArgb(R,G,B));
                R += colorStep;
                if (R > 255)
                {
                    if (R > 255)
                    {
                        G = R - 255;
                        B = G;
                        R = 255;
                    } 
                }
            }

            while ( G < 255 ){
                _pallete.Add(Color.FromArgb(R, G, B));
                G += colorStep;
                if (G > 255){
                    R = 255;
                }
                B = G;
            } 
        }

        public Color getColor(int index)
        {
            if (index < 0)
            {
                return _pallete[0];
            }
            if (index > _pallete.Count - 1)
            {
                return _pallete[_pallete.Count - 1];
            }
            return _pallete[index];
        }

    }
}
