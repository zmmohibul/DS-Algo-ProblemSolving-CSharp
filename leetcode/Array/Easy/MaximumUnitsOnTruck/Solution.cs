using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaximumUnitsOnTruck
{
    public class Solution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize) 
        {
            var unitsPerBoxList = new List<int>();
            foreach (var boxType in boxTypes)
            {
                unitsPerBoxList.Add(boxType[1]);
            }
            
            unitsPerBoxList.Sort();

            var result = 0;
            var amountAdded = 0;
            var i = unitsPerBoxList.Count - 1;
            while(truckSize > 0)
            {
                var unitSize = unitsPerBoxList[i];
                foreach (var boxType in boxTypes)
                { 
                    if (boxType[1] == unitSize)
                    {
                        var noUnit = boxType[0];
                        var szUnit = boxType[1];

                        if (noUnit <= truckSize)
                        {
                            amountAdded += noUnit;
                            result = result + (noUnit * szUnit);
                            truckSize -= noUnit;
                        }
                        else
                        {
                            result = result + (truckSize * szUnit);
                            truckSize -= truckSize;
                        }
                        boxType[0] = 0;
                        boxType[1] = 0;
                        break;
                    }
                }
                i -= 1;
            }

            return result;
        }
    }
}