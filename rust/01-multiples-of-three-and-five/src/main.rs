fn main() {
    let mut acc : i32 = 0;
    for i in 1..1000
    {
        if i % 3 == 0 || i % 5 == 0
        {
            acc += i;
        }
    }
    println!("{}", acc.to_string());
}
