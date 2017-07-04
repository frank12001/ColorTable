namespace ColorTable
{

    public class ColorTable
    {
        private Color[] Colors = new Color[] 
        {
            new Color(){ Name = "Snow", Hexadecimal = "#FFFAFA" , RGB = new byte[]{ 255,250,250 } },
            new Color(){ Name = "GhostWhite", Hexadecimal = "#F8F8FF" , RGB = new byte[]{ 248,248,255 } },
            new Color(){ Name = "WhiteSmoke", Hexadecimal = "#F5F5F5" , RGB = new byte[]{ 245, 245, 245 } },
            new Color(){ Name = "Gainsboro", Hexadecimal = "#DCDCDC" , RGB = new byte[]{  220, 220, 220 } },
            new Color(){ Name = "FloralWhite", Hexadecimal = "#FFFAF0" , RGB = new byte[]{255, 250, 240} },

            new Color(){ Name = "OldLace", Hexadecimal = "#FDF5E6" , RGB = new byte[]{ 253 ,245, 230 } },
            new Color(){ Name = "Linen", Hexadecimal = "#FAF0E6" , RGB = new byte[]{ 250, 240, 230 } },
            new Color(){ Name = "AntiqueWhite", Hexadecimal = "	#FAEBD7" , RGB = new byte[]{ 250, 235, 215 } },
            new Color(){ Name = "PapayaWhip", Hexadecimal = "#FFEFD5" , RGB = new byte[]{ 255, 239, 213 } },
            new Color(){ Name = "BlanchedAlmond", Hexadecimal = "#FFEBCD" , RGB = new byte[]{ 255, 235, 205 } },

            new Color(){ Name = "Bisque", Hexadecimal = "#FFE4C4" , RGB = new byte[]{ 255, 228, 196 } },
            new Color(){ Name = "PeachPuff", Hexadecimal = "#FFDAB9" , RGB = new byte[]{ 255, 218, 185 } },
            new Color(){ Name = "NavajoWhite", Hexadecimal = "#FFDEAD" , RGB = new byte[]{ 255, 222, 173 } },
            new Color(){ Name = "Moccasin", Hexadecimal = "#FFE4B5" , RGB = new byte[]{ 255, 228, 181 } },
            new Color(){ Name = "Cornsilk", Hexadecimal = "#FFF8DC" , RGB = new byte[]{ 255, 248, 220 } },

            new Color(){ Name = "Ivory", Hexadecimal = "#FFFFF0" , RGB = new byte[]{ 255, 255, 240 } },
            new Color(){ Name = "LemonChiffon", Hexadecimal = "#FFFACD" , RGB = new byte[]{ 255, 250, 205 } },
            new Color(){ Name = "Seashell", Hexadecimal = "#FFF5EE" , RGB = new byte[]{ 255, 245, 238 } },
            new Color(){ Name = "Honeydew", Hexadecimal = "#F0FFF0" , RGB = new byte[]{ 240, 255, 240 } },
            new Color(){ Name = "MintCream", Hexadecimal = "#F5FFFA" , RGB = new byte[]{245, 255, 250 } },

            new Color(){ Name = "Azure", Hexadecimal = "#F0FFFF" , RGB = new byte[]{ 240, 255, 255 } },
            new Color(){ Name = "AliceBlue", Hexadecimal = "#F0F8FF" , RGB = new byte[]{240, 248, 255} },
            new Color(){ Name = "Lavender", Hexadecimal = "#E6E6FA" , RGB = new byte[]{ 230, 230, 250 } },
            new Color(){ Name = "LavenderBlush", Hexadecimal = "#FFF0F5" , RGB = new byte[]{ 255, 240, 245 } },
            new Color(){ Name = "MistyRose", Hexadecimal = "#FFE4E1" , RGB = new byte[]{ 255, 228, 225 } },

            new Color(){ Name = "White", Hexadecimal = "#FFFFFF" , RGB = new byte[]{ 255, 255 ,255 } },
            new Color(){ Name = "Black", Hexadecimal = "#000000" , RGB = new byte[]{ 0, 0, 0 } },
            new Color(){ Name = "DarkSlateGray", Hexadecimal = "#2F4F4F" , RGB = new byte[]{ 47, 79, 79 } },
            new Color(){ Name = "DimGrey", Hexadecimal = "#696969" , RGB = new byte[]{ 105, 105, 105 } },
            new Color(){ Name = "SlateGrey", Hexadecimal = "#708090" , RGB = new byte[]{ 112, 128, 144 } },

            new Color(){ Name = "LightSlateGray", Hexadecimal = "#778899" , RGB = new byte[]{ 119, 136, 153 } },
            new Color(){ Name = "Grey", Hexadecimal = "	#BEBEBE" , RGB = new byte[]{ 190, 190, 190 } },
            new Color(){ Name = "LightGray", Hexadecimal = "#D3D3D3" , RGB = new byte[]{ 211, 211, 211 } },
            new Color(){ Name = "MidnightBlue", Hexadecimal = "#191970" , RGB = new byte[]{ 25, 25, 112 } },
            new Color(){ Name = "NavyBlue", Hexadecimal = "#000080" , RGB = new byte[]{ 0, 0, 128 } },

            new Color(){ Name = "CornflowerBlue", Hexadecimal = "#6495ED" , RGB = new byte[]{ 100, 149, 237 } },
            new Color(){ Name = "DarkSlateBlue", Hexadecimal = "#483D8B" , RGB = new byte[]{ 72, 61, 139 } },
            new Color(){ Name = "SlateBlue", Hexadecimal = "#6A5ACD" , RGB = new byte[]{ 106, 90, 205 } },
            new Color(){ Name = "MediumSlateBlue", Hexadecimal = "#7B68EE" , RGB = new byte[]{ 123, 104, 238 } },
            new Color(){ Name = "LightSlateBlue", Hexadecimal = "#8470FF" , RGB = new byte[]{ 132, 112, 255 } },

            new Color(){ Name = "MediumBlue", Hexadecimal = "#0000CD" , RGB = new byte[]{ 0 ,0 ,205 } },
            new Color(){ Name = "RoyalBlue", Hexadecimal = "#4169E1" , RGB = new byte[]{    65, 105, 225 } },
            new Color(){ Name = "Blue", Hexadecimal = "#0000FF" , RGB = new byte[]{ 0, 0, 255 } },
            new Color(){ Name = "DodgerBlue", Hexadecimal = "#1E90FF" , RGB = new byte[]{ 30, 144, 255 } },
            new Color(){ Name = "DeepSkyBlue", Hexadecimal = "#00BFFF" , RGB = new byte[]{ 0 ,191, 255 } },

            new Color(){ Name = "SkyBlue", Hexadecimal = "#87CEEB" , RGB = new byte[]{ 135, 206, 235 } },
            new Color(){ Name = "LightSkyBlue", Hexadecimal = "#87CEFA" , RGB = new byte[]{ 135, 206, 250 } },
            new Color(){ Name = "SteelBlue", Hexadecimal = "#4682B4" , RGB = new byte[]{ 70, 130, 180 } },
            new Color(){ Name = "LightSteelBlue", Hexadecimal = "#B0C4DE" , RGB = new byte[]{ 176, 196, 222 } },
            new Color(){ Name = "LightBlue", Hexadecimal = "#ADD8E6" , RGB = new byte[]{ 173, 216, 230 } },

            new Color(){ Name = "PowderBlue", Hexadecimal = "#B0E0E6" , RGB = new byte[]{ 176, 224, 230 } },
            new Color(){ Name = "PaleTurquoise", Hexadecimal = "#AFEEEE" , RGB = new byte[]{ 175, 238, 238 } },
            new Color(){ Name = "DarkTurquoise", Hexadecimal = "#00CED1" , RGB = new byte[]{ 0, 206, 209 } },
            new Color(){ Name = "MediumTurquoise", Hexadecimal = "#48D1CC" , RGB = new byte[]{ 72, 209, 204 } },
            new Color(){ Name = "Turquoise", Hexadecimal = "#40E0D0" , RGB = new byte[]{ 64 ,224, 208 } },

            new Color(){ Name = "Cyan", Hexadecimal = "#00FFFF" , RGB = new byte[]{ 0, 255, 255 } },
            new Color(){ Name = "LightCyan", Hexadecimal = "#E0FFFF" , RGB = new byte[]{ 224, 255, 255} },
            new Color(){ Name = "CadetBlue", Hexadecimal = "#5F9EA0" , RGB = new byte[]{ 95, 158, 160} },
            new Color(){ Name = "MediumAquamarine", Hexadecimal = "#66CDAA" , RGB = new byte[]{ 102, 205, 170 } },
            new Color(){ Name = "Aquamarine", Hexadecimal = "#7FFFD4" , RGB = new byte[]{ 127, 255, 212 } },

             new Color(){ Name = "DarkGreen", Hexadecimal = "#006400" , RGB = new byte[]{ 0, 100, 0 } },
             new Color(){ Name = "DarkOliveGreen", Hexadecimal = "#556B2F" , RGB = new byte[]{ 85, 107, 47 } },
             new Color(){ Name = "DarkSeaGreen", Hexadecimal = "#8FBC8F" , RGB = new byte[]{ 143, 188, 143 } },
             new Color(){ Name = "SeaGreen", Hexadecimal = "#2E8B57" , RGB = new byte[]{ 46, 139, 87 } },
             new Color(){ Name = "MediumSeaGreen", Hexadecimal = "#3CB371" , RGB = new byte[]{ 60, 179, 113 } },

             new Color(){ Name = "LightSeaGreen", Hexadecimal = "#20B2AA" , RGB = new byte[]{ 32, 178, 170 } },
             new Color(){ Name = "PaleGreen", Hexadecimal = "#98FB98" , RGB = new byte[]{ 152, 251, 152 } },
             new Color(){ Name = "SpringGreen", Hexadecimal = "#00FF7F" , RGB = new byte[]{ 0, 255, 127 } },
             new Color(){ Name = "LawnGreen", Hexadecimal = "#7CFC00" , RGB = new byte[]{ 124, 252, 0 } },
             new Color(){ Name = "Green", Hexadecimal = "#00FF00" , RGB = new byte[]{ 0, 255, 0 } },

             new Color(){ Name = "Chartreuse", Hexadecimal = "#7FFF00" , RGB = new byte[]{ 127, 255, 0 } },
             new Color(){ Name = "MedSpringGreen", Hexadecimal = "#00FA9A" , RGB = new byte[]{ 0, 250, 154 } },
             new Color(){ Name = "GreenYellow", Hexadecimal = "#ADFF2F" , RGB = new byte[]{ 173, 255, 47 } },
             new Color(){ Name = "LimeGreen", Hexadecimal = "#32CD32" , RGB = new byte[]{ 50, 205, 50 } },
             new Color(){ Name = "YellowGreen", Hexadecimal = "#9ACD32" , RGB = new byte[]{ 154, 205, 50 } },

             new Color(){ Name = "ForestGreen", Hexadecimal = "#228B22" , RGB = new byte[]{ 34, 139, 34 } },
             new Color(){ Name = "OliveDrab", Hexadecimal = "#6B8E23" , RGB = new byte[]{ 107, 142, 35 } },
             new Color(){ Name = "DarkKhaki", Hexadecimal = "#BDB76B" , RGB = new byte[]{ 189, 183, 107 } },
             new Color(){ Name = "PaleGoldenrod", Hexadecimal = "#EEE8AA" , RGB = new byte[]{ 238 ,232, 170 } },
             new Color(){ Name = "LtGoldenrodYello", Hexadecimal = "#FAFAD2" , RGB = new byte[]{ 250, 250, 210 } },

              new Color(){ Name = "LightYellow", Hexadecimal = "#FFFFE0" , RGB = new byte[]{ 255, 255, 224 } },
              new Color(){ Name = "Yellow", Hexadecimal = "#FFFF00" , RGB = new byte[]{ 255, 255, 0 } },
              new Color(){ Name = "Gold", Hexadecimal = "#FFD700" , RGB = new byte[]{ 255, 215, 0 } },
              new Color(){ Name = "LightGoldenrod", Hexadecimal = "#EEDD82" , RGB = new byte[]{ 238, 221, 130 } },
              new Color(){ Name = "Goldenrod", Hexadecimal = "#DAA520" , RGB = new byte[]{ 218, 165, 32 } },

              new Color(){ Name = "DarkGoldenrod", Hexadecimal = "#B8860B" , RGB = new byte[]{ 184, 134, 11 } },
              new Color(){ Name = "RosyBrown", Hexadecimal = "#BC8F8F" , RGB = new byte[]{ 188, 143, 143 } },
              new Color(){ Name = "IndianRed", Hexadecimal = "#CD5C5C" , RGB = new byte[]{ 205, 92, 92 } },
              new Color(){ Name = "SaddleBrown", Hexadecimal = "#8B4513" , RGB = new byte[]{ 139, 69, 19 } },
              new Color(){ Name = "Sienna", Hexadecimal = "#A0522D" , RGB = new byte[]{ 160, 82, 45 } },

              new Color(){ Name = "Peru", Hexadecimal = "#CD853F" , RGB = new byte[]{ 205, 133, 63 } },
              new Color(){ Name = "Burlywood", Hexadecimal = "#DEB887" , RGB = new byte[]{ 222, 184, 135 } },
              new Color(){ Name = "Beige", Hexadecimal = "#F5F5DC" , RGB = new byte[]{ 245, 245, 220 } },
              new Color(){ Name = "Wheat", Hexadecimal = "#F5DEB3" , RGB = new byte[]{ 245, 222, 179 } },
              new Color(){ Name = "SandyBrown", Hexadecimal = "#F4A460" , RGB = new byte[]{ 244, 164, 96 } },

              new Color(){ Name = "Tan", Hexadecimal = "#D2B48C" , RGB = new byte[]{ 210, 180, 140 } },
              new Color(){ Name = "Chocolate", Hexadecimal = "#D2691E" , RGB = new byte[]{ 210, 105, 30 } },
              new Color(){ Name = "Firebrick", Hexadecimal = "#B22222" , RGB = new byte[]{ 178, 34, 34 } },
              new Color(){ Name = "Brown", Hexadecimal = "#A52A2A" , RGB = new byte[]{ 165, 42, 42 } },
              new Color(){ Name = "DarkSalmon", Hexadecimal = "#E9967A" , RGB = new byte[]{ 233, 150, 122 } },

              new Color(){ Name = "Salmon", Hexadecimal = "#FA8072" , RGB = new byte[]{ 250, 128, 114 } },
              new Color(){ Name = "LightSalmon", Hexadecimal = "#FFA07A" , RGB = new byte[]{ 255, 160, 122 } },
              new Color(){ Name = "Orange", Hexadecimal = "#FFA500" , RGB = new byte[]{ 255, 165, 0 } },
              new Color(){ Name = "DarkOrange", Hexadecimal = "#FF8C00" , RGB = new byte[]{ 255, 140, 0 } },
              new Color(){ Name = "Coral", Hexadecimal = "#FF7F50" , RGB = new byte[]{ 255, 127, 80 } },

              new Color(){ Name = "LightCoral", Hexadecimal = "#F08080" , RGB = new byte[]{ 240 ,128, 128 } },
              new Color(){ Name = "Tomato", Hexadecimal = "#FF6347" , RGB = new byte[]{ 255, 99 ,71 } },
              new Color(){ Name = "OrangeRed", Hexadecimal = "#FF4500" , RGB = new byte[]{ 255, 69, 0 } },
              new Color(){ Name = "Red", Hexadecimal = "#FF0000" , RGB = new byte[]{    255, 0, 0 } },
              new Color(){ Name = "HotPink", Hexadecimal = "#FF69B4" , RGB = new byte[]{    255, 105, 180 } },

              new Color(){ Name = "DeepPink", Hexadecimal = "#FF1493" , RGB = new byte[]{ 255, 20, 147 } },
              new Color(){ Name = "Pink", Hexadecimal = "#FFC0CB" , RGB = new byte[]{ 255, 192, 203 } },
              new Color(){ Name = "LightPink", Hexadecimal = "#FFB6C1" , RGB = new byte[]{ 255, 182, 193 } },
              new Color(){ Name = "PaleVioletRed", Hexadecimal = "#DB7093" , RGB = new byte[]{ 219 ,112 ,147 } },
              new Color(){ Name = "Maroon", Hexadecimal = "#B03060" , RGB = new byte[]{ 176, 48, 96 } },

              new Color(){ Name = "MediumVioletRed", Hexadecimal = "#C71585" , RGB = new byte[]{ 199, 21, 133 } },
              new Color(){ Name = "VioletRed", Hexadecimal = "#D02090" , RGB = new byte[]{ 208, 32, 144 } },
              new Color(){ Name = "Magenta", Hexadecimal = "#FF00FF" , RGB = new byte[]{ 255, 0, 255 } },
              new Color(){ Name = "Violet", Hexadecimal = "#EE82EE" , RGB = new byte[]{ 238, 130, 238 } },
              new Color(){ Name = "Plum", Hexadecimal = "#DDA0DD" , RGB = new byte[]{  221, 160, 221 } },

              new Color(){ Name = "Orchid", Hexadecimal = "#DA70D6" , RGB = new byte[]{ 218, 112, 214 } },
              new Color(){ Name = "MediumOrchid", Hexadecimal = "#BA55D3" , RGB = new byte[]{ 186, 85, 211 } },
              new Color(){ Name = "DarkOrchid", Hexadecimal = "#9932CC" , RGB = new byte[]{ 153, 50, 204 } },
              new Color(){ Name = "DarkViolet", Hexadecimal = "#9400D3" , RGB = new byte[]{ 148, 0, 211 } },
              new Color(){ Name = "BlueViolet", Hexadecimal = "#8A2BE2" , RGB = new byte[]{ 138, 43, 226 } },

              new Color(){ Name = "Purple", Hexadecimal = "#A020F0" , RGB = new byte[]{ 160, 32, 240 } },
              new Color(){ Name = "MediumPurple", Hexadecimal = "#9370DB" , RGB = new byte[]{ 147, 112, 219 } },
              new Color(){ Name = "Thistle", Hexadecimal = "#D8BFD8" , RGB = new byte[]{ 216, 191, 216 } },

        }; 

    }
}