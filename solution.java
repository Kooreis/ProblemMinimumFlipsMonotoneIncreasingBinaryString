Here is a Java console application that solves the problem:

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a binary string:");
        String binaryString = scanner.nextLine();
        System.out.println("Minimum number of flips to make the binary string monotone increasing: " + minFlipsMonoIncr(binaryString));
    }

    public static int minFlipsMonoIncr(String S) {
        int flipCount = 0;
        int onesCount = 0;
        for (int i = 0; i < S.length(); ++i) {
            if (S.charAt(i) == '1') {
                ++onesCount;
            } else {
                if (onesCount != 0) {
                    ++flipCount;
                }
            }
            flipCount = Math.min(flipCount, onesCount);
        }
        return flipCount;
    }
}
```

This console application reads a binary string from the user, then uses the `minFlipsMonoIncr` function to calculate the minimum number of flips to make the binary string monotone increasing. The `minFlipsMonoIncr` function works by iterating over the binary string and counting the number of '1's and the number of flips needed to make the string monotone increasing. The minimum number of flips is then returned.