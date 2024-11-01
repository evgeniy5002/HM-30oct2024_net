namespace HW
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex(left.Real + right.Real, left.Imaginary + right.Imaginary);
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex(left.Real - right.Real, left.Imaginary - right.Imaginary);
        }

        public static Complex operator *(Complex left, Complex right)
        {
            double RealPart = left.Real * right.Real - left.Imaginary * right.Imaginary;
            double ImaginaryPart = left.Real * right.Imaginary + left.Imaginary * right.Real;

            return new Complex(RealPart, ImaginaryPart);
        }

        public static Complex operator /(Complex left, Complex right)
        {
            double denominator = right.Real * right.Real + right.Imaginary * right.Imaginary;
            double RealPart = (left.Real * right.Real + left.Imaginary * right.Imaginary) / denominator;
            double ImaginaryPart = (left.Imaginary * right.Real - left.Real * right.Imaginary) / denominator;

            return new Complex(RealPart, ImaginaryPart);
        }

        public override string ToString()
        {
            if (Imaginary >= 0)
                return $"{Real} + {Imaginary}i";
            else
                return $"{Real} - {-Imaginary}i";
        }
    }
}