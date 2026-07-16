# 013 - Intersected Numbers in Matrices

## 📌 Description

This project demonstrates how to find the common (intersected) numbers between two two-dimensional matrices using C#.

The program traverses the first matrix and checks whether each element exists in the second matrix. If a match is found, the number is printed as part of the intersection.

Example:

Matrix 1

```
77   5   12
22  20    1
 1   0    9
```

Matrix 2

```
5   80   90
22  77    1
10   8   33
```

Result

```
Intersected Numbers are:
77 5 22 1 1
```

---

## 🚀 Features

- Print both matrices.
- Search for common numbers between two matrices.
- Display all intersected values.
- Uses reusable methods for better code organization.

---

## 🧠 Algorithm

1. Create two matrices.
2. Print both matrices.
3. Traverse every element in the first matrix.
4. For each element, search the second matrix.
5. If the element exists in both matrices, print it.
6. Continue until all elements have been checked.

---

## 📂 Methods

### Print()

Prints a matrix in a readable format.

### IsNumberInMatrix()

Searches for a specified number in a matrix and returns `true` if it exists.

### PrintIntersectedNumbers()

Finds and prints all numbers that appear in both matrices.

---

## 💻 Example Output

Matrix 1

```
77   5   12
22  20    1
 1   0    9
```

Matrix 2

```
5   80   90
22  77    1
10   8   33
```

Result

```
Intersected Numbers are:
77 5 22 1 1
```

---

## 🛠 Technologies

- C#
- .NET
- Console Application

---

## 📖 What I Learned

- Working with multiple two-dimensional arrays.
- Searching for values across matrices.
- Comparing matrix elements efficiently.
- Reusing methods to simplify code.
- Understanding basic set intersection concepts.

---

## 👨‍💻 Author

**Ali Kazem**