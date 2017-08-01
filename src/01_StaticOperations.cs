﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLib
{
    //declare enum on toplevel. doesn't work nested in a class yet!
    public enum DemoEnum { Foo, Bar };

    //The name of a static class will not show up anywhere in VL. 
    public static class SomeStaticVLNodes
    { 
        //a simple static operation
        public static float MyAddition(float input, float input2)
        {
            return input + input2;
        }

        //function overloading
        public static float MyAddition(float input, float input2, float input3)
        {
            return input + input2 + input3;
        }

        //pinnames are separated at camelCasing for better reading in VL
        public static float PinNames(float firstInput, float secondInput)
        {
            return firstInput + secondInput;
        }

        //setting pin defaults
        public static float Defaults(float firstInput=44f, float secondInput=0.44f)
        {
            return firstInput + secondInput;
        }

        //multiple outputs via out parameters
        public static void MultipleOutputs(float firstInput, float secondInput, out float added, out float multiplied)
        {
            added = firstInput + secondInput;
            multiplied = firstInput * secondInput;
        }

        //using generics
        public static string Generic<T>(T input)
        {
            return input.ToString();
        }

        //IEnumerable<> appears as Sequence<> in vl
        public static IEnumerable<float> ReverseSequence(IEnumerable<float> input)
        {
            return input.Reverse();
        }

        //static enum
        public static string StaticEnumDemo(DemoEnum e)
        {
            return e.ToString();
        }

        //to use XML documentation don't forget to enable "XML Documentation File" in the projects properties!
        ///<summary>An operation to test html documentation</summary>
        ///<remarks>No remarks</remarks>
        ///<tags>html documentation test</tags>
        ///<param name="a">the param a</param>
        ///<returns>returns 2 a</returns>
        public static int HTMLDocuTest(int a)
        {
            return a*2;
        }
        
        //ref is ignored and the parameter is treated as a normal one
        public static int RefParams(ref int firstInput)
        {
            return firstInput + 4444;
        }
    }
}