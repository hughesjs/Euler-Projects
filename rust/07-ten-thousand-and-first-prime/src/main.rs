use integer_sqrt::IntegerSquareRoot;

const P_MAX: i32 = 10001;

fn main() {
    let mut i = 1;
    let mut count = 1; // 2 is prime but screws with the not-checking evens schtick
    while count < P_MAX
    {
        i += 2;
        if is_prime(i)
        {
            count += 1;
        }
    }    
    println!("{}", i);
}


fn is_prime(n: u64) -> bool
{
    for i in (3..=(n).integer_sqrt()).step_by(2)
    {
        if n % i == 0
        {
            
            return false;
        }
    }
    return true;
}