# 010 - Check Scalar Matrix

## 📌 Description

This project demonstrates how to determine whether a two-dimensional matrix is a **Scalar Matrix** in C#.

A Scalar Matrix is a square matrix where all elements on the main diagonal are equal, and all other elements are **0**.

Example:

Matrix

```
4  0  0
0  4  0
0  0  4
```

Result

```
Is Scalar Matrix: True
```

---

## 🚀 Features

- Print the matrix.
- Check whether the matrix is square.
- Verify that all main diagonal elements have the same value.
- Verify that all non-diagonal elements are equal to **0**.
- Return the result as a Boolean value.

---

## 🧠 Algorithm

1. Check if the matrix is square.
2. Store the first diagonal element.
3. Traverse all matrix elements.
4. If the current element is on the main diagonal, verify it equals the first diagonal element.
5. Otherwise, verify it equals **0**.
6. If any condition fails, return **false**.
7. If all conditions are satisfied, return **true**.

---

## 📂 Methods

### PrintMatrix()

Prints the matrix in a readable format.

### IsScalarMatrix()

Checks whether the matrix is a Scalar Matrix and returns `true` or `false`.

---

## 💻 Example Output

Matrix

```
4   0   0
0   4   0
0   0   4
```

Result

```
Is Scalar Matrix: True
```

---

## 🛠 Technologies

- C#
- .NET
- Console Application

---

## 📖 What I Learned

- Working with two-dimensional arrays.
- Checking whether a matrix is square.
- Understanding the properties of a Scalar Matrix.
- Comparing diagonal elements.
- Returning Boolean values from methods.

---

## 👨‍💻 Author

**Ali Kazem**