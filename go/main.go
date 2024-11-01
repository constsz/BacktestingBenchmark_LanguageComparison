package main

import (
	"fmt"
	"runtime"
	"time"
)

type DataBox struct {
	A    float64
	B    float64
	C    float64
	Mean float64
}

func main() {
	start := time.Now()

	Run(256000000, 250)

	elapsed := time.Since(start)
	var mem runtime.MemStats
	runtime.ReadMemStats(&mem)
	memoryUsed := mem.Sys / 1024 / 1024

	fmt.Printf("Elapsed Time: %s\n", elapsed)
	fmt.Printf("Peak Memory Usage: %d MB\n", memoryUsed)
}

func Run(numberOfIterations int, meanWindow int) {
	data := make([]DataBox, 0, numberOfIterations)

	for i := 0; i < numberOfIterations; i++ {
		a := float64(i)
		b := float64(i)*0.75 + 1
		c := (a + b) / 2
		var mean float64

		if i > 5 {
			c = (data[i-5].A + data[i-5].B) / 2
		}

		if i >= meanWindow {
			sum := 0.0
			startIndex := i - meanWindow
			for j := startIndex; j < startIndex+meanWindow; j++ {
				sum += data[j].C
			}
			mean = sum / float64(meanWindow)
		}

		box := DataBox{
			A:    a,
			B:    b,
			C:    c,
			Mean: mean,
		}
		data = append(data, box)
	}

	number := data[numberOfIterations-1].Mean
	fmt.Printf("Number: %.2f\n", number)
}
