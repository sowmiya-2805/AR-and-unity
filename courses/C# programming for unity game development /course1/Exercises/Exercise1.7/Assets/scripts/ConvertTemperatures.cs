using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // implementation of temperature conversions along with understanding the importance of data types in appropriate places

    void Start()
    {

        //Problem 1 - dealing conversions with int data type
        print("Problem 1");

        int fahrenheit_to_celsius1(int temp)
        {
            return ((temp - 32) / 9) * 5;

        }

        int celsius_to_fahrenheit1(int temp)
        {
            return ((temp * 9) / 5) + 32;

        }

        int f1, f1c1, c1f1;

        //case1 - temperature is 0F
        f1 = 0;
        print("The original temperature in Fahrenheit - " + f1);
        f1c1 = fahrenheit_to_celsius1(f1);
        print("The temperature in Fahrenheit converted to Celsius - " + f1c1);
        c1f1 = celsius_to_fahrenheit1(f1c1);
        print("The temperature in Celsius converted back to Fahrenheit - " + c1f1);

        //case2 - temperature is 32F
        f1 = 32;
        print("The original temperature in Fahrenheit - " + f1);
        f1c1 = fahrenheit_to_celsius1(f1);
        print("The temperature in Fahrenheit converted to Celsius - " + f1c1);
        c1f1 = celsius_to_fahrenheit1(f1c1);
        print("The temperature in Celsius converted back to Fahrenheit - " + c1f1);

        //case3 - temperature is 212F
        f1 = 212;
        print("The original temperature in Fahrenheit - " + f1);
        f1c1 = fahrenheit_to_celsius1(f1);
        print("The temperature in Fahrenheit converted to Celsius - " + f1c1);
        c1f1 = celsius_to_fahrenheit1(f1c1);
        print("The temperature in Celsius converted back to Fahrenheit - " + c1f1);

        //Problem 2 - dealing conversions with float data types
        print("Problem 2");

        float fahrenheit_to_celsius2(float temp)
        {
            return ((temp - 32) / 9) * 5;

        }

        float celsius_to_fahrenheit2(float temp)
        {
            return ((temp * 9) / 5) + 32;

        }

        float f2, f2c2, c2f2;

        //case1 - temperature is 0F
        f2 = 0;
        print("The original temperature in Fahrenheit - " + f2);
        f2c2 = fahrenheit_to_celsius2(f2);
        print("The temperature in Fahrenheit converted to Celsius - " + f2c2);
        c2f2 = celsius_to_fahrenheit2(f2c2);
        print("The temperature in Celsius converted back to Fahrenheit - " + c2f2);

        //case2 - temperature is 32F
        f2 = 32;
        print("The original temperature in Fahrenheit - " + f2);
        f2c2 = fahrenheit_to_celsius2(f2);
        print("The temperature in Fahrenheit converted to Celsius - " + f2c2);
        c2f2 = celsius_to_fahrenheit2(f2c2);
        print("The temperature in Celsius converted back to Fahrenheit - " + c2f2);

        //case3 - temperature is 212F
        f2 = 212;
        print("The original temperature in Fahrenheit - " + f2);
        f2c2 = fahrenheit_to_celsius2(f2);
        print("The temperature in Fahrenheit converted to Celsius - " + f2c2);
        c2f2 = celsius_to_fahrenheit2(f2c2);
        print("The temperature in Celsius converted back to Fahrenheit - " + c2f2);

        //Problem 3 - dealing with conversions of double data type
        print("Problem 3");

        double fahrenheit_to_celsius3(double temp)
        {
            return ((temp - 32) / 9) * 5;

        }

        double celsius_to_fahrenheit3(double temp)
        {
            return ((temp * 9) / 5) + 32;

        }

        double f3, f3c3, c3f3;

        //case1 - temperature is 0F
        f3 = 0;
        print("The original temperature in Fahrenheit - " + f3);
        f3c3 = fahrenheit_to_celsius3(f3);
        print("The temperature in Fahrenheit converted to Celsius - " + f3c3);
        c3f3 = celsius_to_fahrenheit3(f3c3);
        print("The temperature in Celsius converted back to Fahrenheit - " + c3f3);

        //case2 - temperature is 32F
        f3 = 32;
        print("The original temperature in Fahrenheit - " + f3);
        f3c3 = fahrenheit_to_celsius3(f3);
        print("The temperature in Fahrenheit converted to Celsius - " + f3c3);
        c3f3 = celsius_to_fahrenheit3(f3c3);
        print("The temperature in Celsius converted back to Fahrenheit - " + c3f3);

        //case3 - temperature is 212F
        f3 = 212;
        print("The original temperature in Fahrenheit - " + f3);
        f3c3 = fahrenheit_to_celsius3(f3);
        print("The temperature in Fahrenheit converted to Celsius - " + f3c3);
        c3f3 = celsius_to_fahrenheit3(f3c3);
        print("The temperature in Celsius converted back to Fahrenheit - " + c3f3);
    }

    
}
