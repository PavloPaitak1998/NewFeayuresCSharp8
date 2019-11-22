using System;

namespace _002_SwitchExpressionLimitation
{
    class SwitchExpressionLimitation
    {
        public static string FromRainbowClassic(Rainbow colorBand)
        {
            switch (colorBand)
            {
                case Rainbow.Red:
                case Rainbow.Orange:
                case Rainbow.Yellow:
                    Log("Warm colors");
                    return "Warm colors";
                case Rainbow.Blue:
                case Rainbow.Indigo:
                    Log("Cold colors");
                    return "Cold colors";
                default:
                    throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand));
            };
        }

        //public static void FromRainbowDoesntWork(Rainbow colorBand)
        //{
        //    var res = colorBand switch
        //    {
        //        Rainbow.Red,
        //        Rainbow.Orange,
        //        Rainbow.Yellow =>
        //            {
        //              Log("Warm colors");
        //              return "Warm colors";
        //            },
        //        Rainbow.Blue,
        //        Rainbow.Indigo => 
        //            {
        //              Log("Cold colors");
        //              return "Cold colors";
        //            },,
        //        _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
        //    };

        //}

        public static string FromRainbowNew(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => ((Func<string>)(() =>
                {
                    Log("Warm colors");
                    return "Warm colors";
                }))(),
                Rainbow.Orange => ((Func<string>)(() =>
                {
                    Log("Warm colors");
                    return "Warm colors";
                }))(),
                Rainbow.Yellow => ((Func<string>)(() =>
                {
                    Log("Warm colors");
                    return "Warm colors";
                }))(),
                Rainbow.Blue => ((Func<string>)(() =>
                {
                    Log("Warm colors");
                    return "Warm colors";
                }))(),
                Rainbow.Indigo => ((Func<string>)(() =>
                {
                    Log("Warm colors");
                    return "Warm colors";
                }))(),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };

        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    #region Types
    public class RGBColor
    {
        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public RGBColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }

    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
