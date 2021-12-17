import unittest

def factorial(number):
    if number == 0:
        return 1
    elif number < 0:
        return 0
    elif number > 0:
        return number * factorial(number - 1)
number = 7
print ("Factorial of %d is: " %number, factorial(number))

class TestFactorial(unittest.TestCase):
    def test_factorial(self):
        self.assertAlmostEqual(factorial(0),1)
        self.assertAlmostEqual(factorial(1),1)
        self.assertAlmostEqual(factorial(2),2)
        self.assertAlmostEqual(factorial(3),6)
        self.assertAlmostEqual(factorial(5),120)
        self.assertAlmostEqual(factorial(-4),0)

if __name__ == '__main__':
    unittest.main()