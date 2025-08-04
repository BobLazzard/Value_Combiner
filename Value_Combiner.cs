using System;
using Unity.Mathematics;
using UnityEngine;

namespace Value_Combining
{ 
    public class Slow
    {
        public static T Combine<T>(T a, T b, float ratioA)
        {
            float ratioB = 1f - ratioA;

            return (dynamic)a * ratioA + (dynamic)b * ratioB;
        }
    }
}
