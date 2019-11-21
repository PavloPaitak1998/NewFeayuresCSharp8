using System;
using System.Collections.Generic;
using System.Text;

namespace MorePatternsInMorePlaces
{
    class _2SwitchExpressionLimitation
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
}
