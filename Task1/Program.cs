/* Вычислите значение формулы a*b/(c+d), где а, b,
с и d -некоторые целые числа. Решение оформить в виде функции.
*/

double CalculatedFormula(int a, int b, int c, int d);
{
    int numerator = a * b;
    int denominator = c + d;
    double result = numerator / denominator;
    return result;
}
CalculatedFormula(17, 13, 8, 2);