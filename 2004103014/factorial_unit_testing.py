import unittest

def factorial(number):
    fac=number
    number=1
    while(fac>0):
       number=number*fac
       fac=fac-1
    return number
number=5       
print ("Factorial of %d is: " %number, factorial(number))
class TestFactorial(unittest.TestCase):
    def test_factorial(self):
        self.assertAlmostEqual(factorial(1),1)
        self.assertAlmostEqual(factorial(2),2)
        self.assertAlmostEqual(factorial(3),6)
        self.assertAlmostEqual(factorial(5),120)
    

if __name__ == '__main__':
    unittest.main()