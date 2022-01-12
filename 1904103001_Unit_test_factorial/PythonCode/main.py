import pytest
"""Define Factorial Function"""

def fact(num):
# check if the number is negative, positive or zero
    factorial = 1
    if num < 0:
        pass
    elif num == 0:
        pass
    else:
       for i in range(1, num + 1):
           factorial = factorial*i
    return factorial

"""Case 1"""
def test_fact():
    assert fact(5) == 110

"""Case 2"""
def test_fact():
    assert fact(5) == 120


