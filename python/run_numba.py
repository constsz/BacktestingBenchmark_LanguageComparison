import time
import tracemalloc
from numba import jit
import numpy as np


@jit(nopython=True)
def compute_data(number_of_iterations, mean_window):
    a_array = np.zeros(number_of_iterations)
    b_array = np.zeros(number_of_iterations)
    c_array = np.zeros(number_of_iterations)
    mean_array = np.zeros(number_of_iterations)

    for i in range(number_of_iterations):
        a = round(i, 2)
        b = round(i * 0.75 + 1, 2)
        c = round((a + b) / 2, 2)
        mean = 0.0

        if i > 5:
            c = round((a_array[i - 5] + b_array[i - 5]) / 2, 2)

        if i >= mean_window:
            sum_value = 0.0
            start_index = i - mean_window
            for j in range(start_index, start_index + mean_window):
                sum_value += c_array[j]
            mean = round(sum_value / mean_window, 2)

        a_array[i] = a
        b_array[i] = b
        c_array[i] = c
        mean_array[i] = mean

    return mean_array


def run(number_of_iterations, mean_window):
    mean_array = compute_data(number_of_iterations, mean_window)
    print(mean_array[-1])


def main():
    start_time = time.time()
    tracemalloc.start()

    run(256000000, 250)

    elapsed_time = time.time() - start_time
    current, peak = tracemalloc.get_traced_memory()
    memory_used = peak / 1024 / 1024  # Convert to MB

    print(f"Elapsed Time: {elapsed_time:.2f} seconds")
    print(f"Peak Memory Usage: {memory_used:.2f} MB")


if __name__ == "__main__":
    main()
