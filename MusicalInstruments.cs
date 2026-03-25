using System;
using System.Collections.Generic;
using System.Text;
//Для раздачи музыкальных инструментов (тип (электронный, акустический))

//Струнные (количество струн, строй)
//Клавишные (количество клавиш, количество полных октав)
//Барабан (радиус, тип (большой, малый и т.п.))
namespace InheritanceMod
{
    public class Instruments {
        public virtual string GetInfo()
        {
            return "инструмент";
        }
    }
    public enum InstrumentsType { electronic, acoustic };
    public enum ScaleType { standard, down, open };
    public class Strings : Instruments
    {
        public int amountStrings = 0;
        public ScaleType scale = ScaleType.standard;
        public InstrumentsType type = InstrumentsType.acoustic;

        public override String GetInfo()
        {
            return "Струнные";
        }
    }
    public class Keyboard : Instruments
    {
        public int amountKeys = 0;
        public int amountOctaves = 0;
        public InstrumentsType type = InstrumentsType.electronic;

        public override String GetInfo()
        {
            return "Клавиши";
        }
    }
    public enum DrumSizeType { snare, kick, tom, hat };
    public class Drum : Instruments
    {
        public int radius = 0;
        public DrumSizeType size = DrumSizeType.kick;
        public InstrumentsType type = InstrumentsType.acoustic;

        public override String GetInfo()
        {
            return "Барабабы";
        }
    }

}
