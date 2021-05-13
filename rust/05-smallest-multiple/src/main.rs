fn main() {
    let mut i = 2;
    while !is_divisible_by_all_integers_to_twenty(i)
    {
        i += 2;
    }
    println!("{}", i.to_string());
}

fn is_divisible_by_all_integers_to_twenty(n: i32) -> bool
{
    for i in (3..20).rev() 
    {
        if n % i != 0
        {
            return false;
        }
    }
    return true;
}