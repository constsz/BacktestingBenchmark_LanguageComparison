use std::time::Instant;

struct DataBox {
    a: f64,
    b: f64,
    c: f64,
    mean: f64,
}

fn main() {
    let number_of_iterations: usize = 24_000_000;
    println!("number_of_iterations: {}", number_of_iterations);
    
    let start = Instant::now();
    run(number_of_iterations, 250);
    let duration = start.elapsed();

    // Rust doesn't have a built-in way to measure peak memory usage,
    // but you can use third-party crates or OS-specific tools to measure it.
    println!("Elapsed Time: {:?}", duration);
}

fn run(number_of_iterations: usize, mean_window: usize) {
    let mut data: Vec<DataBox> = Vec::with_capacity(number_of_iterations);

    for i in 0..number_of_iterations {
        let a = i as f64;
        let b = i as f64 * 0.75 + 1.0;
        let mut c = (a + b) / 2.0;
        let mut mean = 0.0;

        if i > 5 {
            c = (data[i - 5].a + data[i - 5].b) / 2.0;
        }

        if i >= mean_window {
            let sum: f64 = data[i - mean_window..i].iter().map(|box_| box_.c).sum();
            mean = sum / mean_window as f64;
        }

        let box_ = DataBox { a, b, c, mean };
        data.push(box_);
    }

    println!("{}", data[number_of_iterations - 1].mean);
}
