﻿using System;

namespace Open_Lab_03._07
{
    public class Divider
    {
        public bool EqualSlices(int total, int people, int each)
        {
            int sucet = people * each;
            if (sucet>total)
            {
                return false;
            }    
            else
            {
                return true;
            }
        }
    }
}
