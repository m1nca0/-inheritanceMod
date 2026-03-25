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
    public class Instruments {
        public static Random rnd = new Random();

        public InstrumentsType type = InstrumentsType.acoustic;
        public virtual string GetInfo()
        {
            
            var str = String.Format("\nТип: {0}", this.type);
            return str;
        }
   
    }

    public enum ScaleType { standard, down, open };
    public class Strings : Instruments
    {
        public int amountStrings = 0;
        public ScaleType scale = ScaleType.standard;

        public override String GetInfo()
        {
            var str = "Тебе выпала скрипка";
            str += String.Format("\nКоличество струн: {0}", this.amountStrings);
            str += String.Format("\nСтрой: {0}", this.scale);
            str += base.GetInfo();
            return str;
        }
        public static ScaleType GeneratScale ()
        {
            var scale = ScaleType.standard;

            switch (rnd.Next() % 3) {
                case 0:
                    scale = ScaleType.standard;
                    break;
                case 1:
                    scale = ScaleType.down;
                    break;
                case 2:
                    scale = ScaleType.open;
                    break;
            }

            return scale;
        }
        public static Strings Generate()
        {
            return new Strings
            {
                type = rnd.Next() % 2 == 0 ? InstrumentsType.electronic : InstrumentsType.acoustic,
                amountStrings = rnd.Next() % 101,
                scale = GeneratScale()
            };
        }

    }
    public class Keyboard : Instruments
    {
        public int amountKeys = 0;
        public int amountOctaves = 0;
        public InstrumentsType type = InstrumentsType.electronic;

        public override String GetInfo()
        {
            var str = "Тебе выпала пианина";
            str += String.Format("\nКоличество клавиш: {0}", this.amountKeys);
            str += String.Format("\nКоличество октав: {0}", this.amountOctaves);
            str += base.GetInfo();
            return str;
        }
        public static Keyboard Generate()
        {
            return new Keyboard
            {
                type = rnd.Next() % 2 == 0 ? InstrumentsType.electronic : InstrumentsType.acoustic,
                amountKeys = rnd.Next() % 101,
                amountOctaves = rnd.Next() % 101
            };
        }
    }
    public enum DrumSizeType { snare, kick, tom, hat };
    public class Drum : Instruments
    {
        public int radius = 0;
        public DrumSizeType size = DrumSizeType.kick;
        public InstrumentsType type = InstrumentsType.acoustic;

        public override string GetInfo()
        {
            var str = "Тебе выпала барабанна";
            str += String.Format("\nРадиус: {0}", this.radius);
            str += String.Format("\nВид: {0}", this.size);
            str += base.GetInfo();
            return str;
        }
        public static DrumSizeType GeneratSize()
        {
            var size = DrumSizeType.kick;

            switch (rnd.Next() % 4)
            {
                case 0:
                    size = DrumSizeType.kick;
                    break;
                case 1:
                    size = DrumSizeType.snare;
                    break;
                case 2:
                    size = DrumSizeType.tom;
                    break;
                case 3:
                    size = DrumSizeType.hat;
                    break;
            }

            return size;
        }
        public static Drum Generate()
        {
            return new Drum
            {
                type = rnd.Next() % 2 == 0 ? InstrumentsType.electronic : InstrumentsType.acoustic,
                radius = rnd.Next() % 101,
                size = GeneratSize()
            };
        }
    }

}
