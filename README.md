# Backtesting Benchmark - Language Comparison
Comparing performance of languages in over-simplified Backtesting scenario.

**Languages**: 
| Language             | Version |
|----------------------|---------|
| C#  | .NET 8 |
| Go | 1.21.6 |
| Node.js | v22.10.0 |
| Python numba | 3.11.8 |
| Rust | 1.82.0 |


</br></br>

# Results:
</br>


## Number of iterations: 256_000_000

| Language      | Elapsed Time | Peak Memory Usage |
|---------------|--------------|-------------------|
| Rust          | 49.700 s     | -                 |
| Golang        | 57.497 s     | 7954 MB           |
| C#       | 60.090 s     | 7835 MB           |
| C#  AOT  | 60.250 s     | 7831 MB           |
| Python Numba  | 64.83 s      | 7833.55 MB        |
| Node          | Crashed      | -                 |

</br></br>
## Number of iterations: 24_000_000

| Language             | Elapsed Time | Peak Memory Usage |
|----------------------|--------------|-------------------|
| Rust                 | 4.850 s      | -                 |
| Golang               | 5.440 s      | 754 MB            |
| C#             | 5.660 s      | 755 MB            |
| C# AOT         | 5.660 s      | 751 MB            |
| Python Numba         | 9.730 s      | 753.5 MB          |
| Node.js              | 18.400 s     | 2639.5 MB         |


