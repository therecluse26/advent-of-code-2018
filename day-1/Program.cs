using System;
using System.IO;
using System.Collections.Generic;

namespace day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = File.ReadAllLines("input_data");

            Dictionary<int, int> freqDict = new Dictionary<int, int>();
            
            var calibrate = 0;

            for (var i = 0; i <= inputData.Length - 1; i++){
                
                calibrate += Convert.ToInt32(inputData[i]);
                
                if (freqDict.ContainsKey(calibrate))
                {
                    freqDict[calibrate]++;
                }
                else
                {                    
                    freqDict.Add(calibrate, 1);
                };
                
                if (freqDict[calibrate] == 2)
                {
                    Console.WriteLine(calibrate);
                    break;
                };

                if (i == inputData.Length - 1)
                {
                    i = -1;
                };

            }

        }
    }
}
