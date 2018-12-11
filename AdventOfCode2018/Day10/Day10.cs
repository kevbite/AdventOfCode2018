using System;
using System.Threading;

namespace AdventOfCode2018.Day10
{
    public class Day10
    {
        public (int seconds, string sky) WatchSky(string input)
        {
            var floatingLights = new FloatingLightParser()
                .Parse(input);

            var sky = new Sky(floatingLights);
            var lastSky = sky;
            var i = -1;

            while (sky.Height <= lastSky.Height)
            {
                lastSky = sky;
                sky = sky.Watch();
                i++;
            }

            return (i, lastSky.ToString());
        }
    }
}