# План тестирования Calculator
Реализация простейшего калькулятора.
Написанные тесты проверяют правильность расчета функций.
###  Тест 1.
Входные данные: -10, 50.
Ожидаемый выход: -500.
public void MultiplyMethod(double x, double y, double expected)
        {
            double actual = Program.Multiply(x, y);
            Assert.AreEqual(actual, expected);
        }
### Тест 2
Входные данные: 0 , 0
Ожидаемый выход: 0 (ошибка/исключение)
        public void Divideethod(double x, double y, double expected)
        {
            double actual = Program.Divide(x, y);
            Assert.AreEqual(actual, expected);
        }
### Тест 3
Входные данные: double.MaxValue, double.MaxValue
Ожидаемый выход: 1.
        public void Divideethod(double x, double y, double expected)
        {
            double actual = Program.Divide(x, y);
            Assert.AreEqual(actual, expected);
        }

### Тест 4
Входные данные: -50.
Ожидаемый выход: 0 (ошибка).
        [TestCase(4, 2)]
        public void SquareRootMethod(double x, double expected)
        {
            double actual = Program.SquareRoot(x);
            Assert.AreEqual(actual, expected);
 }
### Тест 5
Входные данные: 4.
Ожидаемый выход: 2.
        public void SquareRootMethod(double x, double expected)
        {
            double actual = Program.SquareRoot(x);
            Assert.AreEqual(actual, expected);
  }
### Тест 6
Входные данные: double.MaxValue, double.MaxValue.
Ожидаемый выход: 0.
[TestCase(double.MaxValue, double.MaxValue, 0)]
        public void SubtractMethod(double x, double y, double expected)
        {
            double actual = Program.Subtract(x, y);
            Assert.AreEqual(actual, expected);
 }
