import time
import tracemalloc


class DataBox:
    def __init__(self, a, b, c, mean):
        self.a = a
        self.b = b
        self.c = c
        self.mean = mean


def run(number_of_iterations, mean_window):
    data = []

    for i in range(number_of_iterations):
        a = round(i, 2)
        b = round(i * 0.75 + 1, 2)
        c = round((a + b) / 2, 2)
        mean = 0.0

        if i > 5:
            c = round((data[i - 5].a + data[i - 5].b) / 2, 2)

        if i >= mean_window:
            sum_value = 0.0
            start_index = i - mean_window
            for j in range(start_index, start_index + mean_window):
                sum_value += data[j].c
            mean = round(sum_value / mean_window, 2)

        box = DataBox(a, b, c, mean)
        data.append(box)

    print(data[-1].mean)


def main():
    start_time = time.time()
    tracemalloc.start()

    run(24000000, 250)

    elapsed_time = time.time() - start_time
    current, peak = tracemalloc.get_traced_memory()
    memory_used = peak / 1024 / 1024  # Convert to MB

    print(f"Elapsed Time: {elapsed_time:.2f} seconds")
    print(f"Peak Memory Usage: {memory_used:.2f} MB")


if __name__ == "__main__":
    main()
