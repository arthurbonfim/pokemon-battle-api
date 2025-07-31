# 🐱‍👤 Pokémon Battle API

A simple C# REST API built with ASP.NET Core that simulates Pokémon battles between players and classic Pokémon opponents. Each player can create a team, purchase and remove Pokémon, and battle other players based on their team's total power.

---

## 🔧 Technologies

- [.NET 9](https://dotnet.microsoft.com/)
- ASP.NET Core
- C#
- REST API

---

## 📁 Project Structure

- `Models/` — Core classes like `Player` and `Pokemon`
- `Dtos/` — Data Transfer Objects for input/output
- `Services/` — Business logic (e.g. `PlayersService`, `PokemonService`)
- `Data/` — In-memory fake database (`FakeDatabase.cs`)
- `Controllers/` — HTTP endpoints

---

## 🚀 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/pokemon-battle-api.git
   ```
2. Navigate to the project directory:
   ```bash
   cd pokemon-battle-api
   ```
3. Run the project:
   ```bash
   dotnet run
   ```
4. Access the API at: https://localhost:5001 or http://localhost:5000

---

## ✅ Features

- Create players

- List all players

- Buy/remove Pokémon from a player's team

- Simulate a battle between a player and an opponent (bot), based on total team power

---

## 📌 To-do

- Implement challenge system (ChallengeService)

- Type advantages/disadvantages in battles

- Add items and modifiers

- Switch to a real database (optional)

- Add Swagger for API documentation

---

## License

Educational and open source project. Feel free to use and modify.
MIT © Arthur Bonfim
