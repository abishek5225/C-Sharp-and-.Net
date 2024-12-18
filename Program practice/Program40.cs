/*
Write a C# program to overload a binary operator.
*/

using System;

class Complex{
    public double Real;
    public double Imaginary;

    public Complex( double real, double imaginary){
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2){
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public static Complex operator -(Complex c1, Complex c2){
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}";
    }
}

class Program{
    static void Main(){
        
    }
}