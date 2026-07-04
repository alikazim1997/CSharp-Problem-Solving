# 009 - Check Identity Matrix

## 📌 Description

This project demonstrates how to determine whether a two-dimensional matrix is an **Identity Matrix** in C#.

An Identity Matrix is a square matrix where all elements on the main diagonal are **1**, and all other elements are **0**.

Example:

Matrix

```
1  0  0
0  1  0
0  0  1
```

Result

```
Is Identity Matrix: True
```

---

## 🚀 Features

- Print the matrix.
- Check whether the matrix is square.
- Verify that all main diagonal elements are equal to **1**.
- Verify that all non-diagonal elements are equal to **0**.
- Return the result as a Boolean value.

---

## 🧠 Algorithm

1. Check if the matrix is square.
2. Traverse all matrix elements.
3. If the current element is on the main diagonal, ensure it equals **1**.
4. Otherwise, ensure it equals **0**.
5. If any condition fails, return **false**.
6. If all conditions are satisfied, return **true**.

---

## 📂 Methods

### PrintMatrix()

Prints the matrix in a readable format.

### IsIdentityMatrix()

Checks whether the matrix is an Identity Matrix and returns `true` or `false`.

---

## 💻 Example Output

Matrix

```
1   0   0
0   1   0
0   0   1
```

Result

```
Is Identity Matrix: True
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
- Traversing matrices using nested loops.
- Understanding the properties of an Identity Matrix.
- Returning Boolean values from methods.

---

## 👨‍💻 Author

**Ali Kazem**