# 🚀 AI SQL Generator

An AI-powered web application that converts natural language into SQL queries using modern full-stack architecture.

---

## 🔥 Features

- 🧠 Convert plain English to SQL queries
- ⚡ Fast API response using OpenRouter AI
- 🎯 Clean and interactive UI
- 🔗 Full-stack integration (Angular + .NET)
- 💡 Supports JOINs, GROUP BY, filters, aggregations

---

## 🛠️ Tech Stack

### Frontend
- Angular
- TypeScript
- CSS (Custom UI Styling)

### Backend
- ASP.NET Core Web API
- C#

### AI Integration
- OpenRouter API (LLM-based SQL generation)

---

## 🏗️ Project Architecture
ai-sql-generator/
│
├── Backend/
│ └── AiSqlGeneratorApi/
│ ├── Controllers/
│ ├── Services/
│ ├── DTOs/
│ ├── Interfaces/
│ ├── Helpers/
│ └── Program.cs
│
├── Frontend/
│ └── ai-sql-frontend/
│ ├── src/app/
│ ├── services/
│ └── UI components


---

## 🔄 How It Works

1. User enters a natural language query
2. Angular frontend sends request to .NET API
3. Backend formats prompt using schema
4. Request sent to OpenRouter AI API
5. AI returns SQL query
6. Backend processes and returns response
7. Frontend displays formatted SQL

---

## 📸 Screenshots

### Main UI
<img width="1916" height="986" alt="image" src="https://github.com/user-attachments/assets/6d445001-0e21-4967-84ef-10078c9ae34e" />
<img width="1917" height="921" alt="image (1)" src="https://github.com/user-attachments/assets/e80b6f9c-062e-40ca-b731-25543e1d6498" />
### Generated SQL Output
<img width="1918" height="947" alt="image (2)" src="https://github.com/user-attachments/assets/5ded96af-3367-4d2f-9983-3ba0c93a7513" />

---

## ⚙️ Setup Instructions

### 1. Clone Repository

git clone https://github.com/Shainasmj/ai-sql-generator.git
cd ai-sql-generator


---

### 2. Backend Setup

cd Backend/AiSqlGeneratorApi
dotnet run


---

### 3. Frontend Setup

cd Frontend/ai-sql-frontend
npm install
ng serve


---

### 4. Configure API Key

Add your API key in:
appsettings.Development.json


⚠️ Never commit your API key.

---

## 🔐 Security

- API keys are stored securely (not pushed to GitHub)
- Environment-based configuration used

---

## 🚀 Future Improvements

- Query history
- Multiple database schema support
- Syntax highlighting
- Export SQL feature

---

## 👩‍💻 Author

**Shaina Sheethal M J**

---

## ⭐ If you like this project, give it a star!
