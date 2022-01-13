#include <bits/stdc++.h>
using namespace std;

vector<int> arr = { 2, 3, 4, 10, 40 };

int main(void)
{
    int numberToFind;
    cin>>numberToFind;
    int length = arr.size() - 1;

    int start = 0;

    while(length >= start)
    {
        int mid = start + (length - start)/2;
        if(arr[mid] == numberToFind)
        {
            cout << "Element is present at index "<< mid;
            return 0;
        }
        if(arr[mid] > numberToFind)
        {
            length = mid - 1;
        }
        else
        {
            start = mid + 1;
        }
    }
    cout << "Element is not present in array";
    return 0;
}
