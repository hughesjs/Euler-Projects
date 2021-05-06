fn main() {
    let max = 999;
    let mut prod: i32;
    let mut largest: i32 = 0;

    for i in (0..max).rev()
    {
        for j in (0..max).rev()
        {
            prod = i * j;
            if prod > largest && is_palindrome(prod)
            {
                largest = prod;
            }
        }
    }
    println!("{} is the largest palindromic number that is a product of two numbers in the range 0 -> {}", largest, max);    
}

fn is_palindrome(n: i32) -> bool
{
    let num_string = n.to_string();
    let half = num_string.len() / 2;
    num_string.chars().take(half).eq(num_string.chars().rev().take(half))
}