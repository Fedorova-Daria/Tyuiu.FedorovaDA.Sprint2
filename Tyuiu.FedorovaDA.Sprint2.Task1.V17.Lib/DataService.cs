﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FedorovaDA.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a == b) & (c != d); 
            res[2] = (a >= b) || (c <= d);
            res[3] = (a == b + 12) && (c > d);
            res[4] = !res[1];
            res[5] = (a != b) ^ (c < d + 135);
            return res;
        }
    }
}
