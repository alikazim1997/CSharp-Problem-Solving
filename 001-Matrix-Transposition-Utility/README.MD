# Transpose Matrix in C#

## 📌 Description

This project demonstrates how to transpose a matrix in C#.

The transpose of a matrix is created by swapping its rows with its columns.

Example:

Original Matrix (2 × 3)

1 2 3
4 5 6

Transposed Matrix (3 × 2)

1 4
2 5
3 6

---

## 🚀 Features

- Fill the matrix with sequential numbers.
- Print the original matrix.
- Create a new transposed matrix.
- Works with both:
  - Square matrices (N × N)
  - Rectangular matrices (M × N)

---

## 🧠 Algorithm

1. Get the number of rows and columns.
2. Create a new matrix with swapped dimensions.
3. Loop through the original matrix.
4. Assign:

```csharp
transposed[j, i] = original[i, j];
```

5. Print the transposed matrix.

---

## 📂 Methods

### FullArrNumber()

Fills the matrix with sequential numbers.

### TransposeMatrix()

Creates and returns the transposed matrix.

### PrintMatrix()

Prints the matrix to the console.

---

## 💻 Example Output

Original Matrix

```
1    2    3
4    5    6
```

Transposed Matrix

```
1    4
2    5
3    6
```

---

## 🛠 Technologies

- C#
- .NET
- Console Application

---

## 📖 What I Learned

- Working with two-dimensional arrays.
- Understanding matrix transposition.
- Creating methods that return arrays.
- Handling rectangular matrices correctly.
- Using `GetLength()` to retrieve array dimensions.

---

## 👨‍💻 Author

Ali Kazem
