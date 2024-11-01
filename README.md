# Backtesting Benchmark - Language Comparison
Comparing performance of languages in over-simplified Backtesting scenario.

**Languages**: 
- C#
- Go
- Node.js
- Python numba
- Rust
</br></br></br>
# Results:
</br></br>
## Number of iterations: 24_000_000

| Language             | Elapsed Time | Peak Memory Usage |
|----------------------|--------------|-------------------|
| Golang               | 5.440 s      | 754 MB            |
| C# .NET8             | 5.660 s      | 755 MB            |
| C# .NET8 AOT         | 5.660 s      | 751 MB            |
| C# .NET Framework 4.8| 5.958 s      | 745 MB            |
| Python Numba         | 9.730 s      | 753.47 MB         |
| Node.js              | 18.400 s     | 2639.49 MB        |


#### Rust:
Elapsed Time: 4.850 s</br>

#### Golang:
Elapsed Time: 5.440 s</br>
Peak Memory Usage: 754 MB

#### C# .NET8:
Elapsed Time: 5.660 s</br>
Peak Memory Usage: 755 MB

#### C# .NET8 AOT:
Elapsed Time: 5.660 s</br>
Peak Memory Usage: 751 MB

#### C# .NET Framework 4.8:
Elapsed Time: 5.958 s</br>
Peak Memory Usage: 745 MB

#### Python Numba: 
Elapsed Time: 9.730 s</br>
Peak Memory Usage: 753.47 MB

#### Node.js:
Elapsed Time: 18.400 s</br>
Peak Memory Usage: 2639.49 MB


</br></br>
## Number of iterations: 256_000_000

#### Rust:
Elapsed Time: 49.700 s</br>

#### Golang:
Elapsed Time: 57.497 s</br>
Peak Memory Usage: 7954 MB

#### C# .NET8:
Elapsed Time: 60.090 s</br>
Peak Memory Usage: 7835 MB

#### C# .NET8 AOT:
Elapsed Time: 60.250 s</br>
Peak Memory Usage: 7831 MB

#### Python Numba:
Elapsed Time: 64.83 s</br>
Peak Memory Usage: 7833.55 MB

#### Node:
Crashed. For 128Mil crashed as well.</br>


