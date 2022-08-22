public int SubtractProductAndSum(int n) {
    int sum = 0, num = n;
    while (num > 0) {
        sum += (num % 10);
        num /= 10;
    }
    int product = 1;
    while (n > 1) {
        product *= (n % 10);
        n /= 10;
    }
    return product - sum;
}
