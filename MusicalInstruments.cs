using System;
using System.Collections.Generic;
using System.Text;
//Для раздачи музыкальных инструментов (тип (электронный, акустический))

//Струнные (количество струн, строй)
//Клавишные (количество клавиш, количество полных октав)
//Барабан (радиус, тип (большой, малый и т.п.))
namespace InheritanceMod
{
    public enum InstrumentsType { electronic, acoustic };
    public enum ScaleType { standard, down, open };
    public enum DrumSizeType { snare, kick, tom, hat };
    public class Strings
    {
        public int amountStrings = 0;
        public string scale = "standard";
        public InstrumentsType type = InstrumentsType.acoustic;
    }
    public class Keyboard
    {
        public int amountKeys = 0;
        public int amountOctaves = 0;
        public InstrumentsType type = InstrumentsType.electronic;
    }
    public class Drum
    {
        public int radius = 0;
        public string scale = "standard";
        public InstrumentsType type = InstrumentsType.acoustic;
    }

}
