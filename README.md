ر# 🎮 Console Tic-Tac-Toe Game in C#

A simple yet fun 2-player Tic-Tac-Toe (XO) game built in C# for the console!

## 📋 Features

- Interactive console interface with a clear 3×3 grid.
- Two-player support: Player `X` vs Player `O`.
- Input validation (ensures correct and empty cells only).
- Auto-detects wins across rows, columns, and diagonals.
- Detects draws and offers replay option.
- ASCII-style styled board for better UX.

## 🧩 How to Play

1. Run the program.
2. Player X starts the game.
3. Enter a number from 1 to 9 to place your mark in the corresponding cell:
   ```
   1 | 2 | 3
   ---------
   4 | 5 | 6
   ---------
   7 | 8 | 9
   ```
4. The game checks for a winner or a draw after every move.
5. At the end of the game, press any key to restart.

## 🛠 Code Structure

- `PrintBoard()` – Displays the current state of the board.
- `PlayGame()` – Main loop handling user input and game flow.
- `CheckWinner()` – Checks for win conditions.
- `ResetGame()` – Resets the board and variables for a new game.

## 🧑‍💻 Authors

- 👨‍💻 Sherif – [GitHub](https://github.com/s7erif)
- 👨‍💻 Mahmoud Hesham – [GitHub](https://github.com/EL3oMaNy)

## 💡 Requirements

- .NET SDK
- Any C# IDE or terminal with `dotnet run`

## 📦 How to Run

```bash
dotnet run
```

## 📄 License

This project is open-source and free to use for learning and educational purposes.

---

Have fun playing! 🕹️
