const MAX: i64 = 100;

fn main() {
    let sum_of_squares: i64 = get_sum_of_squares(MAX);
    let sum: i64 = get_sum(MAX);
    let square_of_sum: i64 = sum.pow(2);
    let diff: i64 = square_of_sum - sum_of_squares;
    println!("{}", diff);
}

fn get_sum(n_max: i64) -> i64
{
    let mut acc = 0;
    for i in 1..=n_max
    {
        acc += i;
    }
    return acc;
}

fn get_sum_of_squares(n_max: i64) -> i64
{
    let mut acc = 0;
    for i in 1..=n_max
    {
        acc += i.pow(2);
    }
    return acc;
}
