const { performance } = require('perf_hooks');
const os = require('os');

class DataBox {
    constructor(a, b, c, mean) {
        this.a = a;
        this.b = b;
        this.c = c;
        this.mean = mean;
    }
}

function run(numberOfIterations, meanWindow) {
    const data = [];

    for (let i = 0; i < numberOfIterations; i++) {
        let a = i;
        let b = i * 0.75 + 1;
        let c = (a + b) / 2;
        let mean = 0.0;

        if (i > 5) {
            c = (data[i - 5].a + data[i - 5].b) / 2;
        }

        if (i >= meanWindow) {
            let sum = 0.0;
            let startIndex = i - meanWindow;
            for (let j = startIndex; j < startIndex + meanWindow; j++) {
                sum += data[j].c;
            }
            mean = sum / meanWindow;
        }

        const box = new DataBox(a, b, c, mean);
        data.push(box);
    }

    console.log(data[numberOfIterations - 1].mean);
}

function main() {
    const start = performance.now();

    run(128000000, 250);

    const elapsedTime = performance.now() - start;
    const memoryUsage = process.memoryUsage().heapUsed / 1024 / 1024; // Convert to MB

    console.log(`Elapsed Time: ${elapsedTime.toFixed(2)} ms`);
    console.log(`Peak Memory Usage: ${memoryUsage.toFixed(2)} MB`);
}

main();
