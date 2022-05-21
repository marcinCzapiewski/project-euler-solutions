package main

import "fmt"

func main() {
	previousFibValue := 1
	currentFibValue := 2

	evenBasedNumsSum := currentFibValue
	newFibValue := previousFibValue + currentFibValue
	for {
		newFibValue = currentFibValue + previousFibValue
		previousFibValue = currentFibValue
		currentFibValue = newFibValue

		if currentFibValue > 4_000_000 {
			break
		}

		if currentFibValue%2 == 0 {
			evenBasedNumsSum = evenBasedNumsSum + currentFibValue
		}
	}

	fmt.Println(evenBasedNumsSum)
}
