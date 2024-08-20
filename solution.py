Here is a Python solution for the problem:

```python
def min_flips(s):
    flip_count = 0
    one_count = 0
    for i in range(len(s)):
        if s[i] == '0':
            if one_count == 0:
                continue
            else:
                flip_count += 1
        else:
            one_count += 1
        flip_count = min(flip_count, one_count)
    return flip_count

if __name__ == "__main__":
    s = input("Enter a binary string: ")
    print("Minimum number of flips to make binary string monotone increasing: ", min_flips(s))
```

This console application takes a binary string as input and returns the minimum number of flips to make the binary string monotone increasing. The function `min_flips(s)` is used to calculate the minimum number of flips. It iterates over the binary string and counts the number of '1's and '0's. If a '0' is encountered after a '1', the flip count is incremented. The minimum of the flip count and the count of '1's is always taken as the flip count. This ensures that the minimum number of flips is calculated.