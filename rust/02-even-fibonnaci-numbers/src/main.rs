fn main() {
    let mut current: i32 = 1;
    let mut prev: i32 = 1;
    let mut next: i32 = 1;
    let mut acc: i32 = 0;
    while current < 4000000
    {
        if current % 2 == 0
        {
            acc += current;
        }
        next = current + prev;
        prev = current;
        current = next;
    }
    println!("{}", acc.to_string());
}

