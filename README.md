# 🤖 GitHub LLM Evaluation – Real-World Issue Validation

This repository contains hands-on validation of Large Language Model (LLM)-generated software solutions against real-world GitHub issues from high-quality open-source projects.

> **Role Simulated:** `Senior Software Engineer – C# (LLM Evaluation & Repository Validation)`  
> Focused on bug triaging, code reproduction, AI validation, and documenting results to support LLM training.

---

## ✅ Completed Evaluations

| Repository   | Issue    | Description                                    | Status   |
|--------------|----------|------------------------------------------------|----------|
| AutoMapper   | #4542    | Constructor removed – `MapperConfiguration(...)` | ✅ Done |
| Hangfire     | #2522    | Scheduled jobs not being enqueued under load   | ✅ Done |
| Serilog      | –        | Triage planned                                  | 🔜 Next |

Each issue includes:
- A **reproduction project** (in `/BugDemo`)
- The original **LLM prompt**
- The **LLM response**
- A human-in-the-loop **evaluation report** (`Evaluation.md`)

---

## 🧠 Why This Matters

This project simulates the role of an LLM validation engineer:
- Evaluating how LLMs handle real bugs and migration challenges
- Verifying output accuracy, usefulness, and completeness
- Providing human-grounded feedback to help train smarter models

---

## 📂 Structure
GitHubTriageLLM/
│
├── AutoMapper_4542/
│ ├── BugDemo/ # Reproduction code
│ └── Evaluation.md # LLM prompt, response, verdict
│
├── Hangfire_2522/
│ ├── BugDemo/
│ └── Evaluation.md
│
└── README.md


---

## 👨‍💻 Author

**Saipavan Seelamsetty**  
🔗 [GitHub Profile](https://github.com/Seelamsetty-SaiPavan)

---

## 🛠️ Tools Used

- C# .NET 8 Console Apps
- GitHub issue triage
- Hangfire, AutoMapper
- Prompting and validating ChatGPT/GPT-4 output
- Markdown-based LLM logs

---

## 📌 Related Roles

This repository demonstrates readiness for:

- ✅ LLM Evaluation Engineer
- ✅ Software Engineering Prompt Designer
- ✅ AI-Powered QA Analyst
- ✅ Developer in AI/ML Human Feedback Loops

---

## 🤝 License

MIT License – Open for educational and research reuse.
