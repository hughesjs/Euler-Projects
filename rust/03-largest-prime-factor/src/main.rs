use integer_sqrt::IntegerSquareRoot;

fn main() {
    let target: u64 = 600851475143;

    
    for i in (0..target.integer_sqrt()).rev().step_by(2)
    {
        if target % i == 0
        {
            if is_prime(i)
            {
                println!("{}", i);
                break;
            }
        }
    }

}

fn is_prime(n: u64) -> bool
{
    for i in (3..(n).integer_sqrt()).step_by(2)
    {
        if n % i == 0
        {
            return false;
        }
    }
    return true;
}
